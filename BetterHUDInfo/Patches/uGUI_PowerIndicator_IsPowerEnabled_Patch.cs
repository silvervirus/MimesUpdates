using System;
using HarmonyLib;

namespace BetterHUDInfo.Patches
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(uGUI_PowerIndicator))]
	[HarmonyPatch("IsPowerEnabled")]
	internal class uGUI_PowerIndicator_IsPowerEnabled_Patch
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000024C8 File Offset: 0x000006C8
		[HarmonyPostfix]
		private static void Postfix(bool __result)
		{
			Player main = Player.main;
			bool flag = main != null && !main.IsInBase();
			if (flag)
			{
			}
		}
	}
}
