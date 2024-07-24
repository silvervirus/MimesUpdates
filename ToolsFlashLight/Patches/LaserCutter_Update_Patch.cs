using System;
using HarmonyLib;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.InGame;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(LaserCutter))]
	[HarmonyPatch("Update")]
	internal class LaserCutter_Update_Patch
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000025B8 File Offset: 0x000007B8
		[HarmonyPostfix]
		public static void Postfix(LaserCutter __instance)
		{
			Light[] componentsInChildren = __instance.GetComponentsInChildren<Light>();
			EnergyMixin component = __instance.GetComponent<EnergyMixin>();
			Player value = Traverse.Create(__instance).Field("usingPlayer").GetValue<Player>();
			bool flag = value != null;
			if (flag)
			{
				ModInfo.CutterToolIsUsed = true;
				ModInfo.AnyLEDToolIsUsed = true;
			}
			bool flag2 = Player.main != null && component != null;
			if (flag2)
			{
				foreach (Light light in componentsInChildren)
				{
					bool flag3 = light.name.ToString() == "LEDSpotlight";
					if (flag3)
					{
						bool flag4 = CheckConditions.ToolsLightChipEquipped() || CheckConditions.CutterLightChipEquipped();
						if (flag4)
						{
							ProcessLight.ProcessLightHandling(light, component);
							bool lightTesting = ModInfo.lightTesting;
							if (lightTesting)
							{
								TuneLight.TuneLightBeam(light);
							}
						}
						else
						{
							light.enabled = false;
						}
						bool enabled = light.enabled;
						if (enabled)
						{
							ModInfo.CutterLightOn = true;
						}
						else
						{
							ModInfo.CutterLightOn = false;
						}
					}
				}
			}
		}
	}
}
