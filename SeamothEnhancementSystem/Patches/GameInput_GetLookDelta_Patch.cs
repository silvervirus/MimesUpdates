using System;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(GameInput))]
	[HarmonyPatch("GetLookDelta")]
	internal class GameInput_GetLookDelta_Patch
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002210 File Offset: 0x00000410
		[HarmonyPrefix]
		public static bool Prefix()
		{
			bool electronicModuleIn = SeamothInfo.electronicModuleIn;
			if (electronicModuleIn)
			{
				bool flag = SeamothInfo.mechanicalModuleIn && SeamothInfo.safeEjectActive;
				if (flag)
				{
					return false;
				}
			}
			return true;
		}
	}
}
