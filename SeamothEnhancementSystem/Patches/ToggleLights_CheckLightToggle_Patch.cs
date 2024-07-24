using System;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(ToggleLights))]
	[HarmonyPatch("CheckLightToggle")]
	internal class ToggleLights_CheckLightToggle_Patch
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002354 File Offset: 0x00000554
		[HarmonyPrefix]
		public static bool Prefix(ToggleLights __instance)
		{
			bool preventLightToggle = SeamothInfo.preventLightToggle;
			return !preventLightToggle;
		}
	}
}
