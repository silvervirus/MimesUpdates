using System;
using System.Text;
using HarmonyLib;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Helpers;
using ImmersiveOutcropBreak.Info;
using ImmersiveOutcropBreak.InGame;
using ImmersiveOutcropBreak.ManageGUI;
using UnityEngine;

namespace ImmersiveOutcropBreak.Patches
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Update")]
	internal class Player_Update_Patch
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002888 File Offset: 0x00000A88
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			bool flag = __instance != null && IngameMenu.main != null;
			if (flag)
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag2 = !FPSInputModule.current.lockMovement;
				if (flag2)
				{
					bool showPulseHintToggleValue = Config.ShowPulseHintToggleValue;
					if (showPulseHintToggleValue)
					{
						bool flag3 = CheckConditions.AnyGloveChipEquipped();
						if (flag3)
						{
							bool flag4 = !__instance.IsPiloting() && !__instance.GetPDA().isInUse && !IngameMenu.main.focused;
							if (flag4)
							{
								DisplayPrompts.DisplayHint(FormatText.PulseOnOffHint());
							}
						}
					}
					bool showAutoPickupHintToggleValue = Config.ShowAutoPickupHintToggleValue;
					if (showAutoPickupHintToggleValue)
					{
						bool flag5 = CheckConditions.HiTechGloveChipEquipped() && CheckConditions.PlayerAdvancedGlovesEquipped();
						if (flag5)
						{
							bool flag6 = !__instance.IsPiloting() && !__instance.GetPDA().isInUse && !IngameMenu.main.focused;
							if (flag6)
							{
								DisplayPrompts.DisplayHint(FormatText.AutoPickupHint());
							}
						}
					}
					bool flag7 = Config.ShowAutoBreakHintToggleValue && ModInfo.PulseOnNow;
					if (flag7)
					{
						bool flag8 = CheckConditions.HiTechGloveChipEquipped() && CheckConditions.PlayerAdvancedGlovesEquipped();
						if (flag8)
						{
							bool flag9 = !__instance.IsPiloting() && !__instance.GetPDA().isInUse && !IngameMenu.main.focused;
							if (flag9)
							{
								DisplayPrompts.DisplayHint(FormatText.AutoBreakHint());
							}
						}
					}
					bool showInventoryHintToggleValue = Config.ShowInventoryHintToggleValue;
					if (showInventoryHintToggleValue)
					{
						bool flag10 = CheckConditions.LoTechGloveChipEquipped() || CheckConditions.MidTechGloveChipEquipped() || CheckConditions.HiTechGloveChipEquipped();
						if (flag10)
						{
							bool flag11 = !__instance.IsPiloting() && !__instance.GetPDA().isInUse && !IngameMenu.main.focused;
							if (flag11)
							{
								DisplayPrompts.DisplayHint(FormatText.InventoryHint());
							}
						}
					}
					string text = stringBuilder.ToString();
					bool flag12 = text != "";
					if (flag12)
					{
						DisplayPrompts.DisplayHint(text);
					}
					ModInfo.thisOutcrop = __instance.GetComponentInChildren<GUIHand>();
					bool flag13 = ModInfo.thisOutcrop != null;
					if (flag13)
					{
						GameObject activeTarget = __instance.GetComponentInChildren<GUIHand>().GetActiveTarget();
						bool flag14 = activeTarget == null;
						if (flag14)
						{
							ModInfo.FirstRunDone = false;
							bool flag15 = ModInfo.ShowInventoryNow && CheckConditions.AnyGloveChipEquipped() && !__instance.IsPiloting() && !__instance.GetPDA().isInUse && !IngameMenu.main.focused;
							if (flag15)
							{
								DisplayInventory.DisplayInventoryInfo();
							}
						}
					}
					MonitorPulseOnOffKey.MonitorPulseOnOffKeyDown();
					MonitorAutoBreakKey.MonitorAutoBreakKeyDown();
					MonitorAutoPickupKey.MonitorAutoPickupKeyDown();
					MonitorShowInventoryKey.MonitorShowInventoryKeyDown();
				}
				bool flag16 = HandReticle.main.CurrentIconType == HandReticle.IconType.Default;
				if (flag16)
				{
					ModInfo.ShowPulses = true;
				}
				else
				{
					ModInfo.ShowPulses = false;
				}
				ManageAllGUIElements.ManageAllUI();
			}
		}
	}
}
