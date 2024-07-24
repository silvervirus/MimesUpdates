using System;
using System.Text;
using MoonpoolDisplayRepair.Configuration;
using MoonpoolDisplayRepair.InfoItems;
using UnityEngine;

namespace MoonpoolDisplayRepair.Helpers
{
	// Token: 0x0200000B RID: 11
	internal class PowerState
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000027B0 File Offset: 0x000009B0
		public static string ProcessPower(EnergyMixin thisEnergyMixing, Vehicle vehicle, SubRoot baseWithMoonpool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			EnergyInterface component = thisEnergyMixing.GetComponent<EnergyInterface>();
			float num;
			float num2;
			component.GetValues(out num, out num2);
			bool flag = num / num2 * 100f <= Mathf.Floor(Config.SeamothLowerLimitSliderValue);
			string text;
			if (flag)
			{
				text = ModInfo.colorRed;
			}
			else
			{
				bool flag2 = num / num2 * 100f > Mathf.Floor(Config.SeamothLowerLimitSliderValue) && num / num2 * 100f <= Mathf.Floor(Config.SeamothUpperLimitSliderValue);
				if (flag2)
				{
					text = ModInfo.colorYellow;
				}
				else
				{
					text = ModInfo.colorWhite;
				}
			}
			Exosuit component2 = vehicle.GetComponent<Exosuit>();
			bool flag3 = component2;
			string text2;
			string text3;
			string text4;
			string text5;
			if (flag3)
			{
				text2 = "PRAWN: ";
				text3 = "CELL(S) ";
				text4 = "NO CELL(S)";
				text5 = ModInfo.colorAqua + "CHARGING" + ModInfo.colorEnd + " CELL(S) ";
			}
			else
			{
				text2 = "MOTH: ";
				text3 = "CELL ";
				text4 = "NO CELL";
				text5 = ModInfo.colorAqua + "CHARGING" + ModInfo.colorEnd + " CELL ";
			}
			stringBuilder.Append(ModInfo.colorWhite + text2 + ModInfo.colorEnd);
			bool flag4 = num2 == 0f;
			if (flag4)
			{
				stringBuilder.Append(ModInfo.colorRed + text4 + ModInfo.colorEnd);
			}
			else
			{
				bool flag5 = num / num2 * 100f == 100f;
				if (flag5)
				{
					stringBuilder.Append(string.Concat(new string[]
					{
						ModInfo.colorWhite,
						text3,
						num2.ToString(),
						"u 100%",
						ModInfo.colorEnd
					}));
				}
				else
				{
					bool flag6 = baseWithMoonpool.gameObject.GetComponentInParent<PowerRelay>().IsPowered();
					if (flag6)
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							ModInfo.colorWhite,
							text5,
							num2.ToString(),
							"u ",
							ModInfo.colorEnd
						}));
					}
					else
					{
						stringBuilder.Append(ModInfo.colorRed + "CHARGING OFF" + ModInfo.colorEnd);
						stringBuilder.Append(string.Concat(new string[]
						{
							ModInfo.colorWhite,
							" | ",
							text3,
							num2.ToString(),
							"u ",
							ModInfo.colorEnd
						}));
					}
					stringBuilder.Append(text + Mathf.RoundToInt(num / num2 * 100f).ToString() + "%" + ModInfo.colorEnd);
				}
			}
			return stringBuilder.ToString();
		}
	}
}
