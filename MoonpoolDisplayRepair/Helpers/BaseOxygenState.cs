using System;
using System.Text;
using MoonpoolDisplayRepair.InfoItems;

namespace MoonpoolDisplayRepair.Helpers
{
	// Token: 0x0200000A RID: 10
	internal class BaseOxygenState
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000274C File Offset: 0x0000094C
		public static string ProcessBaseOxygen()
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = Player.main.CanBreathe();
			if (flag)
			{
				stringBuilder.Append(ModInfo.colorWhite + "O<size=16>2</size> OK " + ModInfo.colorEnd);
			}
			else
			{
				stringBuilder.Append(ModInfo.colorRed + "O<size=16>2</size> No " + ModInfo.colorEnd);
			}
			return stringBuilder.ToString();
		}
	}
}
