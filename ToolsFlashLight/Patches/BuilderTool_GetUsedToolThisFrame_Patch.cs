using System;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(BuilderTool))]
	[HarmonyPatch("GetUsedToolThisFrame")]
	internal class BuilderTool_GetUsedToolThisFrame_Patch
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002298 File Offset: 0x00000498
		[HarmonyPostfix]
		public static void Postfix(BuilderTool __instance, ref bool __result)
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
