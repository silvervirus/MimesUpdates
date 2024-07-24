using System;
using HarmonyLib;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.InGame;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(Welder))]
	[HarmonyPatch("Update")]
	internal class Welder_Update_Patch
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002710 File Offset: 0x00000910
		[HarmonyPostfix]
		public static void Postfix(Welder __instance)
		{
			Light componentInChildren = __instance.GetComponentInChildren<Light>();
			EnergyMixin component = __instance.GetComponent<EnergyMixin>();
			Player value = Traverse.Create(__instance).Field("usingPlayer").GetValue<Player>();
			bool flag = value != null;
			if (flag)
			{
				ModInfo.WelderToolIsUsed = true;
				ModInfo.AnyLEDToolIsUsed = true;
			}
			bool flag2 = Player.main != null && componentInChildren != null && component != null;
			if (flag2)
			{
				bool flag3 = CheckConditions.ToolsLightChipEquipped() || CheckConditions.WelderLightChipEquipped();
				if (flag3)
				{
                    ProcessLight.ProcessLightHandling(componentInChildren, component);
                    bool lightTesting = ModInfo.lightTesting;
                    if (lightTesting)
                    {
                        TuneLight.TuneLightBeam(componentInChildren);
                    }
                }
				else
				{
					componentInChildren.enabled = false;
				}
			}
			bool flag4 = componentInChildren != null;
			if (flag4)
			{
				bool enabled = componentInChildren.enabled;
				if (enabled)
				{
					ModInfo.WelderLightOn = true;
				}
				else
				{
					ModInfo.WelderLightOn = false;
				}
			}
		}
	}
}
