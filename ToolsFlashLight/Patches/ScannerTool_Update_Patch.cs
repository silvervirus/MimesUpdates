using System;
using HarmonyLib;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.InGame;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x0200000D RID: 13
	[HarmonyPatch(typeof(ScannerTool))]
	[HarmonyPatch("Update")]
	internal class ScannerTool_Update_Patch
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002A78 File Offset: 0x00000C78
		[HarmonyPostfix]
		public static void Postfix(ScannerTool __instance)
		{
			Light componentInChildren = __instance.GetComponentInChildren<Light>();
			EnergyMixin component = __instance.GetComponent<EnergyMixin>();
			Player value = Traverse.Create(__instance).Field("usingPlayer").GetValue<Player>();
			bool flag = value != null;
			if (flag)
			{
				ModInfo.ScannerToolIsUsed = true;
				ModInfo.AnyLEDToolIsUsed = true;
			}
			bool flag2 = Player.main != null && componentInChildren != null && component != null;
			if (flag2)
			{
				bool flag3 = CheckConditions.ToolsLightChipEquipped() || CheckConditions.ScannerLightChipEquipped();
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
					ModInfo.ScannerLightOn = true;
				}
				else
				{
					ModInfo.ScannerLightOn = false;
				}
			}
		}
	}
}
