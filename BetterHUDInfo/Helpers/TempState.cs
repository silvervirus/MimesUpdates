using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x0200002E RID: 46
	internal class TempState
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000076D4 File Offset: 0x000058D4
		public static string PlayerWaterTemp()
		{
			Player main = Player.main;
			StringBuilder stringBuilder = new StringBuilder();
			WaterTemperatureSimulation main2 = WaterTemperatureSimulation.main;
			bool flag = main2 != null;
			if (flag)
			{
				float temperature = main2.GetTemperature(main.transform.position);
				bool flag2 = temperature <= Mathf.Floor(Config.TempLowerLimitSliderValue);
				string text;
				if (flag2)
				{
					text = ModInfo.colorWhite;
				}
				else
				{
					bool flag3 = temperature > Mathf.Floor(Config.TempLowerLimitSliderValue) && temperature <= Mathf.Floor(Config.TempUpperLimitSliderValue);
					if (flag3)
					{
						text = ModInfo.colorYellow;
					}
					else
					{
						text = ModInfo.colorRed;
					}
				}
				stringBuilder.Append("<size=" + (ModInfo.FontPlus + Config.FontSizeSliderValue).ToString() + ">");
				stringBuilder.Append(text);
				stringBuilder.Append(Mathf.RoundToInt(temperature).ToString());
				stringBuilder.Append(ModInfo.colorEnd);
				stringBuilder.Append("</size>");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000077E0 File Offset: 0x000059E0
		public static string WaterTemp()
		{
			Player main = Player.main;
			WaterTemperatureSimulation main2 = WaterTemperatureSimulation.main;
			StringBuilder stringBuilder = new StringBuilder();
			string text = ModInfo.colorWhite;
			bool flag = main != null;
			if (flag)
			{
				bool flag2 = main2 != null;
				if (flag2)
				{
					bool flag3 = main.IsPiloting() && main.IsInBase();
					float num;
					if (flag3)
					{
						uGUI_CameraDrone main3 = uGUI_CameraDrone.main;
						MapRoomCamera camera = main3.GetCamera();
						num = main2.GetTemperature(camera.transform.position);
					}
					else
					{
						num = main2.GetTemperature(main.transform.position);
					}
					bool softenHUDColourOutsideToggleValue = Config.SoftenHUDColourOutsideToggleValue;
					if (softenHUDColourOutsideToggleValue)
					{
						bool flag4 = main.IsPiloting() || !main.IsInside();
						if (flag4)
						{
							bool flag5 = DayNightCycle.main.IsDay();
							if (flag5)
							{
								bool flag6 = num <= Mathf.Floor(Config.TempLowerLimitSliderValue);
								if (flag6)
								{
									text = ModInfo.colorLightGray;
								}
								else
								{
									bool flag7 = num > Mathf.Floor(Config.TempLowerLimitSliderValue) && num <= Mathf.Floor(Config.TempUpperLimitSliderValue);
									if (flag7)
									{
										text = ModInfo.colorYellow;
									}
									else
									{
										text = ModInfo.colorRed;
									}
								}
								stringBuilder.Append(text);
							}
							else
							{
								bool flag8 = num <= Mathf.Floor(Config.TempLowerLimitSliderValue);
								if (flag8)
								{
									text = ModInfo.colorLightGray;
								}
								else
								{
									bool flag9 = num > Mathf.Floor(Config.TempLowerLimitSliderValue) && num <= Mathf.Floor(Config.TempUpperLimitSliderValue);
									if (flag9)
									{
										text = ModInfo.colorYellow;
									}
									else
									{
										text = ModInfo.colorRed;
									}
								}
								stringBuilder.Append(text);
							}
						}
						else
						{
							stringBuilder.Append(text);
						}
					}
					else
					{
						bool flag10 = num <= Mathf.Floor(Config.TempLowerLimitSliderValue);
						if (flag10)
						{
							text = ModInfo.colorWhite;
						}
						else
						{
							bool flag11 = num > Mathf.Floor(Config.TempLowerLimitSliderValue) && num <= Mathf.Floor(Config.TempUpperLimitSliderValue);
							if (flag11)
							{
								text = ModInfo.colorYellow;
							}
							else
							{
								text = ModInfo.colorRed;
							}
						}
						stringBuilder.Append(text);
					}
					stringBuilder.Append(Mathf.RoundToInt(num).ToString());
					stringBuilder.Append(ModInfo.colorEnd);
					stringBuilder.Append(ModInfo.colorYellow);
					stringBuilder.Append(" °C");
					stringBuilder.Append(ModInfo.colorEnd);
				}
			}
			return stringBuilder.ToString();
		}
	}
}
