using System;
using HarmonyLib;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.InGame;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x0200000B RID: 11
	[HarmonyPatch(typeof(BuilderTool))]
	[HarmonyPatch("Update")]
	internal class BuilderTool_Update_Patch
	{
		
		[HarmonyPostfix]
		public static void Postfix(BuilderTool __instance)
		{
			Light componentInChildren = __instance.GetComponentInChildren<Light>();
			EnergyMixin component = __instance.GetComponent<EnergyMixin>();
			Player value = Traverse.Create(__instance).Field("usingPlayer").GetValue<Player>();
			bool flag = value != null;
			if (flag)
			{
				ModInfo.BuilderToolIsUsed = true;
				ModInfo.AnyLEDToolIsUsed = true;
			}
			bool flag2 = Player.main != null && componentInChildren != null && component != null;
			if (flag2)
			{
				bool flag3 = CheckConditions.ToolsLightChipEquipped() || CheckConditions.BuilderLightChipEquipped();
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
					ModInfo.BuilderLightOn = true;
				}
				else
				{
					ModInfo.BuilderLightOn = false;
				}
			}
		}
	}
}
