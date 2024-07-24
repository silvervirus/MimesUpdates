using System;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.InGame
{
	// Token: 0x0200001B RID: 27
	internal class ToggleFlashLight
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public static void ToggleFlashLightLED(Light thisLight)
		{
			bool isActiveAndEnabled = thisLight.isActiveAndEnabled;
			if (isActiveAndEnabled)
			{
				FMODAsset fmodAsset = GetSounds.GetFmodAsset("event:/tools/flashlight/turn_off");
				Utils.PlayFMODAsset(fmodAsset, Player.main.transform.position, 20f);
				thisLight.enabled = false;
				ModInfo.GlobalLightIsOn = false;
			}
			else
			{
				FMODAsset fmodAsset2 = GetSounds.GetFmodAsset("event:/tools/flashlight/turn_on");
				Utils.PlayFMODAsset(fmodAsset2, Player.main.transform.position, 20f);
				thisLight.enabled = true;
				ModInfo.GlobalLightIsOn = true;
			}
		}
	}
}
