using System;
using HarmonyLib;
using OxygenCanisters.Helpers;
using OxygenCanisters.Info;
using OxygenCanisters.InGame;
using OxygenCanisters.ManageGUI;
using Nautilus.Utility;
using UnityEngine;

namespace OxygenCanisters.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Update")]
	internal class Player_Update_Patch
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002214 File Offset: 0x00000414
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			bool flag = !Player.main.CanBreathe();
			if (flag)
			{
				
				bool flag4 = CheckConditions.OxygenCanisterInInventory() > 0 && Player.main.GetOxygenAvailable().IsBetween(0f, ModInfo.consumeOxyTrigger);
				if (flag4)
				{
					bool flag5 = !__instance.GetPDA().isInUse && !IngameMenu.main.focused;
					if (flag5)
					{
						DisplayPrompts.DisplayHint(FormatText.ConsumeCanisterHint(), true);
					}
				}
			}
			bool flag6 = CheckConditions.CanisterChipEquipped();
			if (flag6)
			{
				ManageAllGUIElements.ManageAllGuiElements();
				bool flag7 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.R);
				if (flag7)
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
					bool adjustText = ModInfo.adjustText;
					if (adjustText)
					{
						ModInfo.adjustText = false;
					}
					else
					{
						ModInfo.adjustText = true;
					}
				}
				bool adjustIcon2 = ModInfo.adjustIcon;
				if (adjustIcon2)
				{
					AdjustImages.AdjustIcon();
				}
				bool adjustText2 = ModInfo.adjustText;
				if (adjustText2)
				{
					AdjustImages.AdjustTxt();
				}
			}
			else
			{
				ManageAllGUIElements.TurnUIOff();
			}
			
		}
	}
}
