using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000032 RID: 50
	internal class MonitorEjectOnKey
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x0000A5E4 File Offset: 0x000087E4
		public static void MonitorEjectOnKeyDown()
		{
			bool flag = KeyCodeUtils.GetKeyDown(Config.SafetyEjectOnKeybindValue) && !SeamothInfo.safeEjectActive;
			if (flag)
			{
				bool safeEjectOn = SeamothInfo.safeEjectOn;
				if (safeEjectOn)
				{
					SeamothInfo.safeEjectOn = false;
				}
				else
				{
					SeamothInfo.safeEjectOn = true;
				}
			}
		}
	}
}
