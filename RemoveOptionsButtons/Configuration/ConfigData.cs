using System;
using Nautilus.Utility;

namespace RemoveOptionsButtons.Configuration
{
	// Token: 0x02000005 RID: 5
	public static class ConfigData
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020D3 File Offset: 0x000002D3
		public static void Load()
		{
			ConfigData.RemoveRedeemaKeyButtonValue = PlayerPrefsExtra.GetBool("SMLHelperRemoveRedeemaKeyButtonToggle", true);
			ConfigData.RemoveTroubleshootingButtonValue = PlayerPrefsExtra.GetBool("SMLHelperRemoveTroubleshootingButtonToggle", true);
		}

		// Token: 0x04000001 RID: 1
		public static bool RemoveRedeemaKeyButtonValue;

		// Token: 0x04000002 RID: 2
		public static bool RemoveTroubleshootingButtonValue;
	}
}
