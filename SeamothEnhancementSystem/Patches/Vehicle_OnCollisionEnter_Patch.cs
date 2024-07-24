using System;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(Vehicle))]
	[HarmonyPatch("OnCollisionEnter")]
	internal class Vehicle_OnCollisionEnter_Patch
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000022E0 File Offset: 0x000004E0
		[HarmonyPostfix]
		public static void Postfix(Vehicle __instance)
		{
			bool flag = __instance != null;
			if (flag)
			{
				bool flag2 = Player.main.currentMountedVehicle == __instance && SeamothInfo.CruiseControlOn && SeamothInfo.safetyModuleIn && SeamothInfo.safeCruiseOn;
				if (flag2)
				{
					SeamothInfo.CruiseControlOn = false;
				}
			}
		}
	}
}
