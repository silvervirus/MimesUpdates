using System;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace SeamothEnhancementSystem.ManageGUI
{
	

    internal static class ManageAllGUIElements
	{
        
        // Token: 0x06000088 RID: 136 RVA: 0x00005348 File Offset: 0x00003548
        internal static void ManageAllGuiElements()
		{
			ManageBackgroundImg.ManageBackground();
			ManageLightIcons.ManageLights();
			ManageBatteryMain.ManageBattery();
			ManageModeIcons.ManageMode();
			ManageCruiseIcons.ManageCruiseControl();
			ManageCruiseTxt.ManageCruiseText();
			ManageGearsIcons.ManageGears();
			ManageGearTxt.ManageGearText();
			ManageSpeedTxt.ManageSpeedText();
			ManageKmhTxt.ManageKmhText();
			ManageHealthTxt.ManageHealthText();
			ManagePowerTxt.ManagePowerText();
			ManageTemperTxt.ManageTemperText();
			bool flag = Subtitles.main.IsVisible();
			if (flag)
			{
				ManageBackgroundImg.ManageSafetyBackground();
				ManageMainSafetyIcons.ManageMainSafety();
				ManageMainSafetyDescTxt.ManageMainSafetyDescText();
				ManageChargerIcons.ManageCharger();
				ManageCcIcons.ManageCc();
				ManageEjectIcons.ManageEject();
			}
			else
			{
				ManageAllGUIElements.TurnSafetyUIOff();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000053E8 File Offset: 0x000035E8
		internal static void TurnSafetyUIOff()
		{
			bool flag = ManageAllGUIElements.BackgroundSafetyUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.BackgroundSafetyUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.MainSafetyUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.MainSafetyUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.MainSafetyGrayUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.MainSafetyGrayUIGameObject.SetActive(false);
			}
			bool flag4 = ManageAllGUIElements.MainSafetyDescTextObject != null;
			if (flag4)
			{
				ManageAllGUIElements.MainSafetyDescTextObject.SetActive(false);
			}
			bool flag5 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
			if (flag5)
			{
				ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(false);
			}
			bool flag6 = ManageAllGUIElements.ChargerOnUIGameObject != null;
			if (flag6)
			{
				ManageAllGUIElements.ChargerOnUIGameObject.SetActive(false);
			}
			bool flag7 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
			if (flag7)
			{
				ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(false);
			}
			bool flag8 = ManageAllGUIElements.ChargerOffUIGameObject != null;
			if (flag8)
			{
				ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
			}
			bool flag9 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
			if (flag9)
			{
				ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
			}
			bool flag10 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
			if (flag10)
			{
				ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
			}
			bool flag11 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
			if (flag11)
			{
				ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
			}
			bool flag12 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
			if (flag12)
			{
				ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
			}
			bool flag13 = ManageAllGUIElements.CcGrayUIGameObject != null;
			if (flag13)
			{
				ManageAllGUIElements.CcGrayUIGameObject.SetActive(false);
			}
			bool flag14 = ManageAllGUIElements.CcOnUIGameObject != null;
			if (flag14)
			{
				ManageAllGUIElements.CcOnUIGameObject.SetActive(false);
			}
			bool flag15 = ManageAllGUIElements.CcActiveUIGameObject != null;
			if (flag15)
			{
				ManageAllGUIElements.CcActiveUIGameObject.SetActive(false);
			}
			bool flag16 = ManageAllGUIElements.CcOffUIGameObject != null;
			if (flag16)
			{
				ManageAllGUIElements.CcOffUIGameObject.SetActive(false);
			}
			bool flag17 = ManageAllGUIElements.CcArrow01UIGameObject != null;
			if (flag17)
			{
				ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
			}
			bool flag18 = ManageAllGUIElements.EjectGrayUIGameObject != null;
			if (flag18)
			{
				ManageAllGUIElements.EjectGrayUIGameObject.SetActive(false);
			}
			bool flag19 = ManageAllGUIElements.EjectOnUIGameObject != null;
			if (flag19)
			{
				ManageAllGUIElements.EjectOnUIGameObject.SetActive(false);
			}
			bool flag20 = ManageAllGUIElements.EjectActiveUIGameObject != null;
			if (flag20)
			{
				ManageAllGUIElements.EjectActiveUIGameObject.SetActive(false);
			}
			bool flag21 = ManageAllGUIElements.EjectOffUIGameObject != null;
			if (flag21)
			{
				ManageAllGUIElements.EjectOffUIGameObject.SetActive(false);
			}
			bool flag22 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
			if (flag22)
			{
				ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
			}
			bool flag23 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
			if (flag23)
			{
				ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
			}
			bool flag24 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
			if (flag24)
			{
				ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000056A8 File Offset: 0x000038A8
		internal static void TurnUIOff()
		{
			bool flag = ManageAllGUIElements.BackgroundUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.BackgroundUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BackgroundSafetyUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.BackgroundSafetyUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.LightGrayUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
			}
			bool flag4 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
			if (flag4)
			{
				ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(false);
			}
			bool flag5 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
			if (flag5)
			{
				ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(false);
			}
			bool flag6 = ManageAllGUIElements.LightLowOffUIGameObject != null;
			if (flag6)
			{
				ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
			}
			bool flag7 = ManageAllGUIElements.LightLowOnUIGameObject != null;
			if (flag7)
			{
				ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
			}
			bool flag8 = ManageAllGUIElements.LightHighOffUIGameObject != null;
			if (flag8)
			{
				ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
			}
			bool flag9 = ManageAllGUIElements.LightHighOnUIGameObject != null;
			if (flag9)
			{
				ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
			}
			bool flag10 = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
			if (flag10)
			{
				ManageAllGUIElements.BatterySlotGrayUIGameObject.SetActive(false);
			}
			bool flag11 = ManageAllGUIElements.BatterySlotUIGameObject != null;
			if (flag11)
			{
				ManageAllGUIElements.BatterySlotUIGameObject.SetActive(false);
			}
			bool flag12 = ManageAllGUIElements.BatteryUnitUIGameObject != null;
			if (flag12)
			{
				ManageAllGUIElements.BatteryUnitUIGameObject.SetActive(false);
			}
			bool flag13 = ManageAllGUIElements.BatteryArrowsUIGameObject != null;
			if (flag13)
			{
				ManageAllGUIElements.BatteryArrowsUIGameObject.SetActive(false);
			}
			bool flag14 = ManageAllGUIElements.BatteryInUIGameObject != null;
			if (flag14)
			{
				ManageAllGUIElements.BatteryInUIGameObject.SetActive(false);
			}
			bool flag15 = ManageAllGUIElements.BatteryOutUIGameObject != null;
			if (flag15)
			{
				ManageAllGUIElements.BatteryOutUIGameObject.SetActive(false);
			}
			bool flag16 = ManageAllGUIElements.ModeGrayUIGameObject != null;
			if (flag16)
			{
				ManageAllGUIElements.ModeGrayUIGameObject.SetActive(false);
			}
			bool flag17 = ManageAllGUIElements.ModeGreenUIGameObject != null;
			if (flag17)
			{
				ManageAllGUIElements.ModeGreenUIGameObject.SetActive(false);
			}
			bool flag18 = ManageAllGUIElements.ModeTurboUIGameObject != null;
			if (flag18)
			{
				ManageAllGUIElements.ModeTurboUIGameObject.SetActive(false);
			}
			bool flag19 = ManageAllGUIElements.CruiseGrayUIGameObject != null;
			if (flag19)
			{
				ManageAllGUIElements.CruiseGrayUIGameObject.SetActive(false);
			}
			bool flag20 = ManageAllGUIElements.CruiseOffUIGameObject != null;
			if (flag20)
			{
				ManageAllGUIElements.CruiseOffUIGameObject.SetActive(false);
			}
			bool flag21 = ManageAllGUIElements.CruiseOnUIGameObject != null;
			if (flag21)
			{
				ManageAllGUIElements.CruiseOnUIGameObject.SetActive(false);
			}
			bool flag22 = ManageAllGUIElements.CruiseSetTextObject != null;
			if (flag22)
			{
				ManageAllGUIElements.CruiseSetTextObject.SetActive(false);
			}
			bool flag23 = ManageAllGUIElements.CogsGrayUIGameObject != null;
			if (flag23)
			{
				ManageAllGUIElements.CogsGrayUIGameObject.SetActive(false);
			}
			bool flag24 = ManageAllGUIElements.CogsBlueUIGameObject != null;
			if (flag24)
			{
				ManageAllGUIElements.CogsBlueUIGameObject.SetActive(false);
			}
			bool flag25 = ManageAllGUIElements.CogsYellowUIGameObject != null;
			if (flag25)
			{
				ManageAllGUIElements.CogsYellowUIGameObject.SetActive(false);
			}
			bool flag26 = ManageAllGUIElements.CogsRedUIGameObject != null;
			if (flag26)
			{
				ManageAllGUIElements.CogsRedUIGameObject.SetActive(false);
			}
			bool flag27 = ManageAllGUIElements.GearTextObject != null;
			if (flag27)
			{
				ManageAllGUIElements.GearTextObject.SetActive(false);
			}
			bool flag28 = ManageAllGUIElements.SpeedNowTextObject != null;
			if (flag28)
			{
				ManageAllGUIElements.SpeedNowTextObject.SetActive(false);
			}
			bool flag29 = ManageAllGUIElements.KmhTextObject != null;
			if (flag29)
			{
				ManageAllGUIElements.KmhTextObject.SetActive(false);
			}
			bool flag30 = ManageAllGUIElements.HealthTextObject != null;
			if (flag30)
			{
				ManageAllGUIElements.HealthTextObject.SetActive(false);
			}
			bool flag31 = ManageAllGUIElements.PowerTextObject != null;
			if (flag31)
			{
				ManageAllGUIElements.PowerTextObject.SetActive(false);
			}
			bool flag32 = ManageAllGUIElements.TemperTextObject != null;
			if (flag32)
			{
				ManageAllGUIElements.TemperTextObject.SetActive(false);
			}
			bool flag33 = ManageAllGUIElements.BackgroundSafetyUIGameObject != null;
			if (flag33)
			{
				ManageAllGUIElements.BackgroundSafetyUIGameObject.SetActive(false);
			}
			bool flag34 = ManageAllGUIElements.MainSafetyUIGameObject != null;
			if (flag34)
			{
				ManageAllGUIElements.MainSafetyUIGameObject.SetActive(false);
			}
			bool flag35 = ManageAllGUIElements.MainSafetyGrayUIGameObject != null;
			if (flag35)
			{
				ManageAllGUIElements.MainSafetyGrayUIGameObject.SetActive(false);
			}
			bool flag36 = ManageAllGUIElements.MainSafetyDescTextObject != null;
			if (flag36)
			{
				ManageAllGUIElements.MainSafetyDescTextObject.SetActive(false);
			}
			bool flag37 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
			if (flag37)
			{
				ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(false);
			}
			bool flag38 = ManageAllGUIElements.ChargerOnUIGameObject != null;
			if (flag38)
			{
				ManageAllGUIElements.ChargerOnUIGameObject.SetActive(false);
			}
			bool flag39 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
			if (flag39)
			{
				ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(false);
			}
			bool flag40 = ManageAllGUIElements.ChargerOffUIGameObject != null;
			if (flag40)
			{
				ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
			}
			bool flag41 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
			if (flag41)
			{
				ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
			}
			bool flag42 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
			if (flag42)
			{
				ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
			}
			bool flag43 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
			if (flag43)
			{
				ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
			}
			bool flag44 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
			if (flag44)
			{
				ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
			}
			bool flag45 = ManageAllGUIElements.CcGrayUIGameObject != null;
			if (flag45)
			{
				ManageAllGUIElements.CcGrayUIGameObject.SetActive(false);
			}
			bool flag46 = ManageAllGUIElements.CcOnUIGameObject != null;
			if (flag46)
			{
				ManageAllGUIElements.CcOnUIGameObject.SetActive(false);
			}
			bool flag47 = ManageAllGUIElements.CcActiveUIGameObject != null;
			if (flag47)
			{
				ManageAllGUIElements.CcActiveUIGameObject.SetActive(false);
			}
			bool flag48 = ManageAllGUIElements.CcOffUIGameObject != null;
			if (flag48)
			{
				ManageAllGUIElements.CcOffUIGameObject.SetActive(false);
			}
			bool flag49 = ManageAllGUIElements.CcArrow01UIGameObject != null;
			if (flag49)
			{
				ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
			}
			bool flag50 = ManageAllGUIElements.EjectGrayUIGameObject != null;
			if (flag50)
			{
				ManageAllGUIElements.EjectGrayUIGameObject.SetActive(false);
			}
			bool flag51 = ManageAllGUIElements.EjectOnUIGameObject != null;
			if (flag51)
			{
				ManageAllGUIElements.EjectOnUIGameObject.SetActive(false);
			}
			bool flag52 = ManageAllGUIElements.EjectActiveUIGameObject != null;
			if (flag52)
			{
				ManageAllGUIElements.EjectActiveUIGameObject.SetActive(false);
			}
			bool flag53 = ManageAllGUIElements.EjectOffUIGameObject != null;
			if (flag53)
			{
				ManageAllGUIElements.EjectOffUIGameObject.SetActive(false);
			}
			bool flag54 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
			if (flag54)
			{
				ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
			}
			bool flag55 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
			if (flag55)
			{
				ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
			}
			bool flag56 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
			if (flag56)
			{
				ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
			}
		}
       

        // Token: 0x04000078 RID: 120
        public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x04000079 RID: 121
		public static GameObject BackgroundUIGameObject = GameObject.Find("BackgroundUI");

		// Token: 0x0400007A RID: 122
		public static GameObject LightGrayUIGameObject = GameObject.Find("LightGrayUI");

		// Token: 0x0400007B RID: 123
		public static GameObject LightSafetyOffUIGameObject = GameObject.Find("LightSafetyOffUI");

		// Token: 0x0400007C RID: 124
		public static GameObject LightSafetyOnUIGameObject = GameObject.Find("LightSafetyOnUI");

		// Token: 0x0400007D RID: 125
		public static GameObject LightLowOffUIGameObject = GameObject.Find("LightLowOffUI");

		// Token: 0x0400007E RID: 126
		public static GameObject LightLowOnUIGameObject = GameObject.Find("LightLowOnUI");

		// Token: 0x0400007F RID: 127
		public static GameObject LightHighOffUIGameObject = GameObject.Find("LightHighOffUI");

		// Token: 0x04000080 RID: 128
		public static GameObject LightHighOnUIGameObject = GameObject.Find("LightHighOnUI");

		// Token: 0x04000081 RID: 129
		public static GameObject BatterySlotGrayUIGameObject = GameObject.Find("BatterySlotGrayUI");

		// Token: 0x04000082 RID: 130
		public static GameObject BatterySlotUIGameObject = GameObject.Find("BatterySlotUI");

		// Token: 0x04000083 RID: 131
		public static GameObject BatteryUnitUIGameObject = GameObject.Find("BatteryUnitUI");

		// Token: 0x04000084 RID: 132
		public static GameObject BatteryArrowsUIGameObject = GameObject.Find("BatteryArrowsUI");

		// Token: 0x04000085 RID: 133
		public static GameObject BatteryInUIGameObject = GameObject.Find("BatteryInUI");

		// Token: 0x04000086 RID: 134
		public static GameObject BatteryOutUIGameObject = GameObject.Find("BatteryOutUI");

		// Token: 0x04000087 RID: 135
		public static GameObject ModeGrayUIGameObject = GameObject.Find("ModeGrayUI");

		// Token: 0x04000088 RID: 136
		public static GameObject ModeGreenUIGameObject = GameObject.Find("ModeGreenUI");

		// Token: 0x04000089 RID: 137
		public static GameObject ModeTurboUIGameObject = GameObject.Find("ModeTurboUI");

		// Token: 0x0400008A RID: 138
		public static GameObject CruiseGrayUIGameObject = GameObject.Find("CruiseGrayUI");

		// Token: 0x0400008B RID: 139
		public static GameObject CruiseOffUIGameObject = GameObject.Find("CruiseOffUI");

		// Token: 0x0400008C RID: 140
		public static GameObject CruiseOnUIGameObject = GameObject.Find("CruiseOnUI");

		// Token: 0x0400008D RID: 141
		public static GameObject CogsGrayUIGameObject = GameObject.Find("CogsGrayUI");

		// Token: 0x0400008E RID: 142
		public static GameObject CogsBlueUIGameObject = GameObject.Find("CogsBlueUI");

		// Token: 0x0400008F RID: 143
		public static GameObject CogsYellowUIGameObject = GameObject.Find("CogsYellowUI");

		// Token: 0x04000090 RID: 144
		public static GameObject CogsRedUIGameObject = GameObject.Find("CogsRedUI");

		// Token: 0x04000091 RID: 145
		public static GameObject GearTextObject = GameObject.Find("GearTextUI");

		// Token: 0x04000092 RID: 146
		public static GameObject CruiseSetTextObject = GameObject.Find("CruiseSetTextUI");

		// Token: 0x04000093 RID: 147
		public static GameObject SpeedNowTextObject = GameObject.Find("SpeedNowTextUI");

		// Token: 0x04000094 RID: 148
		public static GameObject KmhTextObject = GameObject.Find("KmhTextUI");

		// Token: 0x04000095 RID: 149
		public static GameObject HealthTextObject = GameObject.Find("HealthTextUI");

		// Token: 0x04000096 RID: 150
		public static GameObject PowerTextObject = GameObject.Find("PowerTextUI");

		// Token: 0x04000097 RID: 151
		public static GameObject TemperTextObject = GameObject.Find("TemperTextUI");

		// Token: 0x04000098 RID: 152
		public static GameObject BackgroundSafetyUIGameObject = GameObject.Find("BackgroundSafetyUI");

		// Token: 0x04000099 RID: 153
		public static GameObject MainSafetyUIGameObject = GameObject.Find("MainSafetyUI");

		// Token: 0x0400009A RID: 154
		public static GameObject MainSafetyGrayUIGameObject = GameObject.Find("MainSafetyGrayUI");

		// Token: 0x0400009B RID: 155
		public static GameObject MainSafetyDescTextObject = GameObject.Find("MainSafetyDescTextUI");

		// Token: 0x0400009C RID: 156
		public static GameObject ChargerGrayUIGameObject = GameObject.Find("ChargerGrayUI");

		// Token: 0x0400009D RID: 157
		public static GameObject ChargerOnUIGameObject = GameObject.Find("ChargerOnUI");

		// Token: 0x0400009E RID: 158
		public static GameObject ChargerActiveUIGameObject = GameObject.Find("ChargerActiveUI");

		// Token: 0x0400009F RID: 159
		public static GameObject ChargerOffUIGameObject = GameObject.Find("ChargerOffUI");

		// Token: 0x040000A0 RID: 160
		public static GameObject ChargerBar01UIGameObject = GameObject.Find("ChargerBar01UI");

		// Token: 0x040000A1 RID: 161
		public static GameObject ChargerBar02UIGameObject = GameObject.Find("ChargerBar02UI");

		// Token: 0x040000A2 RID: 162
		public static GameObject ChargerBar03UIGameObject = GameObject.Find("ChargerBar03UI");

		// Token: 0x040000A3 RID: 163
		public static GameObject ChargerBar04UIGameObject = GameObject.Find("ChargerBar04UI");

		// Token: 0x040000A4 RID: 164
		public static GameObject CcGrayUIGameObject = GameObject.Find("CcGrayUI");

		// Token: 0x040000A5 RID: 165
		public static GameObject CcOnUIGameObject = GameObject.Find("CcOnUI");

		// Token: 0x040000A6 RID: 166
		public static GameObject CcActiveUIGameObject = GameObject.Find("CcActiveUI");

		// Token: 0x040000A7 RID: 167
		public static GameObject CcOffUIGameObject = GameObject.Find("CcOffUI");

		// Token: 0x040000A8 RID: 168
		public static GameObject CcArrow01UIGameObject = GameObject.Find("CcArrow01UI");

		// Token: 0x040000A9 RID: 169
		public static GameObject EjectGrayUIGameObject = GameObject.Find("EjectGrayUI");

		// Token: 0x040000AA RID: 170
		public static GameObject EjectOnUIGameObject = GameObject.Find("EjectOnUI");

		// Token: 0x040000AB RID: 171
		public static GameObject EjectActiveUIGameObject = GameObject.Find("EjectActiveUI");

		// Token: 0x040000AC RID: 172
		public static GameObject EjectOffUIGameObject = GameObject.Find("EjectOffUI");

		// Token: 0x040000AD RID: 173
		public static GameObject EjectPilot01UIGameObject = GameObject.Find("EjectPilot01UI");

		// Token: 0x040000AE RID: 174
		public static GameObject EjectPilot02UIGameObject = GameObject.Find("EjectPilot02UI");

		// Token: 0x040000AF RID: 175
		public static GameObject EjectPilot03UIGameObject = GameObject.Find("EjectPilot03UI");

		// Token: 0x040000B0 RID: 176
		public static string colorWhite = "<color=white>";

		// Token: 0x040000B1 RID: 177
		public static string colorYellow = "<color=yellow>";

		// Token: 0x040000B2 RID: 178
		public static string colorRed = "<color=red>";

		// Token: 0x040000B3 RID: 179
		public static string colorEnd = "</color>";

        public static void CheckForNullObjects()
        {
            // Check each GameObject and log if any are null
            if (gameObject == null) Debug.LogError("HUD GameObject is null.");
            if (BackgroundUIGameObject == null) Debug.LogError("BackgroundUI GameObject is null.");
            if (LightGrayUIGameObject == null) Debug.LogError("LightGrayUI GameObject is null.");
            if (LightSafetyOffUIGameObject == null) Debug.LogError("LightSafetyOffUI GameObject is null.");
            if (LightSafetyOnUIGameObject == null) Debug.LogError("LightSafetyOnUI GameObject is null.");
            if (LightLowOffUIGameObject == null) Debug.LogError("LightLowOffUI GameObject is null.");
            if (LightLowOnUIGameObject == null) Debug.LogError("LightLowOnUI GameObject is null.");
            if (LightHighOffUIGameObject == null) Debug.LogError("LightHighOffUI GameObject is null.");
            if (LightHighOnUIGameObject == null) Debug.LogError("LightHighOnUI GameObject is null.");
            if (BatterySlotGrayUIGameObject == null) Debug.LogError("BatterySlotGrayUI GameObject is null.");
            if (BatterySlotUIGameObject == null) Debug.LogError("BatterySlotUI GameObject is null.");
            if (BatteryUnitUIGameObject == null) Debug.LogError("BatteryUnitUI GameObject is null.");
            if (BatteryArrowsUIGameObject == null) Debug.LogError("BatteryArrowsUI GameObject is null.");
            if (BatteryInUIGameObject == null) Debug.LogError("BatteryInUI GameObject is null.");
            if (BatteryOutUIGameObject == null) Debug.LogError("BatteryOutUI GameObject is null.");
            if (ModeGrayUIGameObject == null) Debug.LogError("ModeGrayUI GameObject is null.");
            if (ModeGreenUIGameObject == null) Debug.LogError("ModeGreenUI GameObject is null.");
            if (ModeTurboUIGameObject == null) Debug.LogError("ModeTurboUI GameObject is null.");
            if (CruiseGrayUIGameObject == null) Debug.LogError("CruiseGrayUI GameObject is null.");
            if (CruiseOffUIGameObject == null) Debug.LogError("CruiseOffUI GameObject is null.");
            if (CruiseOnUIGameObject == null) Debug.LogError("CruiseOnUI GameObject is null.");
            if (CogsGrayUIGameObject == null) Debug.LogError("CogsGrayUI GameObject is null.");
            if (CogsBlueUIGameObject == null) Debug.LogError("CogsBlueUI GameObject is null.");
            if (CogsYellowUIGameObject == null) Debug.LogError("CogsYellowUI GameObject is null.");
            if (CogsRedUIGameObject == null) Debug.LogError("CogsRedUI GameObject is null.");
            if (GearTextObject == null) Debug.LogError("GearTextUI GameObject is null.");
            if (CruiseSetTextObject == null) Debug.LogError("CruiseSetTextUI GameObject is null.");
            if (SpeedNowTextObject == null) Debug.LogError("SpeedNowTextUI GameObject is null.");
            if (KmhTextObject == null) Debug.LogError("KmhTextUI GameObject is null.");
            if (HealthTextObject == null) Debug.LogError("HealthTextUI GameObject is null.");
            if (PowerTextObject == null) Debug.LogError("PowerTextUI GameObject is null.");
            if (TemperTextObject == null) Debug.LogError("TemperTextUI GameObject is null.");
            if (BackgroundSafetyUIGameObject == null) Debug.LogError("BackgroundSafetyUI GameObject is null.");
            if (MainSafetyUIGameObject == null) Debug.LogError("MainSafetyUI GameObject is null.");
            if (MainSafetyGrayUIGameObject == null) Debug.LogError("MainSafetyGrayUI GameObject is null.");
            if (MainSafetyDescTextObject == null) Debug.LogError("MainSafetyDescTextUI GameObject is null.");
            if (ChargerGrayUIGameObject == null) Debug.LogError("ChargerGrayUI GameObject is null.");
            if (ChargerOnUIGameObject == null) Debug.LogError("ChargerOnUI GameObject is null.");
            if (ChargerActiveUIGameObject == null) Debug.LogError("ChargerActiveUI GameObject is null.");
            if (ChargerOffUIGameObject == null) Debug.LogError("ChargerOffUI GameObject is null.");
            if (ChargerBar01UIGameObject == null) Debug.LogError("ChargerBar01UI GameObject is null.");
            if (ChargerBar02UIGameObject == null) Debug.LogError("ChargerBar02UI GameObject is null.");
            if (ChargerBar03UIGameObject == null) Debug.LogError("ChargerBar03UI GameObject is null.");
            if (ChargerBar04UIGameObject == null) Debug.LogError("ChargerBar04UI GameObject is null.");
            if (CcGrayUIGameObject == null) Debug.LogError("CcGrayUI GameObject is null.");
            if (CcOnUIGameObject == null) Debug.LogError("CcOnUI GameObject is null.");
            if (CcActiveUIGameObject == null) Debug.LogError("CcActiveUI GameObject is null.");
            if (CcOffUIGameObject == null) Debug.LogError("CcOffUI GameObject is null.");
            if (CcArrow01UIGameObject == null) Debug.LogError("CcArrow01UI GameObject is null.");
            if (EjectGrayUIGameObject == null) Debug.LogError("EjectGrayUI GameObject is null.");
            if (EjectOnUIGameObject == null) Debug.LogError("EjectOnUI GameObject is null.");
            if (EjectActiveUIGameObject == null) Debug.LogError("EjectActiveUI GameObject is null.");
            if (EjectOffUIGameObject == null) Debug.LogError("EjectOffUI GameObject is null.");
            if (EjectPilot01UIGameObject == null) Debug.LogError("EjectPilot01UI GameObject is null.");
            if (EjectPilot02UIGameObject == null) Debug.LogError("EjectPilot02UI GameObject is null.");
            if (EjectPilot03UIGameObject == null) Debug.LogError("EjectPilot03UI GameObject is null.");
        }
    }
}
