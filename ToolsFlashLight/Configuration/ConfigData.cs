using System;
using Nautilus.Utility;
using UnityEngine;

namespace ToolsFlashLight.Configuration
{
	// Token: 0x02000022 RID: 34
	internal class ConfigData
	{
		// Token: 0x06000090 RID: 144 RVA: 0x000046E0 File Offset: 0x000028E0
		public static void Load()
		{
			ConfigData.LightOnOffKeybindValue = PlayerPrefsExtra.GetKeyCode("LightOnOffKeybindPress", KeyCode.L);
			ConfigData.LightIntensUpKeybindValue = PlayerPrefsExtra.GetKeyCode("LightIntensUpKeybindPress", KeyCode.O);
			ConfigData.LightIntensDownKeybindValue = PlayerPrefsExtra.GetKeyCode("LightIntensDownKeybindPress", KeyCode.K);
			ConfigData.ShowLightHintToggleValue = PlayerPrefsExtra.GetBool("ShowLightHintToggle", true);
			ConfigData.ShowLightAdjustToggleValue = PlayerPrefsExtra.GetBool("ShowLightAdjustToggle", true);
		}

		// Token: 0x04000042 RID: 66
		public static KeyCode LightOnOffKeybindValue;

		// Token: 0x04000043 RID: 67
		public static KeyCode LightIntensUpKeybindValue;

		// Token: 0x04000044 RID: 68
		public static KeyCode LightIntensDownKeybindValue;

		// Token: 0x04000045 RID: 69
		public static bool ShowLightHintToggleValue;

		// Token: 0x04000046 RID: 70
		public static bool ShowLightAdjustToggleValue;
	}
}
