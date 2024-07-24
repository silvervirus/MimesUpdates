using System;
using SeamothEnhancementSystem.Modules;
using UnityEngine;

namespace SeamothEnhancementSystem.InfoObjects
{
	// Token: 0x02000011 RID: 17
	internal static class SeamothInfo
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00004798 File Offset: 0x00002998
		public static void CheckModuleStatus(Vehicle thisSeaMoth)
		{
			bool flag = Player.main != null;
			if (flag)
			{
				Inventory main = Inventory.main;
				SeamothInfo.seamothLinkModuleIn = main.equipment.GetCount(SeamothLink.TechTypeID) > 0;
			}
			SeamothInfo.mainModuleIn = thisSeaMoth.modules.GetCount(SeamothEnhancementSystemModule.TechTypeID) > 0;
			SeamothInfo.safetyModuleIn = thisSeaMoth.modules.GetCount(SeamothSafetyModule.TechTypeID) > 0;
			bool flag2 = SeamothInfo.mainModuleIn;
			if (flag2)
			{
				SeamothInfo.electricalModuleIn = true;
				SeamothInfo.electronicModuleIn = true;
				SeamothInfo.mechanicalModuleIn = true;
			}
			else
			{
				SeamothInfo.electricalModuleIn = thisSeaMoth.modules.GetCount(ElectricalEnhancement.TechTypeID) > 0;
				SeamothInfo.electronicModuleIn = thisSeaMoth.modules.GetCount(ElectronicEnhancement.TechTypeID) > 0;
				SeamothInfo.mechanicalModuleIn = thisSeaMoth.modules.GetCount(MechanicalEnhancement.TechTypeID) > 0;
			}
		}

		// Token: 0x04000014 RID: 20
		internal static bool CruiseControlOn = false;

		// Token: 0x04000015 RID: 21
		internal static bool ModeGreenOn = false;

		// Token: 0x04000016 RID: 22
		internal static bool ModeChanged = false;

		// Token: 0x04000017 RID: 23
		internal static bool NoBatteries = false;

		// Token: 0x04000018 RID: 24
		internal static float TurboModeCutoff = 20f;

		// Token: 0x04000019 RID: 25
		internal static bool safeDepthChargerOn = true;

		// Token: 0x0400001A RID: 26
		internal static float safeDepthChargerCutoff = 15f;

		// Token: 0x0400001B RID: 27
		internal static float safeDepthChargerGearVal = 5f;

		// Token: 0x0400001C RID: 28
		internal static bool safeDepthChargerActive = false;

		// Token: 0x0400001D RID: 29
		internal static bool safeDepthChargerGearLightLock = false;

		// Token: 0x0400001E RID: 30
		internal static bool safeCruiseOn = true;

		// Token: 0x0400001F RID: 31
		internal static bool safeEjectOn = true;

		// Token: 0x04000020 RID: 32
		internal static bool safeEjectActive = false;

		// Token: 0x04000021 RID: 33
		internal static float lastSeamothGearValue = 0f;

		// Token: 0x04000022 RID: 34
		internal static int MainBatteryCount = 0;

		// Token: 0x04000023 RID: 35
		internal static int TotalBatteryCount = 0;

		// Token: 0x04000024 RID: 36
		internal static int BatteryInSlot = 0;

		// Token: 0x04000025 RID: 37
		internal static float timeLastLightToggle = Time.time;

		// Token: 0x04000026 RID: 38
		internal static bool preventLightToggle = false;

		// Token: 0x04000027 RID: 39
		internal static float thisLightSafetySpotAngle = 100f;

		// Token: 0x04000028 RID: 40
		internal static float thisLightSafetyIntensity = 0.6f;

		// Token: 0x04000029 RID: 41
		internal static float thisLightSafetyRange = 30f;

		// Token: 0x0400002A RID: 42
		internal static float thisLightLowSpotAngle = 100f;

		// Token: 0x0400002B RID: 43
		internal static float thisLightLowIntensity = 1f;

		// Token: 0x0400002C RID: 44
		internal static float thisLightLowRange = 60f;

		// Token: 0x0400002D RID: 45
		internal static float thisLightHighSpotAngle = 50f;

		// Token: 0x0400002E RID: 46
		internal static float thisLightHighIntensity = 1.6f;

		// Token: 0x0400002F RID: 47
		internal static float thisLightHighRange = 180f;

		// Token: 0x04000030 RID: 48
		internal static float timer;

		// Token: 0x04000031 RID: 49
		internal static float ChargerTimer;

		// Token: 0x04000032 RID: 50
		internal static float EjectTimer;

		// Token: 0x04000033 RID: 51
		internal static float CcTimer;

		// Token: 0x04000034 RID: 52
		internal static bool electricalModuleIn;

		// Token: 0x04000035 RID: 53
		internal static bool electronicModuleIn;

		// Token: 0x04000036 RID: 54
		internal static bool mechanicalModuleIn;

		// Token: 0x04000037 RID: 55
		internal static bool seamothLinkModuleIn;

		// Token: 0x04000038 RID: 56
		internal static bool mainModuleIn;

		// Token: 0x04000039 RID: 57
		internal static bool safetyModuleIn;
	}
}
