using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000014 RID: 20
	internal static class ManageAllGUIElements
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000494C File Offset: 0x00002B4C
		internal static void ManageAllUI()
		{
			bool flag = ManageAllGUIElements.BackMainOutDayUIGameObj != null && ManageAllGUIElements.BackMainOutNightUIGameObj != null && ManageAllGUIElements.BackMainPilotUIGameObj != null && ManageAllGUIElements.BackMainCameraUIGameObj != null;
			if (flag)
			{
				ManageBackMainImg.ManageBackMain(ManageAllGUIElements.BackMainOutDayUIGameObj, ManageAllGUIElements.BackMainOutNightUIGameObj, ManageAllGUIElements.BackMainPilotUIGameObj, ManageAllGUIElements.BackMainCameraUIGameObj);
			}
			bool flag2 = ManageAllGUIElements.BackTimeOutDayUIGameObj != null && ManageAllGUIElements.BackTimeOutNightUIGameObj != null && ManageAllGUIElements.BackTimePilotUIGameObj != null && ManageAllGUIElements.BackTimeCameraUIGameObj != null;
			if (flag2)
			{
				ManageBackTimeOxyImg.ManageBackTimeOxy(ManageAllGUIElements.BackTimeOutDayUIGameObj, ManageAllGUIElements.BackTimeOutNightUIGameObj, ManageAllGUIElements.BackTimePilotUIGameObj, ManageAllGUIElements.BackTimeCameraUIGameObj, ModInfo.HUDTimeOxy_H, ModInfo.HUDTimeOxy_V, ModInfo.HUDTimeOxyPilot_H, ModInfo.HUDTimeOxyPilot_V);
			}
			bool flag3 = ManageAllGUIElements.BackOxyOutDayUIGameObj != null && ManageAllGUIElements.BackOxyOutNightUIGameObj != null && ManageAllGUIElements.BackOxyPilotUIGameObj != null && ManageAllGUIElements.BackOxyCameraUIGameObj != null;
			if (flag3)
			{
				ManageBackTimeOxyImg.ManageBackTimeOxy(ManageAllGUIElements.BackOxyOutDayUIGameObj, ManageAllGUIElements.BackOxyOutNightUIGameObj, ManageAllGUIElements.BackOxyPilotUIGameObj, ManageAllGUIElements.BackOxyCameraUIGameObj, -1f * ModInfo.HUDTimeOxy_H, ModInfo.HUDTimeOxy_V, -1f * ModInfo.HUDTimeOxyPilot_H, ModInfo.HUDTimeOxyPilot_V);
			}
			bool flag4 = ManageAllGUIElements.CameraTemperUIGameObj != null;
			if (flag4)
			{
				ManageCameraTemperImg.ManageCameraTemper(ManageAllGUIElements.CameraTemperUIGameObj);
			}
			bool flag5 = ManageAllGUIElements.ScanDotUIGameObj != null && ManageAllGUIElements.ScanTargetUIGameObj != null;
			if (flag5)
			{
				ManageHullPowerTempImg.ManageScanDot(ManageAllGUIElements.ScanDotUIGameObj, ManageAllGUIElements.ScanTargetUIGameObj);
			}
			bool flag6 = ManageAllGUIElements.LockBeamUIGameObj != null;
			if (flag6)
			{
				ManageHullPowerTempImg.ManageLockBeam(ManageAllGUIElements.LockBeamUIGameObj);
			}
			bool flag7 = ManageAllGUIElements.BackControlUIGameObj != null;
			if (flag7)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.BackControlUIGameObj, ModInfo.ControlBackground_x, ModInfo.ControlBackground_y, true);
			}
			bool flag8 = ManageAllGUIElements.ControlBiomeOnGameObj != null;
			if (flag8)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlBiomeOnGameObj, ModInfo.Controls_x, ModInfo.Controls_y, Config.ShowMainTopToggleValue);
			}
			bool flag9 = ManageAllGUIElements.ControlBiomeOffGameObj != null;
			if (flag9)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlBiomeOffGameObj, ModInfo.Controls_x, ModInfo.Controls_y, !Config.ShowMainTopToggleValue);
			}
			float num = 65f;
			float num2 = 65f;
			bool flag10 = ManageAllGUIElements.ControlTimeOnGameObj != null;
			if (flag10)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlTimeOnGameObj, ModInfo.Controls_x + num, ModInfo.Controls_y, Config.ShowClockOxyToggleValue);
			}
			bool flag11 = ManageAllGUIElements.ControlTimeOffGameObj != null;
			if (flag11)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlTimeOffGameObj, ModInfo.Controls_x + num, ModInfo.Controls_y, !Config.ShowClockOxyToggleValue);
			}
			num += num2;
			bool flag12 = ManageAllGUIElements.ControlHullOnGameObj != null;
			if (flag12)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlHullOnGameObj, ModInfo.Controls_x + num, ModInfo.Controls_y, Config.ShowHullPowerTempToggleValue);
			}
			bool flag13 = ManageAllGUIElements.ControlHullOffGameObj != null;
			if (flag13)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlHullOffGameObj, ModInfo.Controls_x + num, ModInfo.Controls_y, !Config.ShowHullPowerTempToggleValue);
			}
			num += num2;
			bool flag14 = ManageAllGUIElements.ControlScannerOnGameObj != null;
			if (flag14)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlScannerOnGameObj, ModInfo.Controls_x + num, ModInfo.Controls_y, ModInfo.ScannerIsOn);
			}
			bool flag15 = ManageAllGUIElements.ControlScannerOffGameObj != null;
			if (flag15)
			{
				ManageHUD_ControlImg.ManageHUD_Control(ManageAllGUIElements.ControlScannerOffGameObj, ModInfo.Controls_x + num, ModInfo.Controls_y, !ModInfo.ScannerIsOn);
			}
			bool flag16 = ManageAllGUIElements.CyclopsCamHealthUIGameObj != null && ManageAllGUIElements.CyclopsCamPowerUIGameObj != null;
			if (flag16)
			{
				ManageCycCamHealthPowerImg.ManageCycCamHealthPower(ManageAllGUIElements.CyclopsCamHealthUIGameObj, ManageAllGUIElements.CyclopsCamPowerUIGameObj);
			}
			bool flag17 = ManageAllGUIElements.TimeTextObject != null;
			if (flag17)
			{
				ManageTimeTxt.ManageTimeText();
			}
			bool flag18 = ManageAllGUIElements.OxyTextObject != null;
			if (flag18)
			{
				ManageOxyTxt.ManageOxyText();
			}
			bool flag19 = ManageAllGUIElements.ScannerTextObject != null;
			if (flag19)
			{
				ManageScannerTxt.ManageScannerText();
			}
			bool flag20 = ManageAllGUIElements.CameraTemperTextObject != null;
			if (flag20)
			{
				ManageCameraTemperTxt.ManageCameraTemperText();
			}
			bool flag21 = ManageAllGUIElements.HUD_ControlTextObject != null;
			if (flag21)
			{
				ManageHUD_ControlTxt.ManageHUD_ControlText();
			}
			bool flag22 = ManageAllGUIElements.CyclopsCamHealthTextObject != null;
			if (flag22)
			{
				ManageCyclopsCamTxt.ManageCyclopsCamText(ManageAllGUIElements.CyclopsCamHealthTextObject);
			}
			bool flag23 = ManageAllGUIElements.CyclopsCamPowerTextObject != null;
			if (flag23)
			{
				ManageCyclopsCamTxt.ManageCyclopsCamText(ManageAllGUIElements.CyclopsCamPowerTextObject);
			}
			bool flag24 = ManageAllGUIElements.HullDescTextObject != null;
			if (flag24)
			{
				ManageDescTxt.ManageDescText(ManageAllGUIElements.HullDescTextObject);
			}
			bool flag25 = ManageAllGUIElements.PowerDescTextObject != null;
			if (flag25)
			{
				ManageDescTxt.ManageDescText(ManageAllGUIElements.PowerDescTextObject);
			}
			bool flag26 = ManageAllGUIElements.TemperDescTextObject != null;
			if (flag26)
			{
				ManageDescTxt.ManageDescText(ManageAllGUIElements.TemperDescTextObject);
			}
			bool flag27 = ManageAllGUIElements.HUD_ControlDescTextObject != null;
			if (flag27)
			{
				ManageDescTxt.ManageControlsDescText(ManageAllGUIElements.HUD_ControlDescTextObject);
			}
			bool flag28 = ModInfo.changeShowing && ManageAllGUIElements.HUD_ChangeTextObject != null;
			if (flag28)
			{
				ManageFadeChangeTxt.ManageFadeChangeText();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004E0C File Offset: 0x0000300C
		internal static void TurnUIOff()
		{
			bool flag = ManageAllGUIElements.BackMainOutDayUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.BackMainOutDayUIGameObj.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BackMainOutNightUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.BackMainOutNightUIGameObj.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.BackMainPilotUIGameObj != null;
			if (flag3)
			{
				ManageAllGUIElements.BackMainPilotUIGameObj.SetActive(false);
			}
			bool flag4 = ManageAllGUIElements.BackMainCameraUIGameObj != null;
			if (flag4)
			{
				ManageAllGUIElements.BackMainCameraUIGameObj.SetActive(false);
			}
			bool flag5 = ManageAllGUIElements.BackTimeOutDayUIGameObj != null;
			if (flag5)
			{
				ManageAllGUIElements.BackTimeOutDayUIGameObj.SetActive(false);
			}
			bool flag6 = ManageAllGUIElements.BackTimeOutNightUIGameObj != null;
			if (flag6)
			{
				ManageAllGUIElements.BackTimeOutNightUIGameObj.SetActive(false);
			}
			bool flag7 = ManageAllGUIElements.BackTimePilotUIGameObj != null;
			if (flag7)
			{
				ManageAllGUIElements.BackTimePilotUIGameObj.SetActive(false);
			}
			bool flag8 = ManageAllGUIElements.BackTimeCameraUIGameObj != null;
			if (flag8)
			{
				ManageAllGUIElements.BackTimeCameraUIGameObj.SetActive(false);
			}
			bool flag9 = ManageAllGUIElements.BackOxyOutDayUIGameObj != null;
			if (flag9)
			{
				ManageAllGUIElements.BackOxyOutDayUIGameObj.SetActive(false);
			}
			bool flag10 = ManageAllGUIElements.BackOxyOutNightUIGameObj != null;
			if (flag10)
			{
				ManageAllGUIElements.BackOxyOutNightUIGameObj.SetActive(false);
			}
			bool flag11 = ManageAllGUIElements.BackOxyPilotUIGameObj != null;
			if (flag11)
			{
				ManageAllGUIElements.BackOxyPilotUIGameObj.SetActive(false);
			}
			bool flag12 = ManageAllGUIElements.BackOxyCameraUIGameObj != null;
			if (flag12)
			{
				ManageAllGUIElements.BackOxyCameraUIGameObj.SetActive(false);
			}
			bool flag13 = ManageAllGUIElements.CameraTemperUIGameObj != null;
			if (flag13)
			{
				ManageAllGUIElements.CameraTemperUIGameObj.SetActive(false);
			}
			bool flag14 = ManageAllGUIElements.ScanDotUIGameObj != null;
			if (flag14)
			{
				ManageAllGUIElements.ScanDotUIGameObj.SetActive(false);
			}
			bool flag15 = ManageAllGUIElements.ScanTargetUIGameObj != null;
			if (flag15)
			{
				ManageAllGUIElements.ScanTargetUIGameObj.SetActive(false);
			}
			bool flag16 = ManageAllGUIElements.LockBeamUIGameObj != null;
			if (flag16)
			{
				ManageAllGUIElements.LockBeamUIGameObj.SetActive(false);
			}
			bool flag17 = ManageAllGUIElements.BackControlUIGameObj != null;
			if (flag17)
			{
				ManageAllGUIElements.BackControlUIGameObj.SetActive(false);
			}
			bool flag18 = ManageAllGUIElements.ControlBiomeOnGameObj != null;
			if (flag18)
			{
				ManageAllGUIElements.ControlBiomeOnGameObj.SetActive(false);
			}
			bool flag19 = ManageAllGUIElements.ControlBiomeOffGameObj != null;
			if (flag19)
			{
				ManageAllGUIElements.ControlBiomeOffGameObj.SetActive(false);
			}
			bool flag20 = ManageAllGUIElements.ControlTimeOnGameObj != null;
			if (flag20)
			{
				ManageAllGUIElements.ControlTimeOnGameObj.SetActive(false);
			}
			bool flag21 = ManageAllGUIElements.ControlTimeOffGameObj != null;
			if (flag21)
			{
				ManageAllGUIElements.ControlTimeOffGameObj.SetActive(false);
			}
			bool flag22 = ManageAllGUIElements.ControlHullOnGameObj != null;
			if (flag22)
			{
				ManageAllGUIElements.ControlHullOnGameObj.SetActive(false);
			}
			bool flag23 = ManageAllGUIElements.ControlHullOffGameObj != null;
			if (flag23)
			{
				ManageAllGUIElements.ControlHullOffGameObj.SetActive(false);
			}
			bool flag24 = ManageAllGUIElements.ControlScannerOnGameObj != null;
			if (flag24)
			{
				ManageAllGUIElements.ControlScannerOnGameObj.SetActive(false);
			}
			bool flag25 = ManageAllGUIElements.ControlScannerOffGameObj != null;
			if (flag25)
			{
				ManageAllGUIElements.ControlScannerOffGameObj.SetActive(false);
			}
			bool flag26 = ManageAllGUIElements.CyclopsCamHealthUIGameObj != null;
			if (flag26)
			{
				ManageAllGUIElements.CyclopsCamHealthUIGameObj.SetActive(false);
			}
			bool flag27 = ManageAllGUIElements.CyclopsCamPowerUIGameObj != null;
			if (flag27)
			{
				ManageAllGUIElements.CyclopsCamPowerUIGameObj.SetActive(false);
			}
			bool flag28 = ManageAllGUIElements.TimeTextObject != null;
			if (flag28)
			{
				ManageAllGUIElements.TimeTextObject.SetActive(false);
			}
			bool flag29 = ManageAllGUIElements.OxyTextObject != null;
			if (flag29)
			{
				ManageAllGUIElements.OxyTextObject.SetActive(false);
			}
			bool flag30 = ManageAllGUIElements.ScannerTextObject != null;
			if (flag30)
			{
				ManageAllGUIElements.ScannerTextObject.SetActive(false);
			}
			bool flag31 = ManageAllGUIElements.CameraTemperTextObject != null;
			if (flag31)
			{
				ManageAllGUIElements.CameraTemperTextObject.SetActive(false);
			}
			bool flag32 = ManageAllGUIElements.HUD_ControlTextObject != null;
			if (flag32)
			{
				ManageAllGUIElements.HUD_ControlTextObject.SetActive(false);
			}
			bool flag33 = ManageAllGUIElements.CyclopsCamHealthTextObject != null;
			if (flag33)
			{
				ManageAllGUIElements.CyclopsCamHealthTextObject.SetActive(false);
			}
			bool flag34 = ManageAllGUIElements.CyclopsCamPowerTextObject != null;
			if (flag34)
			{
				ManageAllGUIElements.CyclopsCamPowerTextObject.SetActive(false);
			}
			bool flag35 = ManageAllGUIElements.HullDescTextObject != null;
			if (flag35)
			{
				ManageAllGUIElements.HullDescTextObject.SetActive(false);
			}
			bool flag36 = ManageAllGUIElements.PowerDescTextObject != null;
			if (flag36)
			{
				ManageAllGUIElements.PowerDescTextObject.SetActive(false);
			}
			bool flag37 = ManageAllGUIElements.TemperDescTextObject != null;
			if (flag37)
			{
				ManageAllGUIElements.TemperDescTextObject.SetActive(false);
			}
			bool flag38 = ManageAllGUIElements.HUD_ControlDescTextObject != null;
			if (flag38)
			{
				ManageAllGUIElements.HUD_ControlDescTextObject.SetActive(false);
			}
			bool flag39 = ManageAllGUIElements.HUD_ChangeTextObject != null;
			if (flag39)
			{
				ManageAllGUIElements.HUD_ChangeTextObject.SetActive(false);
			}
		}

		// Token: 0x04000075 RID: 117
		public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x04000076 RID: 118
		public static GameObject BackMainOutDayUIGameObj = GameObject.Find("BackMainOutDayUI");

		// Token: 0x04000077 RID: 119
		public static GameObject BackMainOutNightUIGameObj = GameObject.Find("BackMainOutNightUI");

		// Token: 0x04000078 RID: 120
		public static GameObject BackMainPilotUIGameObj = GameObject.Find("BackMainPilotUI");

		// Token: 0x04000079 RID: 121
		public static GameObject BackMainCameraUIGameObj = GameObject.Find("BackMainCameraUI");

		// Token: 0x0400007A RID: 122
		public static GameObject BackTimeOutDayUIGameObj = GameObject.Find("BackTimeOutDayUI");

		// Token: 0x0400007B RID: 123
		public static GameObject BackTimeOutNightUIGameObj = GameObject.Find("BackTimeOutNightUI");

		// Token: 0x0400007C RID: 124
		public static GameObject BackTimePilotUIGameObj = GameObject.Find("BackTimePilotUI");

		// Token: 0x0400007D RID: 125
		public static GameObject BackTimeCameraUIGameObj = GameObject.Find("BackTimeCameraUI");

		// Token: 0x0400007E RID: 126
		public static GameObject BackOxyOutDayUIGameObj = GameObject.Find("BackOxyOutDayUI");

		// Token: 0x0400007F RID: 127
		public static GameObject BackOxyOutNightUIGameObj = GameObject.Find("BackOxyOutNightUI");

		// Token: 0x04000080 RID: 128
		public static GameObject BackOxyPilotUIGameObj = GameObject.Find("BackOxyPilotUI");

		// Token: 0x04000081 RID: 129
		public static GameObject BackOxyCameraUIGameObj = GameObject.Find("BackOxyCameraUI");

		// Token: 0x04000082 RID: 130
		public static GameObject CameraTemperUIGameObj = GameObject.Find("CameraTemperatureUI");

		// Token: 0x04000083 RID: 131
		public static GameObject ScanDotUIGameObj = GameObject.Find("ScanDotUI");

		// Token: 0x04000084 RID: 132
		public static GameObject ScanTargetUIGameObj = GameObject.Find("ScanTargetUI");

		// Token: 0x04000085 RID: 133
		public static GameObject LockBeamUIGameObj = GameObject.Find("LockBeamUI");

		// Token: 0x04000086 RID: 134
		public static GameObject BackControlUIGameObj = GameObject.Find("BackControlUI");

		// Token: 0x04000087 RID: 135
		public static GameObject ControlBiomeOnGameObj = GameObject.Find("ControlMainTopOnUI");

		// Token: 0x04000088 RID: 136
		public static GameObject ControlBiomeOffGameObj = GameObject.Find("ControlMainTopOffUI");

		// Token: 0x04000089 RID: 137
		public static GameObject ControlTimeOnGameObj = GameObject.Find("ControlTimeOnUI");

		// Token: 0x0400008A RID: 138
		public static GameObject ControlTimeOffGameObj = GameObject.Find("ControlTimeOffUI");

		// Token: 0x0400008B RID: 139
		public static GameObject ControlHullOnGameObj = GameObject.Find("ControlHullOnUI");

		// Token: 0x0400008C RID: 140
		public static GameObject ControlHullOffGameObj = GameObject.Find("ControlHullOffUI");

		// Token: 0x0400008D RID: 141
		public static GameObject ControlScannerOnGameObj = GameObject.Find("ControlScannerOnUI");

		// Token: 0x0400008E RID: 142
		public static GameObject ControlScannerOffGameObj = GameObject.Find("ControlScannerOffUI");

		// Token: 0x0400008F RID: 143
		public static GameObject CyclopsCamHealthUIGameObj = GameObject.Find("CyclopsCamHealthUI");

		// Token: 0x04000090 RID: 144
		public static GameObject CyclopsCamPowerUIGameObj = GameObject.Find("CyclopsCamPowerUI");

		// Token: 0x04000091 RID: 145
		public static GameObject TimeTextObject = GameObject.Find("TimeTextUI");

		// Token: 0x04000092 RID: 146
		public static GameObject OxyTextObject = GameObject.Find("OxyTextUI");

		// Token: 0x04000093 RID: 147
		public static GameObject ScannerTextObject = GameObject.Find("ScannerTextUI");

		// Token: 0x04000094 RID: 148
		public static GameObject CameraTemperTextObject = GameObject.Find("CameraTemperTextUI");

		// Token: 0x04000095 RID: 149
		public static GameObject HUD_ControlTextObject = GameObject.Find("HUD_ManagementTextUI");

		// Token: 0x04000096 RID: 150
		public static GameObject CyclopsCamHealthTextObject = GameObject.Find("CyclopsCamHealthTextUI");

		// Token: 0x04000097 RID: 151
		public static GameObject CyclopsCamPowerTextObject = GameObject.Find("CyclopsCamPowerTextUI");

		// Token: 0x04000098 RID: 152
		public static GameObject HullDescTextObject = GameObject.Find("HullDescTextUI");

		// Token: 0x04000099 RID: 153
		public static GameObject PowerDescTextObject = GameObject.Find("PowerDescTextUI");

		// Token: 0x0400009A RID: 154
		public static GameObject TemperDescTextObject = GameObject.Find("TemperDescTextUI");

		// Token: 0x0400009B RID: 155
		public static GameObject HUD_ControlDescTextObject = GameObject.Find("HUD_ControlDescTextUI");

		// Token: 0x0400009C RID: 156
		public static GameObject HUD_ChangeTextObject = GameObject.Find("HUD_ChangeTextUI");

		// Token: 0x0400009D RID: 157
		public static string colorWhite = "<color=white>";

		// Token: 0x0400009E RID: 158
		public static string colorYellow = "<color=yellow>";

		// Token: 0x0400009F RID: 159
		public static string colorRed = "<color=red>";

		// Token: 0x040000A0 RID: 160
		public static string colorEnd = "</color>";
	}
}
