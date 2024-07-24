using System;
using HarmonyLib;
using ImmersiveOutcropBreak.ManageGUI;

namespace ImmersiveOutcropBreak.Patches
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Start")]
	internal class Player_Start_Patch
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000285C File Offset: 0x00000A5C
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
