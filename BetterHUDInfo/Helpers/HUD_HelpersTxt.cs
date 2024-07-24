using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x0200002A RID: 42
	internal class HUD_HelpersTxt
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00006D0C File Offset: 0x00004F0C
		public static string FormatBiomeDrive(bool softenTxt, string thisFiller, bool spaceAtTheTop)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (softenTxt)
			{
				stringBuilder.Append(AdjustColours.SoftenColours());
			}
			bool flag = Config.HUDDisplayChoiceIndex == 1;
			if (flag)
			{
				if (spaceAtTheTop)
				{
					stringBuilder.Append('\n');
				}
				bool flag2 = !Config.ShowCoordsToggleValue;
				if (flag2)
				{
					stringBuilder.Append(thisFiller);
					stringBuilder.Append('\n');
				}
			}
			stringBuilder.Append(BiomeState.GetBiome());
			if (softenTxt)
			{
				stringBuilder.Append(ModInfo.colorEnd);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006D9C File Offset: 0x00004F9C
		public static string FormatCoordsDrive(bool softenTxt, string thisFiller, bool spaceAtTheTop)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (softenTxt)
			{
				stringBuilder.Append(AdjustColours.SoftenColours());
			}
			bool flag = Config.HUDDisplayChoiceIndex == 1;
			if (flag)
			{
				stringBuilder.Append('\n');
				bool flag2 = !Config.ShowBiomeToggleValue;
				if (flag2)
				{
					stringBuilder.Append(thisFiller);
					stringBuilder.Append('\n');
				}
			}
			bool flag3 = Config.HUDDisplayChoiceIndex == 0 && Config.ShowBiomeToggleValue;
			if (flag3)
			{
				stringBuilder.Append(" | ");
			}
			stringBuilder.Append(CoordState.GetCoords());
			if (softenTxt)
			{
				stringBuilder.Append(ModInfo.colorEnd);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006E44 File Offset: 0x00005044
		public static string FormatEnhancedHUD(bool spaceAtTheTop)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = Config.HUDDisplayChoiceIndex == 1;
			if (flag)
			{
				if (spaceAtTheTop)
				{
					stringBuilder.Append('\n');
				}
				stringBuilder.Append("ENHANCED\nHUD");
			}
			else
			{
				stringBuilder.Append("ENHANCED HUD");
			}
			return stringBuilder.ToString();
		}
	}
}
