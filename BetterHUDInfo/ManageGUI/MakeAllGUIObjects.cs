using System;
using BetterHUDInfo.InfoObjects;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000013 RID: 19
	internal class MakeAllGUIObjects
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00003BA0 File Offset: 0x00001DA0
		internal static void MakeAllGUIObj()
		{
			bool flag = ManageAllGUIElements.BackMainOutDayUIGameObj == null;
			if (flag)
			{
				ManageAllGUIElements.BackMainOutDayUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackMainOutDayUI", ModInfo.MainOutBackground_Position);
			}
			bool flag2 = ManageAllGUIElements.BackMainOutDayUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.BackMainOutDayUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackMainOutDayUIGameObj, "backgroundmainout_day_550x95", ModInfo.MainOutBackground_Position, ModInfo.MainOutBackground_Size, false);
			}
			bool flag3 = ManageAllGUIElements.BackMainOutNightUIGameObj == null;
			if (flag3)
			{
				ManageAllGUIElements.BackMainOutNightUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackMainOutNightUI", ModInfo.MainOutBackground_Position);
			}
			bool flag4 = ManageAllGUIElements.BackMainOutNightUIGameObj != null;
			if (flag4)
			{
				ManageAllGUIElements.BackMainOutNightUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackMainOutNightUIGameObj, "backgroundmainout_night_550x95", ModInfo.MainOutBackground_Position, ModInfo.MainOutBackground_Size, false);
			}
			bool flag5 = ManageAllGUIElements.BackMainPilotUIGameObj == null;
			if (flag5)
			{
				ManageAllGUIElements.BackMainPilotUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackMainPilotUI", ModInfo.MainOutBackPilot_Position);
			}
			bool flag6 = ManageAllGUIElements.BackMainPilotUIGameObj != null;
			if (flag6)
			{
				ManageAllGUIElements.BackMainPilotUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackMainPilotUIGameObj, "backgroundmainpilot_650x55", ModInfo.MainOutBackPilot_Position, ModInfo.MainOutBackPilot_Size, false);
			}
			bool flag7 = ManageAllGUIElements.BackMainCameraUIGameObj == null;
			if (flag7)
			{
				ManageAllGUIElements.BackMainCameraUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackMainCameraUI", ModInfo.MainOutBackCamera_Position);
			}
			bool flag8 = ManageAllGUIElements.BackMainCameraUIGameObj != null;
			if (flag8)
			{
				ManageAllGUIElements.BackMainCameraUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackMainCameraUIGameObj, "backgroundmaincamera_550x35", ModInfo.MainOutBackCamera_Position, ModInfo.MainOutBackCamera_Size, false);
			}
			bool flag9 = ManageAllGUIElements.BackTimeOutDayUIGameObj == null;
			if (flag9)
			{
				ManageAllGUIElements.BackTimeOutDayUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackTimeOutDayUI", ModInfo.TimeOutBackground_Position);
			}
			bool flag10 = ManageAllGUIElements.BackTimeOutDayUIGameObj != null;
			if (flag10)
			{
				ManageAllGUIElements.BackTimeOutDayUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackTimeOutDayUIGameObj, "backgroundtimeout_day_156x95", ModInfo.TimeOutBackground_Position, ModInfo.TimeOutBackground_Size, false);
			}
			bool flag11 = ManageAllGUIElements.BackTimeOutNightUIGameObj == null;
			if (flag11)
			{
				ManageAllGUIElements.BackTimeOutNightUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackTimeOutNightUI", ModInfo.TimeOutBackground_Position);
			}
			bool flag12 = ManageAllGUIElements.BackTimeOutNightUIGameObj != null;
			if (flag12)
			{
				ManageAllGUIElements.BackTimeOutNightUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackTimeOutNightUIGameObj, "backgroundtimeout_night_156x95", ModInfo.TimeOutBackground_Position, ModInfo.TimeOutBackground_Size, false);
			}
			bool flag13 = ManageAllGUIElements.BackTimePilotUIGameObj == null;
			if (flag13)
			{
				ManageAllGUIElements.BackTimePilotUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackTimePilotUI", ModInfo.TimePilotBackground_Position);
			}
			bool flag14 = ManageAllGUIElements.BackTimePilotUIGameObj != null;
			if (flag14)
			{
				ManageAllGUIElements.BackTimePilotUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackTimePilotUIGameObj, "backgroundtimepilot_214x55", ModInfo.TimePilotBackground_Position, ModInfo.TimePilotBackground_Size, false);
			}
			bool flag15 = ManageAllGUIElements.BackTimeCameraUIGameObj == null;
			if (flag15)
			{
				ManageAllGUIElements.BackTimeCameraUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackTimeCameraUI", ModInfo.TimePilotBackground_Position);
			}
			bool flag16 = ManageAllGUIElements.BackTimeCameraUIGameObj != null;
			if (flag16)
			{
				ManageAllGUIElements.BackTimeCameraUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackTimeCameraUIGameObj, "backgroundtimecamera_214x55", ModInfo.TimePilotBackground_Position, ModInfo.TimePilotBackground_Size, false);
			}
			bool flag17 = ManageAllGUIElements.BackOxyOutDayUIGameObj == null;
			if (flag17)
			{
				ManageAllGUIElements.BackOxyOutDayUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackOxyOutDayUI", ModInfo.OxyOutBackground_Position);
			}
			bool flag18 = ManageAllGUIElements.BackOxyOutDayUIGameObj != null;
			if (flag18)
			{
				ManageAllGUIElements.BackOxyOutDayUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackOxyOutDayUIGameObj, "backgroundtimeout_day_156x95", ModInfo.OxyOutBackground_Position, ModInfo.OxyOutBackground_Size, false);
			}
			bool flag19 = ManageAllGUIElements.BackOxyOutNightUIGameObj == null;
			if (flag19)
			{
				ManageAllGUIElements.BackOxyOutNightUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackOxyOutNightUI", ModInfo.OxyOutBackground_Position);
			}
			bool flag20 = ManageAllGUIElements.BackOxyOutNightUIGameObj != null;
			if (flag20)
			{
				ManageAllGUIElements.BackOxyOutNightUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackOxyOutNightUIGameObj, "backgroundtimeout_night_156x95", ModInfo.OxyOutBackground_Position, ModInfo.OxyOutBackground_Size, false);
			}
			bool flag21 = ManageAllGUIElements.BackOxyPilotUIGameObj == null;
			if (flag21)
			{
				ManageAllGUIElements.BackOxyPilotUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackOxyPilotUI", ModInfo.OxyPilotBackground_Position);
			}
			bool flag22 = ManageAllGUIElements.BackOxyPilotUIGameObj != null;
			if (flag22)
			{
				ManageAllGUIElements.BackOxyPilotUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackOxyPilotUIGameObj, "backgroundtimepilot_214x55", ModInfo.OxyPilotBackground_Position, ModInfo.OxyPilotBackground_Size, false);
			}
			bool flag23 = ManageAllGUIElements.BackOxyCameraUIGameObj == null;
			if (flag23)
			{
				ManageAllGUIElements.BackOxyCameraUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackOxyCameraUI", ModInfo.OxyPilotBackground_Position);
			}
			bool flag24 = ManageAllGUIElements.BackOxyCameraUIGameObj != null;
			if (flag24)
			{
				ManageAllGUIElements.BackOxyCameraUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackOxyCameraUIGameObj, "backgroundtimecamera_214x55", ModInfo.OxyPilotBackground_Position, ModInfo.OxyPilotBackground_Size, false);
			}
			bool flag25 = ManageAllGUIElements.CameraTemperUIGameObj == null;
			if (flag25)
			{
				ManageAllGUIElements.CameraTemperUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackOxyOutNightUI", ModInfo.CameraTemperatureBackground_Position);
			}
			bool flag26 = ManageAllGUIElements.CameraTemperUIGameObj != null;
			if (flag26)
			{
				ManageAllGUIElements.CameraTemperUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CameraTemperUIGameObj, "camera_temperature", ModInfo.CameraTemperatureBackground_Position, ModInfo.CameraTemperatureBackground_Size, false);
			}
			bool flag27 = ManageAllGUIElements.BackControlUIGameObj == null;
			if (flag27)
			{
				ManageAllGUIElements.BackControlUIGameObj = PrepareGUIObjects.PrepareGUIObject("BackControlUI", ModInfo.HUD_ControlBackground_Position);
			}
			bool flag28 = ManageAllGUIElements.BackControlUIGameObj != null;
			if (flag28)
			{
				ManageAllGUIElements.BackControlUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackControlUIGameObj, "backgroundhudcontrol_300x90", ModInfo.HUD_ControlBackground_Position, ModInfo.HUD_ControlBackground_Size, false);
			}
			bool flag29 = ManageAllGUIElements.ControlBiomeOnGameObj == null;
			if (flag29)
			{
				ManageAllGUIElements.ControlBiomeOnGameObj = PrepareGUIObjects.PrepareGUIObject("ControlBiomeOnUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag30 = ManageAllGUIElements.ControlBiomeOnGameObj != null;
			if (flag30)
			{
				ManageAllGUIElements.ControlBiomeOnGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlBiomeOnGameObj, "controlbiome_colour", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag31 = ManageAllGUIElements.ControlBiomeOffGameObj == null;
			if (flag31)
			{
				ManageAllGUIElements.ControlBiomeOffGameObj = PrepareGUIObjects.PrepareGUIObject("ControlMainTopOffUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag32 = ManageAllGUIElements.ControlBiomeOffGameObj != null;
			if (flag32)
			{
				ManageAllGUIElements.ControlBiomeOffGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlBiomeOffGameObj, "controlbiome_black", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag33 = ManageAllGUIElements.ControlTimeOnGameObj == null;
			if (flag33)
			{
				ManageAllGUIElements.ControlTimeOnGameObj = PrepareGUIObjects.PrepareGUIObject("ControlTimeOnUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag34 = ManageAllGUIElements.ControlTimeOnGameObj != null;
			if (flag34)
			{
				ManageAllGUIElements.ControlTimeOnGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlTimeOnGameObj, "controltime_colour", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag35 = ManageAllGUIElements.ControlTimeOffGameObj == null;
			if (flag35)
			{
				ManageAllGUIElements.ControlTimeOffGameObj = PrepareGUIObjects.PrepareGUIObject("ControlTimeOnUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag36 = ManageAllGUIElements.ControlTimeOffGameObj != null;
			if (flag36)
			{
				ManageAllGUIElements.ControlTimeOffGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlTimeOffGameObj, "controltime_black", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag37 = ManageAllGUIElements.ControlHullOnGameObj == null;
			if (flag37)
			{
				ManageAllGUIElements.ControlHullOnGameObj = PrepareGUIObjects.PrepareGUIObject("ControlHullOnUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag38 = ManageAllGUIElements.ControlHullOnGameObj != null;
			if (flag38)
			{
				ManageAllGUIElements.ControlHullOnGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlHullOnGameObj, "controlhull_colour", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag39 = ManageAllGUIElements.ControlHullOffGameObj == null;
			if (flag39)
			{
				ManageAllGUIElements.ControlHullOffGameObj = PrepareGUIObjects.PrepareGUIObject("ControlHullOnUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag40 = ManageAllGUIElements.ControlHullOffGameObj != null;
			if (flag40)
			{
				ManageAllGUIElements.ControlHullOffGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlHullOffGameObj, "controlhull_black", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag41 = ManageAllGUIElements.ControlScannerOnGameObj == null;
			if (flag41)
			{
				ManageAllGUIElements.ControlScannerOnGameObj = PrepareGUIObjects.PrepareGUIObject("ControlScannerOnUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag42 = ManageAllGUIElements.ControlScannerOnGameObj != null;
			if (flag42)
			{
				ManageAllGUIElements.ControlScannerOnGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlScannerOnGameObj, "controlscanner_colour", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag43 = ManageAllGUIElements.ControlScannerOffGameObj == null;
			if (flag43)
			{
				ManageAllGUIElements.ControlScannerOffGameObj = PrepareGUIObjects.PrepareGUIObject("ControlScannerOffUI", ModInfo.HUD_ControlsOnOff_Position);
			}
			bool flag44 = ManageAllGUIElements.ControlScannerOffGameObj != null;
			if (flag44)
			{
				ManageAllGUIElements.ControlScannerOffGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ControlScannerOffGameObj, "controlscanner_black", ModInfo.HUD_ControlsOnOff_Position, ModInfo.HUD_ControlsOnOff_Size, true);
			}
			bool flag45 = ManageAllGUIElements.ScanDotUIGameObj == null;
			if (flag45)
			{
				ManageAllGUIElements.ScanDotUIGameObj = PrepareGUIObjects.PrepareGUIObject("ScanDotUI", ModInfo.ScanDot_Position);
			}
			bool flag46 = ManageAllGUIElements.ScanDotUIGameObj != null;
			if (flag46)
			{
				ManageAllGUIElements.ScanDotUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ScanDotUIGameObj, "scandot", ModInfo.ScanDot_Position, ModInfo.ScanDot_Size, true);
				ManageAllGUIElements.ScanDotUIGameObj.transform.Rotate(new Vector3(0f, 0f, 45f));
			}
			bool flag47 = ManageAllGUIElements.ScanTargetUIGameObj == null;
			if (flag47)
			{
				ManageAllGUIElements.ScanTargetUIGameObj = PrepareGUIObjects.PrepareGUIObject("ScanTargetUI", ModInfo.ScanDot_Position);
			}
			bool flag48 = ManageAllGUIElements.ScanTargetUIGameObj != null;
			if (flag48)
			{
				ManageAllGUIElements.ScanTargetUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ScanTargetUIGameObj, "target", ModInfo.ScanDot_Position, ModInfo.ScanDot_Size, true);
			}
			bool flag49 = ManageAllGUIElements.LockBeamUIGameObj == null;
			if (flag49)
			{
				ManageAllGUIElements.LockBeamUIGameObj = PrepareGUIObjects.PrepareGUIObject("LockBeamUI", ModInfo.LockBeam_Position);
			}
			bool flag50 = ManageAllGUIElements.LockBeamUIGameObj != null;
			if (flag50)
			{
				ManageAllGUIElements.LockBeamUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LockBeamUIGameObj, "lockbeam", ModInfo.LockBeam_Position, ModInfo.LockBeam_Size, false);
			}
			bool flag51 = ManageAllGUIElements.CyclopsCamHealthUIGameObj == null;
			if (flag51)
			{
				ManageAllGUIElements.CyclopsCamHealthUIGameObj = PrepareGUIObjects.PrepareGUIObject("CyclopsCamHealthUI", ModInfo.CyclopsCamHealth_Position);
			}
			bool flag52 = ManageAllGUIElements.CyclopsCamHealthUIGameObj != null;
			if (flag52)
			{
				ManageAllGUIElements.CyclopsCamHealthUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CyclopsCamHealthUIGameObj, "cyclopshealth_214x80", ModInfo.CyclopsCamHealth_Position, ModInfo.CyclopsCamHealth_Size, false);
			}
			bool flag53 = ManageAllGUIElements.CyclopsCamPowerUIGameObj == null;
			if (flag53)
			{
				ManageAllGUIElements.CyclopsCamPowerUIGameObj = PrepareGUIObjects.PrepareGUIObject("CyclopsCamPowerUI", ModInfo.CyclopsCamPower_Position);
			}
			bool flag54 = ManageAllGUIElements.CyclopsCamPowerUIGameObj != null;
			if (flag54)
			{
				ManageAllGUIElements.CyclopsCamPowerUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CyclopsCamPowerUIGameObj, "cyclopspower_210x80", ModInfo.CyclopsCamPower_Position, ModInfo.CyclopsCamPower_Size, false);
			}
			bool flag55 = ManageAllGUIElements.TimeTextObject == null;
			if (flag55)
			{
				ManageAllGUIElements.TimeTextObject = PrepareGUIObjects.PrepareGUIObject("TimeTextUI", ModInfo.TimeText_Position);
			}
			bool flag56 = ManageAllGUIElements.TimeTextObject != null;
			if (flag56)
			{
				ManageAllGUIElements.TimeTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TimeTextObject, 1f, true, ModInfo.ChipInserted, Color.white, false, ModInfo.TimeText_Position, ModInfo.TimeText_Size);
			}
			bool flag57 = ManageAllGUIElements.OxyTextObject == null;
			if (flag57)
			{
				ManageAllGUIElements.OxyTextObject = PrepareGUIObjects.PrepareGUIObject("OxyTextUI", ModInfo.OxyText_Position);
			}
			bool flag58 = ManageAllGUIElements.OxyTextObject != null;
			if (flag58)
			{
				ManageAllGUIElements.OxyTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.OxyTextObject, 1f, true, ModInfo.ChipInserted, Color.white, false, ModInfo.OxyText_Position, ModInfo.OxyText_Size);
			}
			bool flag59 = ManageAllGUIElements.ScannerTextObject == null;
			if (flag59)
			{
				ManageAllGUIElements.ScannerTextObject = PrepareGUIObjects.PrepareGUIObject("ScannerTextUI", ModInfo.ScannerText_Position);
			}
			bool flag60 = ManageAllGUIElements.ScannerTextObject != null;
			if (flag60)
			{
				ManageAllGUIElements.ScannerTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.ScannerTextObject, 1f, false, ModInfo.ChipInserted, Color.white, true, ModInfo.ScannerText_Position, ModInfo.ScannerText_Size);
			}
			bool flag61 = ManageAllGUIElements.CameraTemperTextObject == null;
			if (flag61)
			{
				ManageAllGUIElements.CameraTemperTextObject = PrepareGUIObjects.PrepareGUIObject("CameraTemperTextUI", ModInfo.CameraTemperText_Position);
			}
			bool flag62 = ManageAllGUIElements.CameraTemperTextObject != null;
			if (flag62)
			{
				ManageAllGUIElements.CameraTemperTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.CameraTemperTextObject, 1f, false, ModInfo.ChipInserted, Color.white, true, ModInfo.CameraTemperText_Position, ModInfo.CameraTemperText_Size);
			}
			bool flag63 = ManageAllGUIElements.HUD_ControlTextObject == null;
			if (flag63)
			{
				ManageAllGUIElements.HUD_ControlTextObject = PrepareGUIObjects.PrepareGUIObject("HUD_ControlTextUI", ModInfo.HUD_ControlText_Position);
			}
			bool flag64 = ManageAllGUIElements.HUD_ControlTextObject != null;
			if (flag64)
			{
				ManageAllGUIElements.HUD_ControlTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.HUD_ControlTextObject, 2f, false, ModInfo.ChipInserted, Color.white, true, ModInfo.HUD_ControlText_Position, ModInfo.HUD_ControlText_Size);
			}
			bool flag65 = ManageAllGUIElements.CyclopsCamHealthTextObject == null;
			if (flag65)
			{
				ManageAllGUIElements.CyclopsCamHealthTextObject = PrepareGUIObjects.PrepareGUIObject("CyclopsCamHealthTextUI", ModInfo.CyclopsCamHealthText_Position);
			}
			bool flag66 = ManageAllGUIElements.CyclopsCamHealthTextObject != null;
			if (flag66)
			{
				ManageAllGUIElements.CyclopsCamHealthTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.CyclopsCamHealthTextObject, 1f, false, ModInfo.ChipInserted, Color.white, true, ModInfo.CyclopsCamHealthText_Position, ModInfo.CyclopsCamHealthText_Size);
			}
			bool flag67 = ManageAllGUIElements.CyclopsCamPowerTextObject == null;
			if (flag67)
			{
				ManageAllGUIElements.CyclopsCamPowerTextObject = PrepareGUIObjects.PrepareGUIObject("CyclopsCamPowerTextUI", ModInfo.CyclopsCamPowerText_Position);
			}
			bool flag68 = ManageAllGUIElements.CyclopsCamPowerTextObject != null;
			if (flag68)
			{
				ManageAllGUIElements.CyclopsCamPowerTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.CyclopsCamPowerTextObject, 1f, false, ModInfo.ChipInserted, Color.white, true, ModInfo.CyclopsCamPowerText_Position, ModInfo.CyclopsCamPowerText_Size);
			}
			bool flag69 = ManageAllGUIElements.HullDescTextObject == null;
			if (flag69)
			{
				ManageAllGUIElements.HullDescTextObject = PrepareGUIObjects.PrepareGUIObject("HullDescTextUI", ModInfo.HullDescText_Position);
			}
			bool flag70 = ManageAllGUIElements.HullDescTextObject != null;
			if (flag70)
			{
				ManageAllGUIElements.HullDescTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.HullDescTextObject, 2f, true, ModInfo.ChipInserted, Color.white, false, ModInfo.HullDescText_Position, ModInfo.HullDescText_Size);
			}
			bool flag71 = ManageAllGUIElements.PowerDescTextObject == null;
			if (flag71)
			{
				ManageAllGUIElements.PowerDescTextObject = PrepareGUIObjects.PrepareGUIObject("PowerDescTextUI", ModInfo.PowerDescText_Position);
			}
			bool flag72 = ManageAllGUIElements.PowerDescTextObject != null;
			if (flag72)
			{
				ManageAllGUIElements.PowerDescTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.PowerDescTextObject, 2f, true, ModInfo.ChipInserted, Color.white, false, ModInfo.PowerDescText_Position, ModInfo.PowerDescText_Size);
			}
			bool flag73 = ManageAllGUIElements.TemperDescTextObject == null;
			if (flag73)
			{
				ManageAllGUIElements.TemperDescTextObject = PrepareGUIObjects.PrepareGUIObject("TemperDescTextUI", ModInfo.TemperDescText_Position);
			}
			bool flag74 = ManageAllGUIElements.TemperDescTextObject != null;
			if (flag74)
			{
				ManageAllGUIElements.TemperDescTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TemperDescTextObject, 2f, true, ModInfo.ChipInserted, Color.white, false, ModInfo.TemperDescText_Position, ModInfo.TemperDescText_Size);
			}
			bool flag75 = ManageAllGUIElements.HUD_ControlDescTextObject == null;
			if (flag75)
			{
				ManageAllGUIElements.HUD_ControlDescTextObject = PrepareGUIObjects.PrepareGUIObject("HUD_ControlDescTextUI", ModInfo.HUD_ControlDescText_Position);
			}
			bool flag76 = ManageAllGUIElements.HUD_ControlDescTextObject != null;
			if (flag76)
			{
				ManageAllGUIElements.HUD_ControlDescTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.HUD_ControlDescTextObject, 2f, true, ModInfo.ChipInserted, Color.white, false, ModInfo.HUD_ControlDescText_Position, ModInfo.HUD_ControlDescText_Size);
			}
			bool flag77 = ManageAllGUIElements.HUD_ChangeTextObject == null;
			if (flag77)
			{
				ManageAllGUIElements.HUD_ChangeTextObject = PrepareGUIObjects.PrepareGUIObject("HUD_ChangeTextUI", ModInfo.HUD_ChangeText_Position);
			}
			bool flag78 = ManageAllGUIElements.HUD_ChangeTextObject != null;
			if (flag78)
			{
				ManageAllGUIElements.HUD_ChangeTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.HUD_ChangeTextObject, 1f, false, ModInfo.ChipInserted, Color.white, true, ModInfo.HUD_ChangeText_Position, ModInfo.HUD_ChangeText_Size);
			}
		}
	}
}
