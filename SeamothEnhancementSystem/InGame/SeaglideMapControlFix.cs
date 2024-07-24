using System;
using HarmonyLib;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x0200003D RID: 61
	internal class SeaglideMapControlFix
	{
		// Token: 0x060000DC RID: 220 RVA: 0x0000AAFC File Offset: 0x00008CFC
		public static void SeaglideMapControlLightFix(SeaMoth thisSeaMoth)
		{
			bool flag = Player.main.GetRightHandDown() && SeamothInfo.preventLightToggle && OtherModsInfo.SeaglideMapControls;
			if (flag)
			{
				ToggleLights componentInChildren = thisSeaMoth.GetComponentInChildren<ToggleLights>();
				float value = Traverse.Create(thisSeaMoth).Field("timeLastPlayerModeChange").GetValue<float>();
				bool flag2 = !Player.main.GetPDA().isInUse && Time.time > value + 1f && SeamothInfo.timeLastLightToggle + 0.25f < Time.time;
				if (flag2)
				{
					componentInChildren.SetLightsActive(!componentInChildren.lightsActive);
					SeamothInfo.timeLastLightToggle = Time.time;
					componentInChildren.lightState++;
					bool flag3 = componentInChildren.lightState == componentInChildren.maxLightStates;
					if (flag3)
					{
						componentInChildren.lightState = 0;
					}
				}
			}
		}
	}
}
