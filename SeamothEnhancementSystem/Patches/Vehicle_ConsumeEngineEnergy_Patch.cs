using System;
using HarmonyLib;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x0200000C RID: 12
	[HarmonyPatch(typeof(Vehicle))]
	[HarmonyPatch("ConsumeEngineEnergy")]
	internal class Vehicle_ConsumeEngineEnergy_Patch
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00003434 File Offset: 0x00001634
		[HarmonyPrefix]
		public static bool Prefix(Vehicle __instance, ref float energyCost, ref bool __result)
		{
			float value = Traverse.Create(__instance).Field("enginePowerRating").GetValue<float>();
			EnergyInterface component = __instance.GetComponent<EnergyInterface>();
			EnergyMixin component2 = __instance.GetComponent<EnergyMixin>();
			float num = energyCost / value;
			bool flag = Player.main.currentMountedVehicle != null && Player.main.currentMountedVehicle == __instance;
			bool flag13;
			if (flag)
			{
				bool modeGreenOn = SeamothInfo.ModeGreenOn;
				if (modeGreenOn)
				{
					bool flag2 = Config.SeamothGearValue == 1f;
					if (flag2)
					{
						num = energyCost * 0.125f / value;
					}
					else
					{
						bool flag3 = Config.SeamothGearValue == 2f;
						if (flag3)
						{
							num = energyCost * 0.25f / value;
						}
						else
						{
							bool flag4 = Config.SeamothGearValue == 3f;
							if (flag4)
							{
								num = energyCost * 0.5f / value;
							}
							else
							{
								bool flag5 = Config.SeamothGearValue == 4f;
								if (flag5)
								{
									num = energyCost / value;
								}
								else
								{
									bool flag6 = Config.SeamothGearValue == 5f;
									if (flag6)
									{
										num = energyCost * 1.5f / value;
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag7 = Config.SeamothGearValue == 1f;
					if (flag7)
					{
						num = energyCost * 0.125f / value;
					}
					else
					{
						bool flag8 = Config.SeamothGearValue == 2f;
						if (flag8)
						{
							num = energyCost * 0.375f / value;
						}
						else
						{
							bool flag9 = Config.SeamothGearValue == 3f;
							if (flag9)
							{
								num = energyCost * 0.75f / value;
							}
							else
							{
								bool flag10 = Config.SeamothGearValue == 4f;
								if (flag10)
								{
									num = energyCost * 1.25f / value;
								}
								else
								{
									bool flag11 = Config.SeamothGearValue == 5f;
									if (flag11)
									{
										num = energyCost * 1.875f / value;
									}
									else
									{
										bool flag12 = Config.SeamothGearValue == 6f;
										if (flag12)
										{
											num = energyCost * 3.75f / value;
										}
									}
								}
							}
						}
					}
				}
				int num3;
				float num2 = component.TotalCanProvide(out num3);
				__result = component2.ConsumeEnergy(Mathf.Min(num, num2));
				flag13 = false;
			}
			else
			{
				flag13 = true;
			}
			return flag13;
		}
	}
}
