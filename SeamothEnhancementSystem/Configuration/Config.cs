using System;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.Configuration
{
	// Token: 0x0200003F RID: 63
	public static class Config
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000AD54 File Offset: 0x00008F54
		public static void Load()
		{
			Config.ShowCellCapacityValue = PlayerPrefsExtra.GetBool("ShowCellCapacityToggle", false);
			Config.MarchThroughHealthValue = PlayerPrefs.GetFloat("MarchThroughHealthValueSlider", 3f);
			Config.MarchThroughPowerValue = PlayerPrefs.GetFloat("MarchThroughPowerValueSlider", 3f);
			Config.SeamothGearValue = PlayerPrefs.GetFloat("SeamothGearValueSlider", 1f);
			Config.VehicleFontSizeSliderValue = PlayerPrefs.GetFloat("VehicleFontSizeSlider", 30f);
			Config.ShowKeyPromptToggleValue = PlayerPrefsExtra.GetBool("ShowKeyPromptToggle", true);
			Config.ShowSpeedKmhToggleValue = PlayerPrefsExtra.GetBool("ShowSpeedKmhToggle", true);
			Config.LightsLoHiKeybindValue = PlayerPrefsExtra.GetKeyCode("LightsLoHiKeybindPress", KeyCode.L);
			Config.CruiseKeybindValue = PlayerPrefsExtra.GetKeyCode("CruiseKeybindPress", KeyCode.Y);
			Config.ModeKeybindValue = PlayerPrefsExtra.GetKeyCode("ModeKeybindPress", KeyCode.T);
			Config.GearUpKeybindValue = PlayerPrefsExtra.GetKeyCode("GearUpKeybindPress", KeyCode.F);
			Config.GearDownKeybindValue = PlayerPrefsExtra.GetKeyCode("GearDownKeybindPress", KeyCode.V);
			Config.HealthKeybindValue = PlayerPrefsExtra.GetKeyCode("HealthKeybindPress", KeyCode.H);
			Config.PowerKeybindValue = PlayerPrefsExtra.GetKeyCode("PowerKeybindPress", KeyCode.J);
			Config.SafetyChargerOnKeybindValue = PlayerPrefsExtra.GetKeyCode("SafetyChargerOnKeybindPress", KeyCode.I);
			Config.SafetyEjectOnKeybindValue = PlayerPrefsExtra.GetKeyCode("SafetyEjectOnKeybindPress", KeyCode.P);
			Config.SafetyEjectAbortKeybindValue = PlayerPrefsExtra.GetKeyCode("SafetyEjectAbortKeybindPress", KeyCode.X);
			Config.SafetyCruiseOnKeybindValue = PlayerPrefsExtra.GetKeyCode("SafetyCruiseOnKeybindPress", KeyCode.O);
			Config.PowerLowerLimitSliderValue = PlayerPrefs.GetFloat("PowerLowerLimitSlider", 33f);
			Config.PowerUpperLimitSliderValue = PlayerPrefs.GetFloat("PowerUpperLimitSlider", 66f);
			Config.HealthLowerLimitSliderValue = PlayerPrefs.GetFloat("HealthLowerLimitSlider", 33f);
			Config.HealthUpperLimitSliderValue = PlayerPrefs.GetFloat("HealthUpperLimitSlider", 66f);
			Config.TempMothLowerLimitSliderValue = PlayerPrefs.GetFloat("TempMothLowerLimitSlider", 30f);
			Config.TempMothUpperLimitSliderValue = PlayerPrefs.GetFloat("TempMothUpperLimitSlider", 45f);
		}

		// Token: 0x040000B8 RID: 184
		public static bool ShowCellCapacityValue;

		// Token: 0x040000B9 RID: 185
		public static float MarchThroughHealthValue;

		// Token: 0x040000BA RID: 186
		public static float MarchThroughPowerValue;

		// Token: 0x040000BB RID: 187
		public static float SeamothGearValue;

		// Token: 0x040000BC RID: 188
		public static float VehicleFontSizeSliderValue;

		// Token: 0x040000BD RID: 189
		public static bool ShowKeyPromptToggleValue;

		// Token: 0x040000BE RID: 190
		public static bool ShowSpeedKmhToggleValue;

		// Token: 0x040000BF RID: 191
		public static KeyCode LightsLoHiKeybindValue;

		// Token: 0x040000C0 RID: 192
		public static KeyCode CruiseKeybindValue;

		// Token: 0x040000C1 RID: 193
		public static KeyCode ModeKeybindValue;

		// Token: 0x040000C2 RID: 194
		public static KeyCode GearUpKeybindValue;

		// Token: 0x040000C3 RID: 195
		public static KeyCode GearDownKeybindValue;

		// Token: 0x040000C4 RID: 196
		public static KeyCode HealthKeybindValue;

		// Token: 0x040000C5 RID: 197
		public static KeyCode PowerKeybindValue;

		// Token: 0x040000C6 RID: 198
		public static KeyCode SafetyChargerOnKeybindValue;

		// Token: 0x040000C7 RID: 199
		public static KeyCode SafetyEjectOnKeybindValue;

		// Token: 0x040000C8 RID: 200
		public static KeyCode SafetyEjectAbortKeybindValue;

		// Token: 0x040000C9 RID: 201
		public static KeyCode SafetyCruiseOnKeybindValue;

		// Token: 0x040000CA RID: 202
		public static float HealthLowerLimitSliderValue;

		// Token: 0x040000CB RID: 203
		public static float HealthUpperLimitSliderValue;

		// Token: 0x040000CC RID: 204
		public static float PowerLowerLimitSliderValue;

		// Token: 0x040000CD RID: 205
		public static float PowerUpperLimitSliderValue;

		// Token: 0x040000CE RID: 206
		public static float TempMothLowerLimitSliderValue;

		// Token: 0x040000CF RID: 207
		public static float TempMothUpperLimitSliderValue;
	}
}
