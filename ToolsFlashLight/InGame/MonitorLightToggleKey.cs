using System;
using System.Threading.Tasks;
using Nautilus.Utility;
using ToolsFlashLight.Configuration;
using ToolsFlashLight.InfoObjects;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

namespace ToolsFlashLight.InGame
{
	// Token: 0x02000019 RID: 25
	internal class MonitorLightToggleKey
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003C48 File Offset: 0x00001E48
		public static void MonitorLightToggleKeyDown(Light thisLight)
		{
			bool keyDown = KeyCodeUtils.GetKeyDown(ConfigData.LightOnOffKeybindValue);
			if (keyDown)
			{
				ModInfo.lightIsBeingChanged = true;
				MonitorLightToggleKey.ToggleWithDelay(400, thisLight);
				MonitorLightToggleKey.StopAnimation(200);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003C84 File Offset: 0x00001E84
		public static async void ToggleWithDelay(int thisDelay, Light thisLight)
		{
			await Task.Delay(thisDelay);
			ToggleFlashLight.ToggleFlashLightLED(thisLight);
			ModInfo.lightIsBeingChanged = false;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003CC8 File Offset: 0x00001EC8
		public static async void StopAnimation(int thisDelay)
		{
			await Task.Delay(thisDelay);
			ModInfo.lightIsBeingChanged = false;
		}
	}
}
