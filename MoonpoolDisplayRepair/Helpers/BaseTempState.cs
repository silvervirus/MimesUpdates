using System;
using System.Text;
using MoonpoolDisplayRepair.Configuration;
using MoonpoolDisplayRepair.InfoItems;
using UnityEngine;

namespace MoonpoolDisplayRepair.Helpers
{
	// Token: 0x0200000C RID: 12
	internal class BaseTempState
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002A48 File Offset: 0x00000C48
		public static string ProcessBaseTemp(SubRoot baseWithMoonpool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			WaterTemperatureSimulation main = WaterTemperatureSimulation.main;
			bool flag = main != null;
			if (flag)
			{
				float temperature = main.GetTemperature(baseWithMoonpool.transform.position);
				bool flag2 = Config.ShowOxygenToggleValue || Config.ShowHullInfoToggleValue;
				if (flag2)
				{
					stringBuilder.Append(ModInfo.colorWhite + " | " + ModInfo.colorEnd);
				}
				bool flag3 = temperature <= Mathf.Floor(Config.TempLowerLimitSliderValue);
				string text;
				if (flag3)
				{
					text = ModInfo.colorWhite;
				}
				else
				{
					bool flag4 = temperature > Mathf.Floor(Config.TempLowerLimitSliderValue) && temperature <= Mathf.Floor(Config.TempUpperLimitSliderValue);
					if (flag4)
					{
						text = ModInfo.colorYellow;
					}
					else
					{
						text = ModInfo.colorRed;
					}
				}
				stringBuilder.Append(string.Concat(new string[]
				{
					text,
					"WATER ",
					Mathf.RoundToInt(temperature).ToString(),
					"°C",
					ModInfo.colorEnd
				}));
			}
			return stringBuilder.ToString();
		}
	}
}
