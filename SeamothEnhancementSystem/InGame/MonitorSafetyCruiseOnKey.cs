using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000033 RID: 51
	internal class MonitorSafetyCruiseOnKey
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000A628 File Offset: 0x00008828
		public static void MonitorSafetyCruiseOnKeyDown()
		{
			bool flag = KeyCodeUtils.GetKeyDown(Config.SafetyCruiseOnKeybindValue) && !SeamothInfo.safeEjectActive;
			if (flag)
			{
				bool safeCruiseOn = SeamothInfo.safeCruiseOn;
				if (safeCruiseOn)
				{
					SeamothInfo.safeCruiseOn = false;
				}
				else
				{
					SeamothInfo.safeCruiseOn = true;
				}
			}
		}
	}
}
