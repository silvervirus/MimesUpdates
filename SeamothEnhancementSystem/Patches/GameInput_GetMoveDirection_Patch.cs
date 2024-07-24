using System;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(GameInput))]
	[HarmonyPatch("GetMoveDirection")]
	internal class GameInput_GetMoveDirection_Patch
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002374 File Offset: 0x00000574
		[HarmonyPrefix]
		public static bool Prefix(ref Vector3 __result)
		{
			bool flag = SeamothInfo.mechanicalModuleIn && SeamothInfo.safeEjectActive;
			return !flag;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023A0 File Offset: 0x000005A0
		[HarmonyPostfix]
		public static void Postfix(ref Vector3 __result)
		{
			bool flag = SeamothInfo.electronicModuleIn && (!SeamothInfo.mechanicalModuleIn || !SeamothInfo.safeEjectActive);
			if (flag)
			{
				bool flag2 = Player.main.currentMountedVehicle != null && SeamothInfo.CruiseControlOn;
				if (flag2)
				{
					__result = new Vector3(__result.x, __result.y, 1f);
				}
				else
				{
					bool cruiseControlOn = SeamothInfo.CruiseControlOn;
					if (cruiseControlOn)
					{
						SeamothInfo.CruiseControlOn = false;
					}
				}
			}
		}
	}
}
