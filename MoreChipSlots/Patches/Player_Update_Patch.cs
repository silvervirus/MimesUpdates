using System;
using HarmonyLib;

namespace MoreChipSlots.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Update")]
	internal class Player_Update_Patch
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000021C8 File Offset: 0x000003C8
		[HarmonyPostfix]
		public static void Postfix()
		{
		}
	}
}
