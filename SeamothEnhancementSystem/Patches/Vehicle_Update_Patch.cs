using System;
using HarmonyLib;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x0200000E RID: 14
	[HarmonyPatch(typeof(Vehicle))]
	[HarmonyPatch("Update")]
	internal class Vehicle_Update_Patch
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00003684 File Offset: 0x00001884
		public static void ConsumeHighBeamEnergy(Vehicle thisVehicle, float thisEnergyCost)
		{
			EnergyInterface component = thisVehicle.GetComponent<EnergyInterface>();
			float num = DayNightCycle.main.deltaTime * thisEnergyCost;
			component.ConsumeEnergy(num);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000036B0 File Offset: 0x000018B0
		public static void AddTrickleChargeEnergy(Vehicle thisVehicle, float thisEnergyGain)
		{
			EnergyInterface component = thisVehicle.GetComponent<EnergyInterface>();
			float num = DayNightCycle.main.deltaTime * thisEnergyGain;
			component.AddEnergy(num);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000036DC File Offset: 0x000018DC
		[HarmonyPostfix]
		public static void Postfix(Vehicle __instance)
		{
			Player main = Player.main;
			Vehicle vehicle = __instance as SeaMoth;
			ToggleLights componentInChildren = __instance.GetComponentInChildren<ToggleLights>();
			bool flag = main != null && vehicle != null;
			if (flag)
			{
				bool flag2 = Player.main.GetMode() == Player.Mode.LockedPiloting;
				bool flag3 = flag2 && Player.main.GetVehicle() == vehicle;
				if (flag3)
				{
					EnergyMixin component = __instance.GetComponent<EnergyMixin>();
					EnergyInterface component2 = component.GetComponent<EnergyInterface>();
					float num;
					float num2;
					component2.GetValues(out num, out num2);
					bool flag4 = SeamothInfo.ModeChanged && SeamothInfo.electronicModuleIn;
					if (flag4)
					{
						bool modeGreenOn = SeamothInfo.ModeGreenOn;
						if (modeGreenOn)
						{
							Vehicle_Update_Patch.turboPlus = 0f;
							Vehicle_Update_Patch.highBeamEnergyCost = 0.025f;
						}
						else
						{
							Vehicle_Update_Patch.turboPlus = 2f;
							Vehicle_Update_Patch.highBeamEnergyCost = 0.05f;
						}
					}
					bool flag5 = componentInChildren != null;
					if (flag5)
					{
						Vehicle_Update_Patch.LightsAreOn = componentInChildren.GetLightsActive();
					}
					bool flag6 = Vehicle_Update_Patch.HighBeamOn && Vehicle_Update_Patch.LightsAreOn;
					if (flag6)
					{
						Vehicle_Update_Patch.ConsumeHighBeamEnergy(__instance, Vehicle_Update_Patch.highBeamEnergyCost);
					}
					bool flag7 = SeamothInfo.safetyModuleIn && SeamothInfo.electricalModuleIn && SeamothInfo.safeDepthChargerOn;
					if (flag7)
					{
						int num3;
						int num4;
						__instance.GetDepth(out num3, out num4);
						bool flag8 = num < SeamothInfo.safeDepthChargerGearVal;
						if (flag8)
						{
							SeamothInfo.safeDepthChargerGearLightLock = true;
							bool flag9 = Config.SeamothGearValue != 1f;
							if (flag9)
							{
								Config.SeamothGearValue = 1f;
								PlayerPrefs.SetFloat("SeamothGearValueSlider", Config.SeamothGearValue);
							}
							bool highBeamOn = Vehicle_Update_Patch.HighBeamOn;
							if (highBeamOn)
							{
								Utils.PlayEnvSound(componentInChildren.lightsOffSound, componentInChildren.lightsOffSound.gameObject.transform.position, 20f);
								Vehicle_Update_Patch.HighBeamOn = false;
							}
							Vehicle_Update_Patch.AddTrickleChargeEnergy(__instance, 0.03f);
						}
						else
						{
							SeamothInfo.safeDepthChargerGearLightLock = false;
						}
						bool flag10 = num < SeamothInfo.safeDepthChargerCutoff;
						if (flag10)
						{
							SeamothInfo.safeDepthChargerActive = true;
						}
						else
						{
							bool flag11 = num > SeamothInfo.safeDepthChargerCutoff + 1f;
							if (flag11)
							{
								SeamothInfo.safeDepthChargerActive = false;
							}
						}
						bool safeDepthChargerActive = SeamothInfo.safeDepthChargerActive;
						if (safeDepthChargerActive)
						{
							int num5 = num3;
							bool flag12 = num3 > 50;
							if (flag12)
							{
								num5 = 50;
							}
							bool vehicleOxygenUpgrade = OtherModsInfo.VehicleOxygenUpgrade;
							if (vehicleOxygenUpgrade)
							{
								Vehicle_Update_Patch.AddTrickleChargeEnergy(__instance, (float)num5 / 500f + 0.05f);
							}
							else
							{
								Vehicle_Update_Patch.AddTrickleChargeEnergy(__instance, (float)num5 / 500f);
							}
						}
					}
					else
					{
						SeamothInfo.safeDepthChargerGearLightLock = false;
						SeamothInfo.safeDepthChargerActive = false;
					}
					bool flag13 = !SeamothInfo.electronicModuleIn;
					if (flag13)
					{
						bool modeGreenOn2 = SeamothInfo.ModeGreenOn;
						if (modeGreenOn2)
						{
							SeamothInfo.ModeGreenOn = false;
							SeamothInfo.ModeChanged = true;
						}
						bool cruiseControlOn = SeamothInfo.CruiseControlOn;
						if (cruiseControlOn)
						{
							SeamothInfo.CruiseControlOn = false;
						}
					}
					bool flag14 = !SeamothInfo.mechanicalModuleIn;
					if (flag14)
					{
						bool flag15 = Config.SeamothGearValue != 4f;
						if (flag15)
						{
							Config.SeamothGearValue = 4f;
							PlayerPrefs.SetFloat("SeamothGearValueSlider", Config.SeamothGearValue);
						}
					}
					bool flag16 = SeamothInfo.mechanicalModuleIn || SeamothInfo.electronicModuleIn;
					if (flag16)
					{
						bool flag17 = Config.SeamothGearValue == 1f && (SeamothInfo.lastSeamothGearValue != 1f || SeamothInfo.ModeChanged);
						if (flag17)
						{
							vehicle.forwardForce = Vehicle_Update_Patch.forwardForce - Vehicle_Update_Patch.largeFactor * 3f;
							vehicle.backwardForce = Vehicle_Update_Patch.backwardForce - Vehicle_Update_Patch.smallFactor * 3f;
							vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce - Vehicle_Update_Patch.largeFactor * 3f;
							vehicle.verticalForce = Vehicle_Update_Patch.verticalForce - Vehicle_Update_Patch.largeFactor * 2.5f;
							SeamothInfo.lastSeamothGearValue = 1f;
						}
						else
						{
							bool flag18 = Config.SeamothGearValue == 2f && (SeamothInfo.lastSeamothGearValue != 2f || SeamothInfo.ModeChanged);
							if (flag18)
							{
								vehicle.forwardForce = Vehicle_Update_Patch.forwardForce - Vehicle_Update_Patch.largeFactor * 2f + Vehicle_Update_Patch.turboPlus;
								vehicle.backwardForce = Vehicle_Update_Patch.backwardForce - Vehicle_Update_Patch.smallFactor * 2f + Vehicle_Update_Patch.turboPlus;
								vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce - Vehicle_Update_Patch.largeFactor * 2f + Vehicle_Update_Patch.turboPlus;
								vehicle.verticalForce = Vehicle_Update_Patch.verticalForce - Vehicle_Update_Patch.largeFactor * 2f + Vehicle_Update_Patch.turboPlus;
								SeamothInfo.lastSeamothGearValue = 2f;
							}
							else
							{
								bool flag19 = Config.SeamothGearValue == 3f && (SeamothInfo.lastSeamothGearValue != 3f || SeamothInfo.ModeChanged);
								if (flag19)
								{
									vehicle.forwardForce = Vehicle_Update_Patch.forwardForce - Vehicle_Update_Patch.largeFactor + Vehicle_Update_Patch.turboPlus;
									vehicle.backwardForce = Vehicle_Update_Patch.backwardForce - Vehicle_Update_Patch.smallFactor + Vehicle_Update_Patch.turboPlus;
									vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce - Vehicle_Update_Patch.largeFactor + Vehicle_Update_Patch.turboPlus;
									vehicle.verticalForce = Vehicle_Update_Patch.verticalForce - Vehicle_Update_Patch.largeFactor + Vehicle_Update_Patch.turboPlus;
									SeamothInfo.lastSeamothGearValue = 3f;
								}
								else
								{
									bool flag20 = Config.SeamothGearValue == 4f && (SeamothInfo.lastSeamothGearValue != 4f || SeamothInfo.ModeChanged);
									if (flag20)
									{
										vehicle.forwardForce = Vehicle_Update_Patch.forwardForce + Vehicle_Update_Patch.turboPlus;
										vehicle.backwardForce = Vehicle_Update_Patch.backwardForce + Vehicle_Update_Patch.turboPlus;
										vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce + Vehicle_Update_Patch.turboPlus;
										vehicle.verticalForce = Vehicle_Update_Patch.verticalForce + Vehicle_Update_Patch.turboPlus;
										SeamothInfo.lastSeamothGearValue = 4f;
									}
									else
									{
										bool flag21 = Config.SeamothGearValue == 5f && (SeamothInfo.lastSeamothGearValue != 5f || SeamothInfo.ModeChanged);
										if (flag21)
										{
											vehicle.forwardForce = Vehicle_Update_Patch.forwardForce + Vehicle_Update_Patch.largeFactor + Vehicle_Update_Patch.turboPlus * 2f;
											vehicle.backwardForce = Vehicle_Update_Patch.backwardForce + Vehicle_Update_Patch.smallFactor + Vehicle_Update_Patch.turboPlus * 2f;
											vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce + Vehicle_Update_Patch.largeFactor + Vehicle_Update_Patch.turboPlus * 2f;
											vehicle.verticalForce = Vehicle_Update_Patch.verticalForce + Vehicle_Update_Patch.largeFactor + Vehicle_Update_Patch.turboPlus * 2f;
											SeamothInfo.lastSeamothGearValue = 5f;
										}
										else
										{
											bool flag22 = Config.SeamothGearValue == 6f && (SeamothInfo.lastSeamothGearValue != 6f || SeamothInfo.ModeChanged);
											if (flag22)
											{
												vehicle.forwardForce = Vehicle_Update_Patch.forwardForce + Vehicle_Update_Patch.largeFactor * 2f + Vehicle_Update_Patch.turboPlus * 2f;
												vehicle.backwardForce = Vehicle_Update_Patch.backwardForce + Vehicle_Update_Patch.smallFactor * 2f + Vehicle_Update_Patch.turboPlus * 2f;
												vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce + Vehicle_Update_Patch.largeFactor * 2f + Vehicle_Update_Patch.turboPlus * 2f;
												vehicle.verticalForce = Vehicle_Update_Patch.verticalForce + Vehicle_Update_Patch.largeFactor * 2f + Vehicle_Update_Patch.turboPlus * 2f;
												SeamothInfo.lastSeamothGearValue = 6f;
											}
										}
									}
								}
							}
						}
						SeamothInfo.ModeChanged = false;
					}
					else
					{
						bool flag23 = SeamothInfo.lastSeamothGearValue != 0f;
						if (flag23)
						{
							vehicle.forwardForce = Vehicle_Update_Patch.forwardForce;
							vehicle.backwardForce = Vehicle_Update_Patch.backwardForce;
							vehicle.sidewardForce = Vehicle_Update_Patch.sidewardForce;
							vehicle.verticalForce = Vehicle_Update_Patch.verticalForce;
							SeamothInfo.lastSeamothGearValue = 0f;
						}
					}
				}
			}
		}

		// Token: 0x04000005 RID: 5
		internal static bool HighBeamOn = false;

		// Token: 0x04000006 RID: 6
		internal static bool LowBeamIsSet = false;

		// Token: 0x04000007 RID: 7
		internal static bool HighBeamIsSet = false;

		// Token: 0x04000008 RID: 8
		internal static bool SafetyBeamIsSet = false;

		// Token: 0x04000009 RID: 9
		internal static bool LightsAreOn = false;

		// Token: 0x0400000A RID: 10
		public static float largeFactor = 3.5f;

		// Token: 0x0400000B RID: 11
		public static float smallFactor = 1.5f;

		// Token: 0x0400000C RID: 12
		public static float turboPlus = 2f;

		// Token: 0x0400000D RID: 13
		public static float forwardForce = 13f;

		// Token: 0x0400000E RID: 14
		public static float backwardForce = 5f;

		// Token: 0x0400000F RID: 15
		public static float sidewardForce = 11.5f;

		// Token: 0x04000010 RID: 16
		public static float verticalForce = 11f;

		// Token: 0x04000011 RID: 17
		public static float highBeamEnergyCost = 0.05f;
	}
}
