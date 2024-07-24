using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x0200001B RID: 27
	internal class ManageBackMainImg
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000059C4 File Offset: 0x00003BC4
		internal static void ManageBackMain(GameObject OutDayObj, GameObject OutNightObj, GameObject PilotObj, GameObject CameraObj)
		{
			Player main = Player.main;
			bool flag = main != null;
			if (flag)
			{
				DayNightCycle main2 = DayNightCycle.main;
				bool flag2 = ModInfo.ChipInserted && !main.GetPDA().isInUse && Config.ShowMainTopToggleValue;
				if (flag2)
				{
					bool flag3 = !main.IsPiloting();
					if (flag3)
					{
						bool flag4 = main2.IsDay();
						if (flag4)
						{
							OutDayObj.SetActive(true);
							OutNightObj.SetActive(false);
							PilotObj.SetActive(false);
							CameraObj.SetActive(false);
						}
						else
						{
							OutDayObj.SetActive(false);
							OutNightObj.SetActive(true);
							PilotObj.SetActive(false);
							CameraObj.SetActive(false);
						}
					}
					else
					{
						bool flag5 = main.IsInBase() || main.IsInSubmarine();
						if (flag5)
						{
							OutDayObj.SetActive(false);
							OutNightObj.SetActive(false);
							PilotObj.SetActive(false);
							CameraObj.SetActive(true);
						}
						bool flag6 = main.inSeamoth || main.inExosuit;
						if (flag6)
						{
							OutDayObj.SetActive(false);
							OutNightObj.SetActive(false);
							PilotObj.SetActive(true);
							CameraObj.SetActive(false);
						}
					}
				}
				else
				{
					OutDayObj.SetActive(false);
					OutNightObj.SetActive(false);
					PilotObj.SetActive(false);
					CameraObj.SetActive(false);
				}
			}
		}
	}
}
