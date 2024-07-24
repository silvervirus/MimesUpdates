using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000037 RID: 55
	internal class MonitorGearKeys
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0000A7D8 File Offset: 0x000089D8
		public static void MonitorGearKeysDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.GearUpKeybindValue);
			if (keyDown)
			{
				float num = Config.SeamothGearValue + 1f;
				bool modeGreenOn = SeamothInfo.ModeGreenOn;
				if (modeGreenOn)
				{
					bool flag = num > 5f;
					if (flag)
					{
						return;
					}
				}
				bool flag2 = !SeamothInfo.ModeGreenOn;
				if (flag2)
				{
					bool flag3 = num > 6f;
					if (flag3)
					{
						return;
					}
				}
				Config.SeamothGearValue = num;
				PlayerPrefs.SetFloat("SeamothGearValueSlider", num);
			}
			bool keyDown2 = KeyCodeUtils.GetKeyDown(Config.GearDownKeybindValue);
			if (keyDown2)
			{
				float num2 = Config.SeamothGearValue - 1f;
				bool flag4 = num2 < 1f;
				if (!flag4)
				{
					Config.SeamothGearValue = num2;
					PlayerPrefs.SetFloat("SeamothGearValueSlider", num2);
				}
			}
		}
	}
}
