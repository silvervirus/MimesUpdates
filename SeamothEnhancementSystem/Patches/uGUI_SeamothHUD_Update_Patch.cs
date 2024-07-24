using System;
using System.Text;
using HarmonyLib;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x0200000B RID: 11
	[HarmonyPatch(typeof(uGUI_SeamothHUD))]
	[HarmonyPatch("Update")]
	internal class uGUI_SeamothHUD_Update_Patch
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000029F8 File Offset: 0x00000BF8
		[HarmonyPostfix]
		public static void Postfix(uGUI_SeamothHUD __instance)
		{
			Player main = Player.main;
			bool flag = main != null;
			if (flag)
			{
				Vehicle vehicle = main.GetVehicle() as SeaMoth;
				string text = "<color=white>";
				string text2 = "<color=grey>";
				string text3 = "<color=yellow>";
				string text4 = "<color=red>";
				string text5 = "</color>";
				string text6 = "<size=" + Config.VehicleFontSizeSliderValue.ToString() + ">";
				string text7 = "<size=" + ((double)Config.VehicleFontSizeSliderValue / 1.5).ToString() + ">";
				bool seamothLinkModuleIn = SeamothInfo.seamothLinkModuleIn;
				string text8;
				if (seamothLinkModuleIn)
				{
					text8 = text3;
				}
				else
				{
					text8 = text2;
				}
				bool flag2 = vehicle != null;
				if (flag2)
				{
					LiveMixin component = vehicle.GetComponent<LiveMixin>();
					float healthFraction = component.GetHealthFraction();
					StringBuilder stringBuilder = new StringBuilder();
					bool electronicModuleIn = SeamothInfo.electronicModuleIn;
					if (electronicModuleIn)
					{
						bool flag3 = Config.MarchThroughHealthValue == 1f;
						if (flag3)
						{
							float maxHealth = component.data.maxHealth;
							stringBuilder.Append(text6);
							stringBuilder.Append(Mathf.Round(maxHealth).ToString());
							stringBuilder.Append("</size>");
							stringBuilder.Append(text7);
							stringBuilder.Append(text8 + "mh" + text5);
							stringBuilder.Append("</size>");
							__instance.textHealth.text = stringBuilder.ToString();
						}
						else
						{
							bool flag4 = Config.MarchThroughHealthValue == 2f;
							if (flag4)
							{
								float health = component.health;
								bool flag5 = healthFraction * 100f <= Mathf.Floor(Config.HealthLowerLimitSliderValue);
								string text9;
								if (flag5)
								{
									text9 = text4;
								}
								else
								{
									bool flag6 = healthFraction * 100f > Mathf.Floor(Config.HealthLowerLimitSliderValue) && healthFraction * 100f <= Mathf.Floor(Config.HealthUpperLimitSliderValue);
									if (flag6)
									{
										text9 = text3;
									}
									else
									{
										text9 = text;
									}
								}
								stringBuilder.Append(text6);
								stringBuilder.Append(text9 + Mathf.Round(health).ToString() + text5);
								stringBuilder.Append("</size>");
								stringBuilder.Append(text7);
								stringBuilder.Append(text8 + "h" + text5);
								stringBuilder.Append("</size>");
								__instance.textHealth.text = stringBuilder.ToString();
							}
							else
							{
								bool seamothLinkModuleIn2 = SeamothInfo.seamothLinkModuleIn;
								string text9;
								if (seamothLinkModuleIn2)
								{
									bool flag7 = healthFraction * 100f <= Mathf.Floor(Config.HealthLowerLimitSliderValue);
									if (flag7)
									{
										text9 = text4;
									}
									else
									{
										bool flag8 = healthFraction * 100f > Mathf.Floor(Config.HealthLowerLimitSliderValue) && healthFraction * 100f <= Mathf.Floor(Config.HealthUpperLimitSliderValue);
										if (flag8)
										{
											text9 = text3;
										}
										else
										{
											text9 = text;
										}
									}
								}
								else
								{
									text9 = text;
								}
								stringBuilder.Append(text6);
								stringBuilder.Append(text9 + Mathf.Round(healthFraction * 100f).ToString() + text5);
								stringBuilder.Append("</size>");
								stringBuilder.Append(text7);
								stringBuilder.Append(text8 + "%" + text5);
								stringBuilder.Append("</size>");
								__instance.textHealth.text = stringBuilder.ToString();
							}
						}
					}
					else
					{
						stringBuilder.Append(Mathf.Round(healthFraction * 100f).ToString());
						__instance.textHealth.text = stringBuilder.ToString();
					}
				}
				bool flag9 = vehicle != null;
				if (flag9)
				{
					EnergyMixin component2 = vehicle.GetComponent<EnergyMixin>();
					EnergyInterface component3 = component2.GetComponent<EnergyInterface>();
					float num;
					float num2;
					component3.GetValues(out num, out num2);
					StringBuilder stringBuilder2 = new StringBuilder();
					float num3 = 2f;
					float num4 = 0.5f;
					bool electronicModuleIn2 = SeamothInfo.electronicModuleIn;
					if (electronicModuleIn2)
					{
						bool flag10 = Config.MarchThroughPowerValue == 1f;
						if (flag10)
						{
							stringBuilder2.Append(text6);
							bool flag11 = num2 > 999f;
							if (flag11)
							{
								stringBuilder2.Append(num2.ToString("0E+0"));
							}
							else
							{
								stringBuilder2.Append(num2.ToString());
							}
							stringBuilder2.Append("</size>");
							stringBuilder2.Append(text7);
							stringBuilder2.Append(text8 + "mu" + text5);
							stringBuilder2.Append("</size>");
						}
						else
						{
							bool flag12 = Config.MarchThroughPowerValue == 2f;
							if (flag12)
							{
								bool seamothLinkModuleIn3 = SeamothInfo.seamothLinkModuleIn;
								string text9;
								if (seamothLinkModuleIn3)
								{
									bool flag13 = num / num2 * 100f <= Mathf.Floor(Config.PowerLowerLimitSliderValue) || SeamothInfo.BatteryInSlot == 0;
									if (flag13)
									{
										text9 = text4;
									}
									else
									{
										bool flag14 = num / num2 * 100f > Mathf.Floor(Config.PowerLowerLimitSliderValue) && num / num2 * 100f <= Mathf.Floor(Config.PowerUpperLimitSliderValue);
										if (flag14)
										{
											text9 = text3;
										}
										else
										{
											text9 = text;
										}
									}
								}
								else
								{
									text9 = text;
								}
								bool flag15 = num > SeamothInfo.TurboModeCutoff;
								if (flag15)
								{
									stringBuilder2.Append(text6);
									stringBuilder2.Append(text9);
									bool flag16 = num > 999f;
									if (flag16)
									{
										stringBuilder2.Append(Mathf.RoundToInt(num).ToString("0E+0"));
									}
									else
									{
										stringBuilder2.Append(Mathf.RoundToInt(num).ToString());
									}
									stringBuilder2.Append(text5);
									stringBuilder2.Append("</size>");
									stringBuilder2.Append(text7);
									stringBuilder2.Append(text8 + "u" + text5);
									stringBuilder2.Append("</size>");
								}
								else
								{
									SeamothInfo.timer += Time.deltaTime;
									bool flag17 = SeamothInfo.timer >= num4;
									if (flag17)
									{
										stringBuilder2.Append(text6);
										stringBuilder2.Append(text9);
										bool flag18 = num > 999f;
										if (flag18)
										{
											stringBuilder2.Append(Mathf.RoundToInt(num).ToString("0E+0"));
										}
										else
										{
											stringBuilder2.Append(Mathf.RoundToInt(num).ToString());
										}
										stringBuilder2.Append(text5);
										stringBuilder2.Append("</size>");
										stringBuilder2.Append(text7);
										stringBuilder2.Append(text8 + "u" + text5);
										stringBuilder2.Append("</size>");
									}
									bool flag19 = SeamothInfo.timer >= num3;
									if (flag19)
									{
										SeamothInfo.timer = 0f;
									}
								}
							}
							else
							{
								bool seamothLinkModuleIn4 = SeamothInfo.seamothLinkModuleIn;
								string text9;
								if (seamothLinkModuleIn4)
								{
									bool flag20 = num == 0f || num2 == 0f || num / num2 * 100f <= Mathf.Floor(Config.PowerLowerLimitSliderValue);
									if (flag20)
									{
										text9 = text4;
									}
									else
									{
										bool flag21 = num / num2 * 100f > Mathf.Floor(Config.PowerLowerLimitSliderValue) && num / num2 * 100f <= Mathf.Floor(Config.PowerUpperLimitSliderValue);
										if (flag21)
										{
											text9 = text3;
										}
										else
										{
											text9 = text;
										}
									}
								}
								else
								{
									text9 = text;
								}
								bool flag22 = num > 20f;
								if (flag22)
								{
									stringBuilder2.Append(string.Concat(new string[]
									{
										text6,
										text9,
										Mathf.RoundToInt(num / num2 * 100f).ToString(),
										text5,
										"</size>"
									}));
									stringBuilder2.Append(text7);
									stringBuilder2.Append(text8 + "%" + text5);
									stringBuilder2.Append("</size>");
								}
								else
								{
									SeamothInfo.timer += Time.deltaTime;
									bool flag23 = SeamothInfo.timer >= num4;
									if (flag23)
									{
										bool flag24 = num2 == 0f;
										if (flag24)
										{
											stringBuilder2.Append(string.Concat(new string[] { text6, text9, "N/A", text5, "</size>" }));
										}
										else
										{
											stringBuilder2.Append(string.Concat(new string[]
											{
												text6,
												text9,
												Mathf.RoundToInt(num / num2 * 100f).ToString(),
												text5,
												"</size>"
											}));
											stringBuilder2.Append(text7);
											stringBuilder2.Append(text8 + "%" + text5);
											stringBuilder2.Append("</size>");
										}
									}
									bool flag25 = SeamothInfo.timer >= num3;
									if (flag25)
									{
										SeamothInfo.timer = 0f;
									}
								}
							}
						}
						__instance.textPower.text = stringBuilder2.ToString();
					}
					else
					{
						stringBuilder2.Append(Mathf.RoundToInt(num / num2 * 100f).ToString());
						__instance.textPower.text = stringBuilder2.ToString();
					}
				}
				bool flag26 = vehicle != null;
				if (flag26)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					int value = Traverse.Create(__instance).Field("lastTemperature").GetValue<int>();
					bool electronicModuleIn3 = SeamothInfo.electronicModuleIn;
					if (electronicModuleIn3)
					{
						bool seamothLinkModuleIn5 = SeamothInfo.seamothLinkModuleIn;
						string text9;
						if (seamothLinkModuleIn5)
						{
							bool flag27 = (float)value <= Mathf.Floor(Config.TempMothLowerLimitSliderValue);
							if (flag27)
							{
								text9 = text;
							}
							else
							{
								bool flag28 = (float)value > Mathf.Floor(Config.TempMothLowerLimitSliderValue) && (float)value <= Mathf.Floor(Config.TempMothUpperLimitSliderValue);
								if (flag28)
								{
									text9 = text3;
								}
								else
								{
									text9 = text4;
								}
							}
						}
						else
						{
							text9 = text;
						}
						stringBuilder3.Append("<size=" + Config.VehicleFontSizeSliderValue.ToString() + ">");
						stringBuilder3.Append(text9 + value.ToString() + text5);
						stringBuilder3.Append("</size>");
						__instance.textTemperature.text = stringBuilder3.ToString();
					}
					else
					{
						stringBuilder3.Append(value.ToString());
						__instance.textTemperature.text = stringBuilder3.ToString();
					}
				}
			}
		}
	}
}
