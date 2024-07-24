using System;
using HarmonyLib;
using Nautilus.Utility;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.ManageGUI;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Update")]
	internal class Player_Update_Patch
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000234C File Offset: 0x0000054C
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			ManageAllGUIElements.ManageAllGuiElements();
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.T);
			if (flag)
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
				bool flag2 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
				if (flag2)
				{
					ManageAllGUIElements.MoveImage(1f, "UpDown");
				}
				bool flag3 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
				if (flag3)
				{
					ManageAllGUIElements.MoveImage(-1f, "UpDown");
				}
				bool flag4 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
				if (flag4)
				{
					ManageAllGUIElements.MoveImage(-1f, "LeftRight");
				}
				bool flag5 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
				if (flag5)
				{
					ManageAllGUIElements.MoveImage(1f, "LeftRight");
				}
				bool flag6 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
				if (flag6)
				{
					ManageAllGUIElements.ResizeImage(1f, "sizeY");
				}
				bool flag7 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
				if (flag7)
				{
					ManageAllGUIElements.ResizeImage(-1f, "sizeY");
				}
				bool flag8 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
				if (flag8)
				{
					ManageAllGUIElements.ResizeImage(-1f, "sizeX");
				}
				bool flag9 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
				if (flag9)
				{
					ManageAllGUIElements.ResizeImage(1f, "sizeX");
				}
				DisplayPrompts.DisplayHint("UpDown: " + ModInfo.moveUpDownY.ToString(), true);
				DisplayPrompts.DisplayHint(", LeftRight: " + ModInfo.onOffLeftRightX.ToString(), true);
				DisplayPrompts.DisplayHint(" Scanner Used: " + ModInfo.ScannerToolIsUsed.ToString(), false);
			}
		}
	}
}
