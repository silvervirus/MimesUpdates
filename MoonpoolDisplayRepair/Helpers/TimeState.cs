using System;
using System.Text;
using MoonpoolDisplayRepair.Configuration;
using MoonpoolDisplayRepair.InfoItems;
using UnityEngine;

namespace MoonpoolDisplayRepair.Helpers
{
	// Token: 0x0200000D RID: 13
	internal class TimeState
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002B54 File Offset: 0x00000D54
		public static string ProcessTime()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = "am";
			bool flag = Config.ClockGameSystemChoiceIndex == 0;
			int num;
			int num2;
			if (flag)
			{
				float dayScalar = DayNightCycle.main.GetDayScalar();
				num = Mathf.FloorToInt(dayScalar * 24f);
				num2 = Mathf.FloorToInt(Mathf.Repeat(dayScalar * 24f * 60f, 60f));
			}
			else
			{
				DateTime now = DateTime.Now;
				num = now.Hour;
				num2 = now.Minute;
			}
			bool flag2 = Config.ShowOxygenToggleValue || Config.ShowHullInfoToggleValue || Config.ShowWaterTempToggleValue;
			if (flag2)
			{
				stringBuilder.Append(ModInfo.colorWhite + " | " + ModInfo.colorEnd + "TIME ");
			}
			bool flag3 = Config.ClockDisplayChoiceIndex == 0;
			if (flag3)
			{
				bool flag4 = num > 12;
				if (flag4)
				{
					num -= 12;
					text = "pm";
				}
			}
			stringBuilder.Append(ModInfo.colorWhite + num.ToString() + ":");
			bool flag5 = num2 < 10;
			if (flag5)
			{
				stringBuilder.Append("0");
			}
			stringBuilder.Append(num2.ToString() + " ");
			bool flag6 = Config.ClockDisplayChoiceIndex == 0;
			if (flag6)
			{
				stringBuilder.Append(text);
			}
			stringBuilder.Append(ModInfo.colorEnd);
			return stringBuilder.ToString();
		}
	}
}
