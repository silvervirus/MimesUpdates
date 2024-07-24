using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;
using BetterHUDInfo.InfoObjects;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000016 RID: 22
	internal class ManageCameraTemperTxt
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00005560 File Offset: 0x00003760
		internal static void ManageCameraTemperText()
		{
			bool chipInserted = ModInfo.ChipInserted;
			if (chipInserted)
			{
				bool flag = Config.ShowHullPowerTempToggleValue && (ModInfo.PlayerInCyclopsCamera || ModInfo.PlayerInBaseCamera);
				if (flag)
				{
					Text component = ManageAllGUIElements.CameraTemperTextObject.GetComponent<Text>();
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(TempState.WaterTemp());
					component.text = stringBuilder.ToString();
					ManageAllGUIElements.CameraTemperTextObject.SetActive(true);
				}
				else
				{
					ManageAllGUIElements.CameraTemperTextObject.SetActive(false);
				}
			}
			else
			{
				ManageAllGUIElements.CameraTemperTextObject.SetActive(false);
			}
		}
	}
}
