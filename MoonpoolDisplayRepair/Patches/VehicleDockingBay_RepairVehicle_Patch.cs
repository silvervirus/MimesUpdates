using System;
using HarmonyLib;
using MoonpoolDisplayRepair.Configuration;

namespace MoonpoolDisplayRepair.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(VehicleDockingBay))]
	[HarmonyPatch("RepairVehicle")]
	public class VehicleDockingBay_RepairVehicle_Patch
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000228A File Offset: 0x0000048A
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002291 File Offset: 0x00000491
		public static bool hasPower { get; internal set; }

		// Token: 0x06000007 RID: 7 RVA: 0x0000229C File Offset: 0x0000049C
		[HarmonyPrefix]
		private static bool Prefix(VehicleDockingBay __instance)
		{
			VehicleDockingBay_RepairVehicle_Patch.hasPower = __instance.subRoot.gameObject.GetComponentInParent<PowerRelay>().IsPowered();
			bool isCyclops = __instance.GetComponentInParent<SubRoot>().isCyclops;
			bool flag = __instance.GetDockedVehicle() == null || __instance.GetDockedVehicle().liveMixin.IsFullHealth() || Config.RepairDockedSubSliderValue < 1f || !VehicleDockingBay_RepairVehicle_Patch.hasPower || (isCyclops && !__instance.subRoot.vehicleRepairUpgrade);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				__instance.GetDockedVehicle().liveMixin.AddHealth(Config.RepairDockedSubSliderValue);
				flag2 = false;
			}
			return flag2;
		}
	}
}
