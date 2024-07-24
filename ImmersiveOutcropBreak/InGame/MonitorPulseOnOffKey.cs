using System;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Info;
using Nautilus.Utility;

namespace ImmersiveOutcropBreak.InGame
{
	// Token: 0x02000016 RID: 22
	internal class MonitorPulseOnOffKey
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00004118 File Offset: 0x00002318
		public static void MonitorPulseOnOffKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.PulseKeybindValue);
			if (keyDown)
			{
				bool pulseOnNow = ModInfo.PulseOnNow;
				if (pulseOnNow)
				{
					ModInfo.PulseOnNow = false;
				}
				else
				{
					ModInfo.PulseOnNow = true;
				}
			}
		}
	}
}
