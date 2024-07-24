using System;
using System.Text;
using HarmonyLib;
using MoonpoolDisplayRepair.Configuration;
using MoonpoolDisplayRepair.Helpers;
using MoonpoolDisplayRepair.InfoItems;

namespace MoonpoolDisplayRepair.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(BaseUpgradeConsoleGeometry))]
	[HarmonyPatch("GetVehicleInfo")]
	internal class BaseUpgradeConsoleGeometry_GetVehicleInfo_Patch
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002090 File Offset: 0x00000290
		[HarmonyPrefix]
		public static bool Prefix(ref Vehicle vehicle, ref string __result, BaseUpgradeConsoleGeometry __instance)
		{
			Player main = Player.main;
			SubRoot componentInParent = __instance.gameObject.GetComponentInParent<SubRoot>();
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = vehicle == null;
			if (flag)
			{
				stringBuilder.Append(ModInfo.colorWhite + Language.main.Get("SubmersibleNotDocked"));
				stringBuilder.Append('\n');
				stringBuilder.Append(ModInfo.colorEnd + "<size=30>");
			}
			else
			{
				stringBuilder.Append(string.Concat(new string[]
				{
					ModInfo.colorWhite,
					vehicle.GetName(),
					" ",
					Language.main.Get("SubmersibleDocked"),
					ModInfo.colorEnd
				}));
				stringBuilder.Append('\n');
				stringBuilder.Append("<size=30>");
				bool flag2 = componentInParent != null;
				if (flag2)
				{
					EnergyMixin component = vehicle.GetComponent<EnergyMixin>();
					bool flag3 = component != null;
					if (flag3)
					{
						stringBuilder.Append(PowerState.ProcessPower(component, vehicle, componentInParent));
					}
					LiveMixin component2 = vehicle.GetComponent<LiveMixin>();
					bool flag4 = component2 != null;
					if (flag4)
					{
						stringBuilder.Append(HealthState.ProcessHealth(component2, componentInParent));
					}
					stringBuilder.Append('\n');
				}
			}
			bool flag5 = main != null && componentInParent != null;
			if (flag5)
			{
				stringBuilder.Append(ModInfo.colorWhite + "BASE: " + ModInfo.colorEnd);
				bool showOxygenToggleValue = Config.ShowOxygenToggleValue;
				if (showOxygenToggleValue)
				{
					stringBuilder.Append(BaseOxygenState.ProcessBaseOxygen());
				}
				bool showHullInfoToggleValue = Config.ShowHullInfoToggleValue;
				if (showHullInfoToggleValue)
				{
					stringBuilder.Append(BaseHullState.ProcessBaseHull(componentInParent));
				}
				bool showWaterTempToggleValue = Config.ShowWaterTempToggleValue;
				if (showWaterTempToggleValue)
				{
					stringBuilder.Append(BaseTempState.ProcessBaseTemp(componentInParent));
				}
				bool flag6 = Config.ClockDisplayChoiceIndex != 2;
				if (flag6)
				{
					stringBuilder.Append(TimeState.ProcessTime());
				}
			}
			stringBuilder.Append("</size>");
			__result += stringBuilder.ToString();
			return false;
		}
	}
}
