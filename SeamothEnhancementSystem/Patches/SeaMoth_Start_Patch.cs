using System;
using HarmonyLib;
using SeamothEnhancementSystem.InGame;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(SeaMoth))]
	[HarmonyPatch("Start")]
	internal class SeaMoth_Start_Patch
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002330 File Offset: 0x00000530
		[HarmonyPrefix]
		public static bool Prefix(SeaMoth __instance)
		{
			bool pilotingMode = __instance.GetPilotingMode();
			if (pilotingMode)
			{
				MonitorBatteryCount.MonitorSeamothBatteryCount(__instance);
			}
			return true;
		}
	}
}
