using System;
using BetterHUDInfo.ManageGUI;
using HarmonyLib;

namespace BetterHUDInfo.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Start")]
	internal class Player_Start_Patch
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002258 File Offset: 0x00000458
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			bool flag = __instance != null;
			if (flag)
			{
				MakeAllGUIObjects.MakeAllGUIObj();
			}
		}
	}
}
