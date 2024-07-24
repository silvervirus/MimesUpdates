using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000015 RID: 21
	internal class ManageCameraTemperImg
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00005510 File Offset: 0x00003710
		internal static void ManageCameraTemper(GameObject CameraTemperObj)
		{
			bool flag = ModInfo.ChipInserted && Config.ShowHullPowerTempToggleValue && (ModInfo.PlayerInCyclopsCamera || ModInfo.PlayerInBaseCamera);
			if (flag)
			{
				CameraTemperObj.SetActive(true);
			}
			else
			{
				CameraTemperObj.SetActive(false);
			}
		}
	}
}
