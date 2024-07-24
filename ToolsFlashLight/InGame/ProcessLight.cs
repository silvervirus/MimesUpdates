using System;
using ToolsFlashLight.Configuration;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.ManageGUI;
using UnityEngine;

namespace ToolsFlashLight.InGame
{
	// Token: 0x0200001A RID: 26
	internal class ProcessLight
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00003D10 File Offset: 0x00001F10
		public static void ProcessLightHandling(Light thisLight, EnergyMixin thisEnergyMixing)
		{
			bool flag = thisEnergyMixing.charge > 0f;
			if (flag)
			{
				MonitorLightToggleKey.MonitorLightToggleKeyDown(thisLight);
				bool isActiveAndEnabled = thisLight.isActiveAndEnabled;
				if (isActiveAndEnabled)
				{
					MonitorLightIntensityKey.MonitorLightIntensityKeyDown(thisLight);
					float num = ModInfo.lightPowerConsumption * ModInfo.lightIntensity * Time.deltaTime;
					thisEnergyMixing.ConsumeEnergy(num);
				}
				bool flag2 = !Player.main.IsPiloting() && !Player.main.GetPDA().isInUse && !IngameMenu.main.focused;
				if (flag2)
				{
					bool showLightHintToggleValue = ConfigData.ShowLightHintToggleValue;
					if (showLightHintToggleValue)
					{
						DisplayPrompts.DisplayLargeHint(FormatText.LightToggleKeyHint(thisLight), thisLight);
					}
					bool showLightAdjustToggleValue = ConfigData.ShowLightAdjustToggleValue;
					if (showLightAdjustToggleValue)
					{
						DisplayPrompts.DisplayLargeHint(FormatText.LightAdjustKeyHint(), thisLight);
					}
				}
			}
			else
			{
				thisLight.enabled = false;
			}
		}
	}
}
