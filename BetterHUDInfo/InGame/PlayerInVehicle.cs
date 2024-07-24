using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;

namespace BetterHUDInfo.InGame
{
	// Token: 0x0200000F RID: 15
	internal class PlayerInVehicle
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003220 File Offset: 0x00001420
		public static void ProcessInVehicle(uGUI_PowerIndicator __instance)
		{
			Player main = Player.main;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = main != null && Config.ShowMainTopToggleValue;
			if (flag)
			{
				__instance.text.enabled = true;
				stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
				bool flag2 = !Config.ShowBiomeToggleValue && !Config.ShowCoordsToggleValue;
				if (flag2)
				{
					stringBuilder.Append(HUD_HelpersTxt.FormatEnhancedHUD(true));
				}
				else
				{
					bool showBiomeToggleValue = Config.ShowBiomeToggleValue;
					if (showBiomeToggleValue)
					{
						stringBuilder.Append(HUD_HelpersTxt.FormatBiomeDrive(true, "BIOME: ", true));
					}
					bool showCoordsToggleValue = Config.ShowCoordsToggleValue;
					if (showCoordsToggleValue)
					{
						stringBuilder.Append(HUD_HelpersTxt.FormatCoordsDrive(true, "COORDINATES: ", true));
					}
				}
				stringBuilder.Append("</size>");
				__instance.text.text = stringBuilder.ToString();
			}
		}
	}
}
