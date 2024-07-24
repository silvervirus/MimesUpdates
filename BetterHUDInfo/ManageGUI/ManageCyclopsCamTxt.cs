using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000018 RID: 24
	internal class ManageCyclopsCamTxt
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000564C File Offset: 0x0000384C
		internal static void ManageCyclopsCamText(GameObject thisGameObject)
		{
			Player main = Player.main;
			bool flag = main != null;
			if (flag)
			{
				SubRoot currentSub = main.currentSub;
				bool flag2 = currentSub != null && ModInfo.PlayerInCyclopsCamera && Config.ShowHullPowerTempToggleValue;
				if (flag2)
				{
					Text component = thisGameObject.GetComponent<Text>();
					bool flag3 = thisGameObject == ManageAllGUIElements.CyclopsCamHealthTextObject;
					if (flag3)
					{
						LiveMixin component2 = currentSub.GetComponent<LiveMixin>();
						float healthFraction = component2.GetHealthFraction();
						component.text = HullState.ProcessVCHull(healthFraction);
					}
					else
					{
						bool flag4 = currentSub.powerRelay.GetMaxPower() != 0f;
						float num;
						if (flag4)
						{
							num = currentSub.powerRelay.GetPower() / currentSub.powerRelay.GetMaxPower();
						}
						else
						{
							num = 0f;
						}
						component.text = PowerState.ProcessPower(num);
					}
					thisGameObject.SetActive(true);
				}
				else
				{
					thisGameObject.SetActive(false);
				}
			}
		}
	}
}
