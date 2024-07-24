using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x0200001C RID: 28
	internal class ManageBackTimeOxyImg
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00005B1C File Offset: 0x00003D1C
		internal static void ManageBackTimeOxy(GameObject OutDayObj, GameObject OutNightObj, GameObject PilotObj, GameObject CameraObj, float Out_H, float Out_V, float Pilot_H, float Pilot_V)
		{
			Player main = Player.main;
			bool flag = main != null && Config.ShowClockOxyToggleValue;
			if (flag)
			{
				DayNightCycle main2 = DayNightCycle.main;
				bool flag2 = ModInfo.ChipInserted && !main.GetPDA().isInUse;
				if (flag2)
				{
					bool flag3 = !main.IsPiloting();
					if (flag3)
					{
						bool flag4 = main2.IsDay();
						if (flag4)
						{
							MoveGUI.MoveGUIElement(OutDayObj, Out_H, Out_V - ModInfo.MoveCompassDown);
							OutDayObj.SetActive(true);
							OutNightObj.SetActive(false);
							PilotObj.SetActive(false);
							CameraObj.SetActive(false);
						}
						else
						{
							MoveGUI.MoveGUIElement(OutNightObj, Out_H, Out_V - ModInfo.MoveCompassDown);
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
							MoveGUI.MoveGUIElement(CameraObj, Pilot_H, Pilot_V - ModInfo.MoveCompassDown);
							OutDayObj.SetActive(false);
							OutNightObj.SetActive(false);
							PilotObj.SetActive(false);
							CameraObj.SetActive(true);
						}
						bool flag6 = main.inSeamoth || main.inExosuit;
						if (flag6)
						{
							MoveGUI.MoveGUIElement(PilotObj, Pilot_H, Pilot_V - ModInfo.MoveCompassDown);
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
