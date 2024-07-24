using System;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Info;
using Nautilus.Utility;

namespace ImmersiveOutcropBreak.InGame
{
	// Token: 0x02000019 RID: 25
	internal class MonitorAutoBreakKey
	{
		// Token: 0x0600007C RID: 124 RVA: 0x0000426C File Offset: 0x0000246C
		public static void MonitorAutoBreakKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.OutcropAutoBreakKeybindValue);
			if (keyDown)
			{
				bool autoBreakNow = ModInfo.AutoBreakNow;
				if (autoBreakNow)
				{
					ModInfo.AutoBreakNow = false;
				}
				else
				{
					ModInfo.AutoBreakNow = true;
				}
			}
		}
	}
}
