using System;
using Nautilus.Utility;
using UnityEngine;

namespace MoonpoolDisplayRepair.Configuration
{
	// Token: 0x0200000E RID: 14
	public static class Config
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public static void Load()
		{
			Config.SeamothLowerLimitSliderValue = PlayerPrefs.GetFloat("SeamothLowerLimitSlider", 33f);
			Config.SeamothUpperLimitSliderValue = PlayerPrefs.GetFloat("SeamothUpperLimitSlider", 66f);
			Config.RepairDockedSubSliderValue = PlayerPrefs.GetFloat("RepairDockedSubSlider", 10f);
			Config.RechargeDockedSubSliderValue = PlayerPrefs.GetFloat("RechargeDockedSubSlider", 10f);
			Config.ShowOxygenToggleValue = PlayerPrefsExtra.GetBool("SMLHelperShowOxygenToggle", true);
			Config.ShowHullInfoToggleValue = PlayerPrefsExtra.GetBool("SMLHelperShowHullInfoToggle", true);
			Config.HullLowerLimitSliderValue = PlayerPrefs.GetFloat("HullLowerLimitSlider", 5f);
			Config.HullUpperLimitSliderValue = PlayerPrefs.GetFloat("HullUpperLimitSlider", 10f);
			Config.ShowWaterTempToggleValue = PlayerPrefsExtra.GetBool("SMLHelperShowWaterTempToggle", true);
			Config.TempLowerLimitSliderValue = PlayerPrefs.GetFloat("TempLowerLimitSlider", 30f);
			Config.TempUpperLimitSliderValue = PlayerPrefs.GetFloat("TempUpperLimitSlider", 45f);
			Config.ClockDisplayChoiceIndex = PlayerPrefs.GetInt("ClockDisplayChoice", 0);
			Config.ClockGameSystemChoiceIndex = PlayerPrefs.GetInt("ClockGameSystemChoice", 0);
		}

		// Token: 0x04000008 RID: 8
		public static float SeamothLowerLimitSliderValue;

		// Token: 0x04000009 RID: 9
		public static float SeamothUpperLimitSliderValue;

		// Token: 0x0400000A RID: 10
		public static float RepairDockedSubSliderValue;

		// Token: 0x0400000B RID: 11
		public static float RechargeDockedSubSliderValue;

		// Token: 0x0400000C RID: 12
		public static bool ShowOxygenToggleValue;

		// Token: 0x0400000D RID: 13
		public static bool ShowHullInfoToggleValue;

		// Token: 0x0400000E RID: 14
		public static float HullLowerLimitSliderValue;

		// Token: 0x0400000F RID: 15
		public static float HullUpperLimitSliderValue;

		// Token: 0x04000010 RID: 16
		public static bool ShowWaterTempToggleValue;

		// Token: 0x04000011 RID: 17
		public static float TempLowerLimitSliderValue;

		// Token: 0x04000012 RID: 18
		public static float TempUpperLimitSliderValue;

		// Token: 0x04000013 RID: 19
		public static int ClockDisplayChoiceIndex;

		// Token: 0x04000014 RID: 20
		public static int ClockGameSystemChoiceIndex;
	}
}
