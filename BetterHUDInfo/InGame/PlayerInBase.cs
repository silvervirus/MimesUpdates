using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;

namespace BetterHUDInfo.InGame
{
	// Token: 0x0200000D RID: 13
	internal class PlayerInBase
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002D94 File Offset: 0x00000F94
		public static void ProcessInBase(uGUI_PowerIndicator __instance, int cachedPower, int cachedMaxPower, SubRoot currentSub)
		{
			Player main = Player.main;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = main != null && Config.ShowMainTopToggleValue;
			if (flag)
			{
				stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
				bool flag2 = !main.IsPiloting();
				if (flag2)
				{
					bool flag3 = Config.HUDDisplayChoiceIndex == 1;
					if (flag3)
					{
						stringBuilder.Append('\n');
						bool flag4 = !Config.ShowBiomeToggleValue && !Config.ShowCoordsToggleValue;
						if (flag4)
						{
							stringBuilder.Append("ENHANCED HUD\n");
						}
					}
					stringBuilder.Append(Language.main.GetFormat<int, int>("HUDPowerStatus", cachedPower, cachedMaxPower));
					bool showBiomeToggleValue = Config.ShowBiomeToggleValue;
					if (showBiomeToggleValue)
					{
						bool flag5 = Config.HUDDisplayChoiceIndex == 0;
						if (flag5)
						{
							stringBuilder.Append(" | ");
						}
						else
						{
							stringBuilder.Append('\n');
						}
						stringBuilder.Append(BiomeState.GetBiome());
					}
					bool showCoordsToggleValue = Config.ShowCoordsToggleValue;
					if (showCoordsToggleValue)
					{
						bool flag6 = Config.HUDDisplayChoiceIndex == 0;
						if (flag6)
						{
							stringBuilder.Append(" | ");
						}
						else
						{
							bool flag7 = !Config.ShowBiomeToggleValue;
							if (flag7)
							{
								stringBuilder.Append('\n');
							}
							else
							{
								stringBuilder.Append(" | ");
							}
						}
						stringBuilder.Append(CoordState.GetCoords());
					}
				}
				else
				{
					__instance.text.enabled = true;
					stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
					bool flag8 = !Config.ShowBiomeToggleValue && !Config.ShowCoordsToggleValue;
					if (flag8)
					{
						stringBuilder.Append(HUD_HelpersTxt.FormatEnhancedHUD(true));
					}
					else
					{
						bool showBiomeToggleValue2 = Config.ShowBiomeToggleValue;
						if (showBiomeToggleValue2)
						{
							stringBuilder.Append(HUD_HelpersTxt.FormatBiomeDrive(true, "BIOME: ", true));
						}
						bool showCoordsToggleValue2 = Config.ShowCoordsToggleValue;
						if (showCoordsToggleValue2)
						{
							stringBuilder.Append(HUD_HelpersTxt.FormatCoordsDrive(true, "COORDINATES: ", true));
						}
					}
					stringBuilder.Append("</size>");
					__instance.text.text = stringBuilder.ToString();
				}
				stringBuilder.Append("</size>");
				__instance.text.text = stringBuilder.ToString();
			}
			else
			{
				stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
				stringBuilder.Append(Language.main.GetFormat<int, int>("HUDPowerStatus", cachedPower, cachedMaxPower));
				stringBuilder.Append("</size>");
				__instance.text.text = stringBuilder.ToString();
			}
		}
	}
}
