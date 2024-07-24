using System;
using System.Text;
using BetterHUDInfo.Configuration;
using UnityEngine;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x0200002F RID: 47
	internal class TimeState
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00007A4C File Offset: 0x00005C4C
		public static string GetTime()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
			string text = "am";
			bool flag = Config.ClockGameSystemChoiceIndex == 0;
			int num;
			int num2;
			if (flag)
			{
				float dayScalar = DayNightCycle.main.GetDayScalar();
				num = Mathf.FloorToInt(dayScalar * 24f);
				num2 = Mathf.FloorToInt(Mathf.Repeat(dayScalar * 24f * 60f, 60f));
			}
			else
			{
				DateTime now = DateTime.Now;
				num = now.Hour;
				num2 = now.Minute;
			}
			bool flag2 = Config.ClockDisplayChoiceIndex == 0;
			if (flag2)
			{
				bool flag3 = num > 11;
				if (flag3)
				{
					bool flag4 = num != 12;
					if (flag4)
					{
						num -= 12;
					}
					text = "pm";
				}
			}
			stringBuilder.Append(num.ToString());
			stringBuilder.Append(":");
			bool flag5 = num2 < 10;
			if (flag5)
			{
				stringBuilder.Append("0");
			}
			stringBuilder.Append(num2.ToString());
			stringBuilder.Append(' ');
			bool flag6 = Config.ClockDisplayChoiceIndex == 0;
			if (flag6)
			{
				stringBuilder.Append(text);
			}
			stringBuilder.Append("</size>");
			return stringBuilder.ToString();
		}
	}
}
