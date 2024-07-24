using System;
using Nautilus.Utility;
using ToolsFlashLight.Configuration;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.InGame
{
	// Token: 0x02000018 RID: 24
	internal class MonitorLightIntensityKey
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00003B58 File Offset: 0x00001D58
		public static void MonitorLightIntensityKeyDown(Light thisLight)
		{
			bool keyHeld = KeyCodeUtils.GetKeyHeld(ConfigData.LightIntensUpKeybindValue);
			if (keyHeld)
			{
				UpdateLightIntensity.UpdateLightIntensityLED(thisLight, true);
				bool flag = thisLight.range < ModInfo.lightRangeTop;
				if (flag)
				{
					ModInfo.lightIsBeingChanged = true;
				}
				else
				{
					ModInfo.lightIsBeingChanged = false;
				}
			}
			bool keyHeld2 = KeyCodeUtils.GetKeyHeld(ConfigData.LightIntensDownKeybindValue);
			if (keyHeld2)
			{
				UpdateLightIntensity.UpdateLightIntensityLED(thisLight, false);
				bool flag2 = thisLight.range > ModInfo.lightRange;
				if (flag2)
				{
					ModInfo.lightIsBeingChanged = true;
				}
				else
				{
					ModInfo.lightIsBeingChanged = false;
				}
			}
			bool flag3 = (KeyCodeUtils.GetKeyDown(ConfigData.LightIntensUpKeybindValue) || KeyCodeUtils.GetKeyDown(ConfigData.LightIntensDownKeybindValue)) && thisLight.range > 60f && thisLight.range < ModInfo.lightRangeTop;
			if (flag3)
			{
				ModInfo.lightIsBeingChanged = true;
			}
			bool flag4 = KeyCodeUtils.GetKeyUp(ConfigData.LightIntensUpKeybindValue) || KeyCodeUtils.GetKeyUp(ConfigData.LightIntensDownKeybindValue);
			if (flag4)
			{
				ModInfo.lightIsBeingChanged = false;
			}
		}
	}
}
