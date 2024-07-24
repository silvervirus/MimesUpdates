using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000031 RID: 49
	internal class MonitorEjectAbortKey
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x0000A5B4 File Offset: 0x000087B4
		public static void MonitorEjectAbortKeyDown()
		{
			bool safeEjectActive = SeamothInfo.safeEjectActive;
			if (safeEjectActive)
			{
				bool keyDown = KeyCodeUtils.GetKeyDown(Config.SafetyEjectAbortKeybindValue);
				if (keyDown)
				{
					SeamothInfo.safeEjectActive = false;
				}
			}
		}
	}
}
