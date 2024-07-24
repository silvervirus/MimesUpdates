using System;
using System.Text;
using MoonpoolDisplayRepair.Configuration;
using MoonpoolDisplayRepair.InfoItems;
using UnityEngine;

namespace MoonpoolDisplayRepair.Helpers
{
	// Token: 0x02000009 RID: 9
	internal class HealthState
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000025A0 File Offset: 0x000007A0
		public static string ProcessHealth(LiveMixin livecomponent, SubRoot baseWithMoonpool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(ModInfo.colorWhite + " | " + ModInfo.colorEnd);
			float healthFraction = livecomponent.GetHealthFraction();
			bool flag = healthFraction * 100f <= Mathf.Floor(Config.SeamothLowerLimitSliderValue);
			string text;
			if (flag)
			{
				text = ModInfo.colorRed;
			}
			else
			{
				bool flag2 = healthFraction * 100f > Mathf.Floor(Config.SeamothLowerLimitSliderValue) && healthFraction * 100f <= Mathf.Floor(Config.SeamothUpperLimitSliderValue);
				if (flag2)
				{
					text = ModInfo.colorYellow;
				}
				else
				{
					text = ModInfo.colorWhite;
				}
			}
			bool flag3 = healthFraction == 1f;
			if (flag3)
			{
				stringBuilder.Append(ModInfo.colorWhite + "HEALTH 100%" + ModInfo.colorEnd);
			}
			else
			{
				bool flag4 = baseWithMoonpool.gameObject.GetComponentInParent<PowerRelay>().IsPowered() && Mathf.Floor(Config.RepairDockedSubSliderValue) >= 1f;
				if (flag4)
				{
					stringBuilder.Append(ModInfo.colorAqua + "REPAIRING" + ModInfo.colorEnd);
				}
				else
				{
					stringBuilder.Append(string.Concat(new string[]
					{
						ModInfo.colorRed,
						"REPAIRS OFF",
						ModInfo.colorEnd,
						ModInfo.colorWhite,
						" | ",
						ModInfo.colorEnd
					}));
				}
				stringBuilder.Append(string.Concat(new string[]
				{
					" HEALTH ",
					text,
					Mathf.Round(healthFraction * 100f).ToString(),
					"%",
					ModInfo.colorEnd
				}));
			}
			return stringBuilder.ToString();
		}
	}
}
