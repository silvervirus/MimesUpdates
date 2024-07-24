using System;
using HarmonyLib;

namespace MoonpoolDisplayRepair.Patches
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(VehicleDockingBay))]
	[HarmonyPatch("Start")]
	public class VehicleDockingBay_Start_Patch
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002344 File Offset: 0x00000544
		[HarmonyPostfix]
		private static void Postfix(VehicleDockingBay __instance)
		{
			bool flag = __instance.subRoot is BaseRoot;
			if (flag)
			{
				__instance.CancelInvoke("RepairVehicle");
				__instance.InvokeRepeating("RepairVehicle", 0f, 5f);
			}
		}
	}
}
