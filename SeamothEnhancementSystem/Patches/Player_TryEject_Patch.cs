using System;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("TryEject")]
	internal class Player_TryEject_Patch
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002248 File Offset: 0x00000448
		[HarmonyPrefix]
		public static bool Prefix(Player __instance)
		{
			bool flag = __instance != null;
			bool flag5;
			if (flag)
			{
				Vehicle vehicle = __instance.GetVehicle() as SeaMoth;
				bool flag2 = SeamothInfo.electronicModuleIn && SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn && SeamothInfo.safeEjectOn;
				bool flag3 = vehicle != null && SeamothInfo.safetyModuleIn && flag2;
				if (flag3)
				{
					bool flag4 = vehicle.prevVelocity != GameInput.GetMoveDirection();
					if (flag4)
					{
						SeamothInfo.safeEjectActive = true;
						flag5 = false;
					}
					else
					{
						SeamothInfo.safeEjectActive = false;
						flag5 = true;
					}
				}
				else
				{
					flag5 = true;
				}
			}
			else
			{
				flag5 = true;
			}
			return flag5;
		}
	}
}
