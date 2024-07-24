using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;

namespace BetterHUDInfo.InGame
{
	// Token: 0x0200000E RID: 14
	internal class PlayerInCyclops
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003024 File Offset: 0x00001224
		public static void ProcessInCyclops(uGUI_PowerIndicator __instance)
		{
			Player main = Player.main;
			SubRoot currentSub = main.currentSub;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = main != null && Config.ShowMainTopToggleValue;
			if (flag)
			{
				CyclopsExternalCams componentInChildren = currentSub.GetComponentInChildren<CyclopsExternalCams>();
				bool usingCameras = componentInChildren.GetActive();
				__instance.text.enabled = true;
				stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
				bool flag2 = !main.IsPiloting();
				if (flag2)
				{
					bool flag3 = !Config.ShowBiomeToggleValue && !Config.ShowCoordsToggleValue;
					if (flag3)
					{
						stringBuilder.Append(HUD_HelpersTxt.FormatEnhancedHUD(true));
					}
					else
					{
						bool showBiomeToggleValue = Config.ShowBiomeToggleValue;
						if (showBiomeToggleValue)
						{
							stringBuilder.Append(HUD_HelpersTxt.FormatBiomeDrive(false, "BIOME: ", true));
						}
						bool showCoordsToggleValue = Config.ShowCoordsToggleValue;
						if (showCoordsToggleValue)
						{
							stringBuilder.Append(HUD_HelpersTxt.FormatCoordsDrive(false, "COORDINATES: ", true));
						}
					}
					stringBuilder.Append("</size>");
					__instance.text.text = stringBuilder.ToString();
				}
				else
				{
					bool flag4 = !Config.ShowBiomeToggleValue && !Config.ShowCoordsToggleValue;
					if (flag4)
					{
						bool flag5 = usingCameras;
						if (flag5)
						{
							stringBuilder.Append(HUD_HelpersTxt.FormatEnhancedHUD(false));
						}
						else
						{
							stringBuilder.Append(HUD_HelpersTxt.FormatEnhancedHUD(true));
						}
					}
					else
					{
						bool showBiomeToggleValue2 = Config.ShowBiomeToggleValue;
						if (showBiomeToggleValue2)
						{
							bool flag6 = usingCameras;
							if (flag6)
							{
								stringBuilder.Append(HUD_HelpersTxt.FormatBiomeDrive(true, "BIOME: ", false));
							}
							else
							{
								stringBuilder.Append(HUD_HelpersTxt.FormatBiomeDrive(true, "BIOME: ", true));
							}
						}
						bool showCoordsToggleValue2 = Config.ShowCoordsToggleValue;
						if (showCoordsToggleValue2)
						{
							bool flag7 = usingCameras;
							if (flag7)
							{
								stringBuilder.Append(HUD_HelpersTxt.FormatCoordsDrive(true, "COORDINATES: ", false));
							}
							else
							{
								stringBuilder.Append(HUD_HelpersTxt.FormatCoordsDrive(true, "COORDINATES: ", true));
							}
						}
					}
					stringBuilder.Append("</size>");
					__instance.text.text = stringBuilder.ToString();
				}
			}
		}
	}
}
