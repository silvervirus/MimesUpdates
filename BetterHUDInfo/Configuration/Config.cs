using System;
using Nautilus.Utility;
using UnityEngine;

namespace BetterHUDInfo.Configuration
{
	// Token: 0x02000030 RID: 48
	public static class Config
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public static void Load()
		{
			Config.ControlsKeybindValue = PlayerPrefsExtra.GetKeyCode("ControlsKeybindPress", KeyCode.Z);
			Config.FontSizeSliderValue = PlayerPrefs.GetFloat("FontSizeSlider", 30f);
			Config.ShowMainTopToggleValue = PlayerPrefsExtra.GetBool("ShowMainTopToggle", true);
			Config.ShowBiomeToggleValue = PlayerPrefsExtra.GetBool("ShowBiomeToggle", true);
			Config.ShowCoordsToggleValue = PlayerPrefsExtra.GetBool("ShowCoordsToggle", true);
			Config.HUDDisplayChoiceIndex = PlayerPrefs.GetInt("HUDDisplayChoice", 1);
			Config.MoveCompassSliderValue = PlayerPrefs.GetFloat("HUDMoveCompassSlider", 30f);
			Config.SoftenHUDColourOutsideToggleValue = PlayerPrefsExtra.GetBool("SoftenHUDColourOutsideToggle", true);
			Config.ShowClockOxyToggleValue = PlayerPrefsExtra.GetBool("ShowClockOxyToggle", true);
			Config.ClockDisplayChoiceIndex = PlayerPrefs.GetInt("ClockDisplayChoice", 0);
			Config.ClockGameSystemChoiceIndex = PlayerPrefs.GetInt("ClockGameSystemChoice", 0);
			Config.ShowHullPowerTempToggleValue = PlayerPrefsExtra.GetBool("ShowHullPowerTempToggle", true);
			Config.HullLowerLimitSliderValue = PlayerPrefs.GetFloat("HUDLowerLimitSlider", 5f);
			Config.HullUpperLimitSliderValue = PlayerPrefs.GetFloat("HUDUpperLimitSlider", 10f);
			Config.TempLowerLimitSliderValue = PlayerPrefs.GetFloat("TempLowerLimitSlider", 30f);
			Config.TempUpperLimitSliderValue = PlayerPrefs.GetFloat("TempUpperLimitSlider", 45f);
			Config.ShowLockBeamToggleValue = PlayerPrefsExtra.GetBool("ShowLockBeamToggle", true);
			Config.ShowHUDControlHintsToggleValue = PlayerPrefsExtra.GetBool("ShowHUDControlHintsToggle", true);
		}

		// Token: 0x040000A1 RID: 161
		public static KeyCode ControlsKeybindValue;

		// Token: 0x040000A2 RID: 162
		public static float FontSizeSliderValue;

		// Token: 0x040000A3 RID: 163
		public static bool ShowMainTopToggleValue;

		// Token: 0x040000A4 RID: 164
		public static bool ShowBiomeToggleValue;

		// Token: 0x040000A5 RID: 165
		public static bool ShowCoordsToggleValue;

		// Token: 0x040000A6 RID: 166
		public static int HUDDisplayChoiceIndex;

		// Token: 0x040000A7 RID: 167
		public static float MoveCompassSliderValue;

		// Token: 0x040000A8 RID: 168
		public static bool SoftenHUDColourOutsideToggleValue;

		// Token: 0x040000A9 RID: 169
		public static bool ShowClockOxyToggleValue;

		// Token: 0x040000AA RID: 170
		public static int ClockDisplayChoiceIndex;

		// Token: 0x040000AB RID: 171
		public static int ClockGameSystemChoiceIndex;

		// Token: 0x040000AC RID: 172
		public static bool ShowHullPowerTempToggleValue;

		// Token: 0x040000AD RID: 173
		public static float HullLowerLimitSliderValue;

		// Token: 0x040000AE RID: 174
		public static float HullUpperLimitSliderValue;

		// Token: 0x040000AF RID: 175
		public static float TempLowerLimitSliderValue;

		// Token: 0x040000B0 RID: 176
		public static float TempUpperLimitSliderValue;

		// Token: 0x040000B1 RID: 177
		public static bool ShowLockBeamToggleValue;

		// Token: 0x040000B2 RID: 178
		public static bool ShowHUDControlHintsToggleValue;
	}
}
