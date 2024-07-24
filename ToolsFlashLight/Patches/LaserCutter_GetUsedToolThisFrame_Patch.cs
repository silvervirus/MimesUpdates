using System;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(LaserCutter))]
	[HarmonyPatch("GetUsedToolThisFrame")]
	internal class LaserCutter_GetUsedToolThisFrame_Patch
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000022DC File Offset: 0x000004DC
		[HarmonyPostfix]
		public static void Postfix(LaserCutter __instance, ref bool __result)
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
