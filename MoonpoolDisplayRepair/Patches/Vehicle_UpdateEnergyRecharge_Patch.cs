using System;
using HarmonyLib;
using MoonpoolDisplayRepair.Configuration;
using UnityEngine;

namespace MoonpoolDisplayRepair.Patches
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(Vehicle))]
	[HarmonyPatch("UpdateEnergyRecharge")]
	public class Vehicle_UpdateEnergyRecharge_Patch
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002388 File Offset: 0x00000588
		[HarmonyPrefix]
		public static bool Prefix(Vehicle __instance)
		{
			EnergyInterface component = __instance.GetComponent<EnergyInterface>();
			float value = Traverse.Create(__instance).Field("timeDocked").GetValue<float>();
			bool flag = false;
			float num;
			float num2;
			component.GetValues(out num, out num2);
			bool flag2 = __instance.docked && value + 4f < Time.time && num < num2 && Mathf.Floor(Config.RechargeDockedSubSliderValue) != 0f;
			if (flag2)
			{
				float num3 = Mathf.Min(num2 - num, num2 * (Mathf.Floor(Config.RechargeDockedSubSliderValue) * 0.0001f));
				PowerRelay componentInParent = __instance.gameObject.GetComponentInParent<PowerRelay>();
				bool flag3 = componentInParent != null;
				if (flag3)
				{
					float num4 = 0f;
					componentInParent.ConsumeEnergy(num3, out num4);
					bool flag4 = !GameModeUtils.RequiresPower() || num4 > 0f;
					if (flag4)
					{
						component.AddEnergy(num4);
						flag = true;
					}
				}
			}
			bool flag5 = flag;
			if (flag5)
			{
				__instance.chargingSound.Play();
			}
			else
			{
				__instance.chargingSound.Stop();
			}
			return false;
		}
	}
}
