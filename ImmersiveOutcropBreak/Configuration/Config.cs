using System;
using Nautilus.Utility;
using UnityEngine;

namespace ImmersiveOutcropBreak.Configuration
{
	// Token: 0x0200001F RID: 31
	public static class Config
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00005778 File Offset: 0x00003978
		public static void Load()
		{
			Config.PulseKeybindValue = PlayerPrefsExtra.GetKeyCode("PulseKeybindPress", KeyCode.U);
			Config.OutcropAutoBreakKeybindValue = PlayerPrefsExtra.GetKeyCode("OutcropAutoBreakKeybindPress", KeyCode.B);
			Config.OutcropAutoPickupKeybindValue = PlayerPrefsExtra.GetKeyCode("OutcropAutoPickupKeybindPress", KeyCode.P);
			Config.ShowInventoryKeybindValue = PlayerPrefsExtra.GetKeyCode("ShowInventoryKeybindPress", KeyCode.I);
			Config.PulseToggleValue = PlayerPrefsExtra.GetBool("PulseToggle", true);
			Config.OutcropAutoBreakOnToggleValue = PlayerPrefsExtra.GetBool("OutcropAutoBreakOnToggle", true);
			Config.OutcropAutoPickupToggleValue = PlayerPrefsExtra.GetBool("OutcropAutoPickupToggle", true);
			Config.ShowPulseHintToggleValue = PlayerPrefsExtra.GetBool("ShowPulseHintToggle", true);
			Config.ShowInventoryHintToggleValue = PlayerPrefsExtra.GetBool("ShowInventoryHintToggle", true);
			Config.ShowAutoPickupHintToggleValue = PlayerPrefsExtra.GetBool("ShowAutoPickupHintToggle", true);
			Config.ShowAutoBreakHintToggleValue = PlayerPrefsExtra.GetBool("ShowAutoBreakHintToggle", true);
			Config.FirstPulseDelaySliderValue = PlayerPrefs.GetInt("FirstPulseDelaySlider", 100);
			Config.PulseIncrementDelaySliderValue = PlayerPrefs.GetInt("PulseIncrementDelaySlider", 250);
			Config.PulseGUIToggleValue = PlayerPrefsExtra.GetBool("PulseGUIToggle", true);
			Config.AutoBreakGUIToggleValue = PlayerPrefsExtra.GetBool("AutoBreakGUIToggle", true);
			Config.AutoPickupGUIToggleValue = PlayerPrefsExtra.GetBool("AutoPickupGUIToggle", true);
		}

		// Token: 0x04000038 RID: 56
		public static KeyCode PulseKeybindValue;

		// Token: 0x04000039 RID: 57
		public static KeyCode OutcropAutoBreakKeybindValue;

		// Token: 0x0400003A RID: 58
		public static KeyCode OutcropAutoPickupKeybindValue;

		// Token: 0x0400003B RID: 59
		public static KeyCode ShowInventoryKeybindValue;

		// Token: 0x0400003C RID: 60
		public static bool PulseToggleValue;

		// Token: 0x0400003D RID: 61
		public static bool OutcropAutoBreakOnToggleValue;

		// Token: 0x0400003E RID: 62
		public static bool OutcropAutoPickupToggleValue;

		// Token: 0x0400003F RID: 63
		public static bool ShowPulseHintToggleValue;

		// Token: 0x04000040 RID: 64
		public static bool ShowInventoryHintToggleValue;

		// Token: 0x04000041 RID: 65
		public static bool ShowAutoPickupHintToggleValue;

		// Token: 0x04000042 RID: 66
		public static bool ShowAutoBreakHintToggleValue;

		// Token: 0x04000043 RID: 67
		public static int FirstPulseDelaySliderValue;

		// Token: 0x04000044 RID: 68
		public static int PulseIncrementDelaySliderValue;

		// Token: 0x04000045 RID: 69
		public static bool PulseGUIToggleValue;

		// Token: 0x04000046 RID: 70
		public static bool AutoBreakGUIToggleValue;

		// Token: 0x04000047 RID: 71
		public static bool AutoPickupGUIToggleValue;
	}
}
