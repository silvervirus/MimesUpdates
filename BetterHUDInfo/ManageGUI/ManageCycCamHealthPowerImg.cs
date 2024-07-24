using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000017 RID: 23
	internal class ManageCycCamHealthPowerImg
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000055F4 File Offset: 0x000037F4
		internal static void ManageCycCamHealthPower(GameObject CycCamHealthObj, GameObject CycCamPowerObj)
		{
			bool flag = ModInfo.ChipInserted && Config.ShowHullPowerTempToggleValue && ModInfo.PlayerInCyclopsCamera;
			if (flag)
			{
				CycCamHealthObj.SetActive(true);
				CycCamPowerObj.SetActive(true);
			}
			else
			{
				CycCamHealthObj.SetActive(false);
				CycCamPowerObj.SetActive(false);
			}
		}
	}
}
