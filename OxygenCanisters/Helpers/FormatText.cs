using System;
using System.Text;

using OxygenCanisters.Info;

namespace OxygenCanisters.Helpers
{
	// Token: 0x02000015 RID: 21
	internal class FormatText
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003770 File Offset: 0x00001970
		public static string ConsumeCanisterHint()
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = ModInfo.numberOfCanisters > 1;
			if (flag)
			{
				stringBuilder.Append(" Use 1 of ");
				int numberOfCanisters = ModInfo.numberOfCanisters;
				int num = numberOfCanisters;
				if (num != 2)
				{
					if (num != 3)
					{
						stringBuilder.Append(ModInfo.colorWhite);
					}
					else
					{
						stringBuilder.Append(ModInfo.colorBlue);
					}
				}
				else
				{
					stringBuilder.Append(ModInfo.colorYellow);
				}
				stringBuilder.Append(ModInfo.numberOfCanisters.ToString());
				stringBuilder.Append(ModInfo.colorEnd);
				stringBuilder.Append(" O₂ Canisters ");
			}
			else
			{
				stringBuilder.Append(" Use your ");
				stringBuilder.Append(ModInfo.colorRed);
				stringBuilder.Append("last");
				stringBuilder.Append(ModInfo.colorEnd);
				stringBuilder.Append(" O₂ Canister ");
			}
			
			stringBuilder.Append('\n');
			return stringBuilder.ToString();
		}
	}
}
