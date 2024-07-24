using System;
using SeamothEnhancementSystem.Configuration;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x0200003B RID: 59
	internal class MonitorPowerKey
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x0000AA18 File Offset: 0x00008C18
		public static void MonitorPowerKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.PowerKeybindValue);
			if (keyDown)
			{
				float marchThroughPowerValue = Config.MarchThroughPowerValue;
				float num = marchThroughPowerValue;
				if (num != 1f)
				{
					if (num != 2f)
					{
						Config.MarchThroughPowerValue = 1f;
						PlayerPrefs.SetFloat("MarchThroughPowerValueSlider", 1f);
					}
					else
					{
						Config.MarchThroughPowerValue = 3f;
						PlayerPrefs.SetFloat("MarchThroughPowerValueSlider", 3f);
					}
				}
				else
				{
					Config.MarchThroughPowerValue = 2f;
					PlayerPrefs.SetFloat("MarchThroughPowerValueSlider", 2f);
				}
			}
		}
	}
}
