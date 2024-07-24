using System;
using BetterHUDInfo.InfoObjects;
using HarmonyLib;

namespace BetterHUDInfo.Patches
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(uGUI_DepthCompass))]
	[HarmonyPatch("IsCompassEnabled")]
	internal class uGUI_DepthCompass_IsCompassEnabled_Patch
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002284 File Offset: 0x00000484
		[HarmonyPostfix]
		private static void Postfix(bool __result)
		{
			Player main = Player.main;
			bool flag = main != null && ModInfo.PlayerInCyclopsCamera;
			if (flag)
			{
			}
		}
	}
}
