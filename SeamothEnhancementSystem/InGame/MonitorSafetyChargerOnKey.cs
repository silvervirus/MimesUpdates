using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000034 RID: 52
	internal class MonitorSafetyChargerOnKey
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000A66C File Offset: 0x0000886C
		public static void MonitorSafetyChargerOnKeyDown()
		{
			bool flag = KeyCodeUtils.GetKeyDown(Config.SafetyChargerOnKeybindValue) && !SeamothInfo.safeEjectActive;
			if (flag)
			{
				bool safeDepthChargerOn = SeamothInfo.safeDepthChargerOn;
				if (safeDepthChargerOn)
				{
					SeamothInfo.safeDepthChargerOn = false;
				}
				else
				{
					SeamothInfo.safeDepthChargerOn = true;
				}
			}
		}
	}
}
