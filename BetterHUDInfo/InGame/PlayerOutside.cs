using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;

namespace BetterHUDInfo.InGame
{
	// Token: 0x02000010 RID: 16
	internal class PlayerOutside
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000330C File Offset: 0x0000150C
		public static void ProcessOutside(uGUI_PowerIndicator __instance)
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
