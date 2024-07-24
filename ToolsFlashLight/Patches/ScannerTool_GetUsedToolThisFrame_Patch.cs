using System;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(ScannerTool))]
	[HarmonyPatch("GetUsedToolThisFrame")]
	internal class ScannerTool_GetUsedToolThisFrame_Patch
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002574 File Offset: 0x00000774
		[HarmonyPostfix]
		public static void Postfix(ScannerTool __instance, ref bool __result)
		{
			Light componentInChildren = __instance.GetComponentInChildren<Light>();
			bool flag = Player.main != null && componentInChildren != null && ModInfo.lightIsBeingChanged;
			if (flag)
			{
				__result = true;
			}
		}
	}
}
