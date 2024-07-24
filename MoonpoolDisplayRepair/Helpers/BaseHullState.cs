using System;
using System.Text;
using MoonpoolDisplayRepair.Configuration;
using MoonpoolDisplayRepair.InfoItems;
using UnityEngine;

namespace MoonpoolDisplayRepair.Helpers
{
	// Token: 0x02000008 RID: 8
	internal class BaseHullState
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000024D4 File Offset: 0x000006D4
		public static string ProcessBaseHull(SubRoot baseWithMoonpool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			BaseHullStrength component = baseWithMoonpool.GetComponent<BaseHullStrength>();
			float num = Mathf.Round(component.GetTotalStrength());
			bool showOxygenToggleValue = Config.ShowOxygenToggleValue;
			if (showOxygenToggleValue)
			{
				stringBuilder.Append(ModInfo.colorWhite + " | " + ModInfo.colorEnd);
			}
			bool flag = num <= Mathf.Floor(Config.HullLowerLimitSliderValue);
			string text;
			if (flag)
			{
				text = ModInfo.colorRed;
			}
			else
			{
				bool flag2 = num > Mathf.Floor(Config.HullLowerLimitSliderValue) && num <= Mathf.Floor(Config.HullUpperLimitSliderValue);
				if (flag2)
				{
					text = ModInfo.colorYellow;
				}
				else
				{
					text = ModInfo.colorWhite;
				}
			}
			stringBuilder.Append(text + "HULL " + num.ToString() + ModInfo.colorEnd);
			return stringBuilder.ToString();
		}
	}
}
