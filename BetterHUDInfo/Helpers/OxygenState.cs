using System;
using System.Text;
using BetterHUDInfo.InfoObjects;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x0200002C RID: 44
	internal class OxygenState
	{
		// Token: 0x0600006E RID: 110 RVA: 0x000073A0 File Offset: 0x000055A0
		public static string GetOxygen()
		{
			Player main = Player.main;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = main.CanBreathe();
			if (flag)
			{
				stringBuilder.Append("OK");
			}
			else
			{
				stringBuilder.Append(ModInfo.colorRed);
				stringBuilder.Append("No");
				stringBuilder.Append(ModInfo.colorEnd);
			}
			return stringBuilder.ToString();
		}
	}
}
