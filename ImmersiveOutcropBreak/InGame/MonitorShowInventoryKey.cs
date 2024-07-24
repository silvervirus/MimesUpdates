using System;
using System.Threading.Tasks;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Info;
using Nautilus.Utility;

namespace ImmersiveOutcropBreak.InGame
{
	// Token: 0x02000017 RID: 23
	internal class MonitorShowInventoryKey
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00004158 File Offset: 0x00002358
		public static void MonitorShowInventoryKeyDown()
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(Config.ShowInventoryKeybindValue);
			if (keyDown)
			{
				HandReticle main = HandReticle.main;
				bool showInventoryNow = ModInfo.ShowInventoryNow;
				if (showInventoryNow)
				{
					main.compTextUseSubscript.CrossFadeAlpha(0f, 1f, true);
					MonitorShowInventoryKey.FadeOutDelay(1000);
				}
				else
				{
					ModInfo.ShowInventoryNow = true;
					main.compTextUseSubscript.CrossFadeAlpha(0f, 0f, true);
					main.compTextUseSubscript.CrossFadeAlpha(1f, 1f, true);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000041E4 File Offset: 0x000023E4
		public static async void FadeOutDelay(int thisDelay)
		{
			await System.Threading.Tasks.Task.Delay(thisDelay);
			ModInfo.ShowInventoryNow = false;
		}
	}
}
