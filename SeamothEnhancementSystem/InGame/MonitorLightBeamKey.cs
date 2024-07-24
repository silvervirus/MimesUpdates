using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.Patches;
using Nautilus.Utility;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000039 RID: 57
	internal class MonitorLightBeamKey
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x0000A91C File Offset: 0x00008B1C
		public static void MonitorLightBeamKeyDown(SeaMoth thisSeaMoth)
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.LightsLoHiKeybindValue);
			if (keyDown)
			{
				ToggleLights componentInChildren = thisSeaMoth.GetComponentInChildren<ToggleLights>();
				bool highBeamOn = Vehicle_Update_Patch.HighBeamOn;
				if (highBeamOn)
				{
					Utils.PlayEnvSound(componentInChildren.lightsOffSound, componentInChildren.lightsOffSound.gameObject.transform.position, 20f);
					Vehicle_Update_Patch.HighBeamOn = false;
				}
				else
				{
					Utils.PlayEnvSound(componentInChildren.lightsOnSound, componentInChildren.lightsOnSound.gameObject.transform.position, 20f);
					Vehicle_Update_Patch.HighBeamOn = true;
				}
			}
		}
	}
}
