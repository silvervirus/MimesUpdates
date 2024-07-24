using System;
using HarmonyLib;
using OxygenAudioMonitor.Helpers;
using OxygenAudioMonitor.InfoObjects;
using OxygenAudioMonitor.ManageGUI;
using Nautilus.Utility;
using UnityEngine;

namespace OxygenAudioMonitor.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Update")]
	internal class Player_Update_Patch
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000216C File Offset: 0x0000036C
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			bool flag = CheckConditions.AudioChipEquipped() && !Player.main.CanBreathe() && CheckConditions.PlayerTankEquipped();
			if (flag)
			{
				float num = __instance.GetOxygenAvailable() / __instance.GetOxygenCapacity() * 100f;
				bool flag2 = (int)num < 50 && ModInfo.isOKtoPlayTankFifty;
				if (flag2)
				{
					FlickSwitch.FlickSoundSwitch("event:/player/oxygen_50", 50);
					ModInfo.colorChangeTrigger = true;
				}
				else
				{
					bool flag3 = (int)num < 25 && ModInfo.isOKtoPlayTankTwenty;
					if (flag3)
					{
						FlickSwitch.FlickSoundSwitch("event:/player/oxygen_25", 25);
						ModInfo.colorChangeTrigger = true;
					}
					else
					{
						bool flag4 = (int)num < 10 && ModInfo.isOKtoPlayTankTen;
						if (flag4)
						{
							FlickSwitch.FlickSoundSwitch("event:/player/oxygen_10", 10);
							ModInfo.colorChangeTrigger = true;
						}
					}
				}
				bool flag5 = num > 50f && !ModInfo.isOKtoPlayTankFifty;
				if (flag5)
				{
					ModInfo.isOKtoPlayTankFifty = true;
				}
				bool flag6 = num > 25f && !ModInfo.isOKtoPlayTankTwenty;
				if (flag6)
				{
					ModInfo.isOKtoPlayTankTwenty = true;
				}
				bool flag7 = num > 10f && !ModInfo.isOKtoPlayTankTen;
				if (flag7)
				{
					ModInfo.isOKtoPlayTankTen = true;
				}
			}
			ManageAllGUIElements.ManageAllGuiElements();
			bool flag8 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.Y);
			if (flag8)
			{
				bool adjustIcon = ModInfo.adjustIcon;
				if (adjustIcon)
				{
					ModInfo.adjustIcon = false;
				}
				else
				{
					ModInfo.adjustIcon = true;
				}
			}
			bool adjustIcon2 = ModInfo.adjustIcon;
			if (adjustIcon2)
			{
				bool flag9 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
				if (flag9)
				{
					ManageAllGUIElements.MoveImage(1f, "UpDown");
				}
				bool flag10 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
				if (flag10)
				{
					ManageAllGUIElements.MoveImage(-1f, "UpDown");
				}
				bool flag11 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
				if (flag11)
				{
					ManageAllGUIElements.MoveImage(-1f, "LeftRight");
				}
				bool flag12 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
				if (flag12)
				{
					ManageAllGUIElements.MoveImage(1f, "LeftRight");
				}
				bool flag13 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
				if (flag13)
				{
					ManageAllGUIElements.ResizeImage(1f, "sizeY");
				}
				bool flag14 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
				if (flag14)
				{
					ManageAllGUIElements.ResizeImage(-1f, "sizeY");
				}
				bool flag15 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
				if (flag15)
				{
					ManageAllGUIElements.ResizeImage(-1f, "sizeX");
				}
				bool flag16 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
				if (flag16)
				{
					ManageAllGUIElements.ResizeImage(1f, "sizeX");
				}
				DisplayPrompts.DisplayHint("UpDown: " + ModInfo.moveUpDownY.ToString(), true);
				DisplayPrompts.DisplayHint(", LeftRight: " + ModInfo.moveLeftRightX.ToString(), true);
				DisplayPrompts.DisplayHint(", Y: " + ModInfo.sizeY.ToString(), false);
				DisplayPrompts.DisplayHint("Size X: " + ModInfo.sizeX.ToString(), false);
			}
		}
	}
}
