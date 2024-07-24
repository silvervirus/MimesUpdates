using System;
using SeamothEnhancementSystem.Configuration;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000038 RID: 56
	internal class MonitorHealthKey
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000A890 File Offset: 0x00008A90
		public static void MonitorHealthKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.HealthKeybindValue);
			if (keyDown)
			{
				float marchThroughHealthValue = Config.MarchThroughHealthValue;
				float num = marchThroughHealthValue;
				if (num != 1f)
				{
					if (num != 2f)
					{
						Config.MarchThroughHealthValue = 1f;
						PlayerPrefs.SetFloat("MarchThroughHealthValueSlider", 1f);
					}
					else
					{
						Config.MarchThroughHealthValue = 3f;
						PlayerPrefs.SetFloat("MarchThroughHealthValueSlider", 3f);
					}
				}
				else
				{
					Config.MarchThroughHealthValue = 2f;
					PlayerPrefs.SetFloat("MarchThroughHealthValueSlider", 2f);
				}
			}
		}
	}
}
