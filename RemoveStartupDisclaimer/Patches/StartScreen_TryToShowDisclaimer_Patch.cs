using System;
using HarmonyLib;
using RemoveStartupDisclaimer.Configuration;

namespace RemoveStartupDisclaimer.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(StartScreen))]
	[HarmonyPatch("TryToShowDisclaimer")]
	internal static class StartScreen_TryToShowDisclaimer_Patch
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000208C File Offset: 0x0000028C
		private static bool Prefix()
		{
			return !ConfigData.RemoveFlashingLightsDisclaimerValue;
		}
	}
}
