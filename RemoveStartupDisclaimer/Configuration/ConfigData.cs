using System;
using Nautilus.Utility;

namespace RemoveStartupDisclaimer.Configuration
{
	// Token: 0x02000004 RID: 4
	public static class ConfigData
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020A6 File Offset: 0x000002A6
		public static void Load()
		{
			ConfigData.RemoveFlashingLightsDisclaimerValue = PlayerPrefsExtra.GetBool("RemoveFlashingLightsDisclaimerToggle", true);
		}

		// Token: 0x04000001 RID: 1
		public static bool RemoveFlashingLightsDisclaimerValue;
	}
}
