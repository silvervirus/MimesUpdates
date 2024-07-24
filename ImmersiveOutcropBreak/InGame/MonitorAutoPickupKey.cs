using System;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Info;
using Nautilus.Utility;

namespace ImmersiveOutcropBreak.InGame
{
	// Token: 0x02000018 RID: 24
	internal class MonitorAutoPickupKey
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000422C File Offset: 0x0000242C
		public static void MonitorAutoPickupKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.OutcropAutoPickupKeybindValue);
			if (keyDown)
			{
				bool autoPickupOn = ModInfo.AutoPickupOn;
				if (autoPickupOn)
				{
					ModInfo.AutoPickupOn = false;
				}
				else
				{
					ModInfo.AutoPickupOn = true;
				}
			}
		}
	}
}
