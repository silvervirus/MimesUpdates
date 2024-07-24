using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;
using BetterHUDInfo.InfoObjects;
using HarmonyLib;
using UnityEngine;

namespace BetterHUDInfo.Patches
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(uGUI_SeamothHUD))]
	[HarmonyPatch("Update")]
	internal class uGUI_SeamothHUD_Update_Patch
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000026B0 File Offset: 0x000008B0
		[HarmonyPrefix]
		public static bool Prefix(uGUI_SeamothHUD __instance)
		{
			bool flag = Player.main != null && ModInfo.ChipInserted && Config.ShowHullPowerTempToggleValue && ModInfo.PlayerIsFree && !Player.main.GetPDA().isInUse;
			bool flag7;
			if (flag)
			{
				SubRoot currentSub = Player.main.currentSub;
				__instance.root.SetActive(true);
				bool flag2 = !Player.main.IsInside();
				if (flag2)
				{
					__instance.textHealth.text = HullState.ItemHullState();
					__instance.textPower.text = PowerState.ItemPowerState();
					__instance.textTemperature.text = TempState.PlayerWaterTemp();
				}
				bool flag3 = ModInfo.PlayerInBaseFree && currentSub != null;
				if (flag3)
				{
					BaseHullStrength component = currentSub.GetComponent<BaseHullStrength>();
					float num = (float)Mathf.RoundToInt(component.GetTotalStrength());
					__instance.textHealth.text = HullState.ProcessBaseHull(num);
					bool flag4 = currentSub.powerRelay.GetMaxPower() != 0f;
					float num2;
					if (flag4)
					{
						num2 = currentSub.powerRelay.GetPower() / currentSub.powerRelay.GetMaxPower();
					}
					else
					{
						num2 = 0f;
					}
					__instance.textPower.text = PowerState.ProcessPower(num2);
					__instance.textTemperature.text = TempState.PlayerWaterTemp();
				}
				bool flag5 = ModInfo.PlayerInCyclopsFree && currentSub != null;
				if (flag5)
				{
					LiveMixin component2 = currentSub.GetComponent<LiveMixin>();
					float healthFraction = component2.GetHealthFraction();
					__instance.textHealth.text = HullState.ProcessVCHull(healthFraction);
					bool flag6 = currentSub.powerRelay.GetMaxPower() != 0f;
					float num3;
					if (flag6)
					{
						num3 = currentSub.powerRelay.GetPower() / currentSub.powerRelay.GetMaxPower();
					}
					else
					{
						num3 = 0f;
					}
					__instance.textPower.text = PowerState.ProcessPower(num3);
					__instance.textTemperature.text = TempState.PlayerWaterTemp();
				}
				flag7 = false;
			}
			else
			{
				flag7 = true;
			}
			return flag7;
		}
	}
}
