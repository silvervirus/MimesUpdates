using System;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000009 RID: 9
	[HarmonyPatch(typeof(Welder))]
	[HarmonyPatch("GetUsedToolThisFrame")]
	internal class Welder_GetUsedToolThisFrame_Patch
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000026CC File Offset: 0x000008CC
		[HarmonyPostfix]
		public static void Postfix(Welder __instance, ref bool __result)
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
