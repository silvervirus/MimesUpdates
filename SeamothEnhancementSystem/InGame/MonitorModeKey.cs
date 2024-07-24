using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x0200003A RID: 58
	internal class MonitorModeKey
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		public static void MonitorModeKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.ModeKeybindValue);
			if (keyDown)
			{
				bool modeGreenOn = SeamothInfo.ModeGreenOn;
				if (modeGreenOn)
				{
					bool flag = Config.SeamothGearValue == 6f;
					if (flag)
					{
						Config.SeamothGearValue = 5f;
					}
					SeamothInfo.ModeGreenOn = false;
					SeamothInfo.ModeChanged = true;
					PlayerPrefs.SetFloat("SeamothGearValueSlider", Config.SeamothGearValue);
				}
				else
				{
					SeamothInfo.ModeGreenOn = true;
					SeamothInfo.ModeChanged = true;
				}
			}
		}
	}
}
