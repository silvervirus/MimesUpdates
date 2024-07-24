using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x02000027 RID: 39
	internal class AdjustColours
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00006A84 File Offset: 0x00004C84
		public static string SoftenColours()
		{
			Player main = Player.main;
			DayNightCycle main2 = DayNightCycle.main;
			bool flag = false;
			bool flag2 = main != null && main2 != null;
			if (flag2)
			{
				flag = main2.IsDay();
			}
			StringBuilder stringBuilder = new StringBuilder();
			string text = ModInfo.colorWhite;
			bool softenHUDColourOutsideToggleValue = Config.SoftenHUDColourOutsideToggleValue;
			if (softenHUDColourOutsideToggleValue)
			{
				bool flag3 = flag;
				if (flag3)
				{
					text = ModInfo.colorLightGray;
					stringBuilder.Append(text);
				}
				else
				{
					text = ModInfo.colorDarkGray;
					stringBuilder.Append(text);
				}
			}
			else
			{
				stringBuilder.Append(text);
			}
			return stringBuilder.ToString();
		}
	}
}
