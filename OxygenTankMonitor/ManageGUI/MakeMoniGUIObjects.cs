using System;
using OxygenTankMonitor.InfoObjects;
using UnityEngine;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x0200000C RID: 12
	internal class MakeMoniGUIObjects
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002BFC File Offset: 0x00000DFC
		internal static void MakeMoniObjects()
		{
			bool flag = ManageAllGUIElements.BGleftUIGameObject == null;
			if (flag)
			{
				ManageAllGUIElements.BGleftUIGameObject = PrepareGUIObjects.PrepareGUIObject("BGleftUI", ModInfo.BG_Position);
				bool flag2 = ManageAllGUIElements.BGleftUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.BGleftUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGleftUIGameObject, "BGleft.png", ModInfo.BG_Position, ModInfo.BG_Size);
				}
				bool flag3 = ManageAllGUIElements.BGleftUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.BGleftUIGameObject.SetActive(false);
				}
			}
			bool flag4 = ManageAllGUIElements.BGrightUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.BGrightUIGameObject = PrepareGUIObjects.PrepareGUIObject("BGrightUI", ModInfo.BG_Position);
				bool flag5 = ManageAllGUIElements.BGrightUIGameObject != null;
				if (flag5)
				{
					ManageAllGUIElements.BGrightUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGrightUIGameObject, "BGright.png", new Vector3(ModInfo.BGmoveLeftRightX + ModInfo.shiftRight, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag6 = ManageAllGUIElements.BGrightUIGameObject != null;
				if (flag6)
				{
					ManageAllGUIElements.BGrightUIGameObject.SetActive(false);
				}
			}
			bool flag7 = ManageAllGUIElements.BGc01UIGameObject == null;
			if (flag7)
			{
				ManageAllGUIElements.BGc01UIGameObject = PrepareGUIObjects.PrepareGUIObject("BGc01UI", ModInfo.BG_Position);
				bool flag8 = ManageAllGUIElements.BGc01UIGameObject != null;
				if (flag8)
				{
					ManageAllGUIElements.BGc01UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGc01UIGameObject, "BGcentre.png", new Vector3(ModInfo.BGmoveLeftRightX + ModInfo.shiftRight, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag9 = ManageAllGUIElements.BGc01UIGameObject != null;
				if (flag9)
				{
					ManageAllGUIElements.BGc01UIGameObject.SetActive(false);
				}
			}
			bool flag10 = ManageAllGUIElements.BGc02UIGameObject == null;
			if (flag10)
			{
				ManageAllGUIElements.BGc02UIGameObject = PrepareGUIObjects.PrepareGUIObject("BGc02UI", ModInfo.BG_Position);
				bool flag11 = ManageAllGUIElements.BGc02UIGameObject != null;
				if (flag11)
				{
					ManageAllGUIElements.BGc02UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGc02UIGameObject, "BGcentre.png", new Vector3(ModInfo.BGmoveLeftRightX + ModInfo.shiftRight * 2f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag12 = ManageAllGUIElements.BGc02UIGameObject != null;
				if (flag12)
				{
					ManageAllGUIElements.BGc02UIGameObject.SetActive(false);
				}
			}
			bool flag13 = ManageAllGUIElements.BGc03UIGameObject == null;
			if (flag13)
			{
				ManageAllGUIElements.BGc03UIGameObject = PrepareGUIObjects.PrepareGUIObject("BGc03UI", ModInfo.BG_Position);
				bool flag14 = ManageAllGUIElements.BGc03UIGameObject != null;
				if (flag14)
				{
					ManageAllGUIElements.BGc03UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGc03UIGameObject, "BGcentre.png", new Vector3(ModInfo.BGmoveLeftRightX + ModInfo.shiftRight * 3f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag15 = ManageAllGUIElements.BGc03UIGameObject != null;
				if (flag15)
				{
					ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
				}
			}
			bool flag16 = ManageAllGUIElements.BGc04UIGameObject == null;
			if (flag16)
			{
				ManageAllGUIElements.BGc04UIGameObject = PrepareGUIObjects.PrepareGUIObject("BGc04UI", ModInfo.BG_Position);
				bool flag17 = ManageAllGUIElements.BGc04UIGameObject != null;
				if (flag17)
				{
					ManageAllGUIElements.BGc04UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGc04UIGameObject, "BGcentre.png", new Vector3(ModInfo.BGmoveLeftRightX + ModInfo.shiftRight * 4f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag18 = ManageAllGUIElements.BGc04UIGameObject != null;
				if (flag18)
				{
					ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
				}
			}
			bool flag19 = ManageAllGUIElements.BGsingleUIGameObject == null;
			if (flag19)
			{
				ManageAllGUIElements.BGsingleUIGameObject = PrepareGUIObjects.PrepareGUIObject("BGsingleUI", ModInfo.BG_Position);
				bool flag20 = ManageAllGUIElements.BGsingleUIGameObject != null;
				if (flag20)
				{
					ManageAllGUIElements.BGsingleUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BGsingleUIGameObject, "BGsingle.png", ModInfo.BG_Position, ModInfo.BG_Size);
				}
				bool flag21 = ManageAllGUIElements.BGsingleUIGameObject != null;
				if (flag21)
				{
					ManageAllGUIElements.BGsingleUIGameObject.SetActive(false);
				}
			}
			bool flag22 = ManageAllGUIElements.TankBarMoni00UIGameObject == null;
			if (flag22)
			{
				ManageAllGUIElements.TankBarMoni00UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankBarMoni00UI", ModInfo.icon_TankPos);
				bool flag23 = ManageAllGUIElements.TankBarMoni00UIGameObject != null;
				if (flag23)
				{
					ManageAllGUIElements.TankBarMoni00UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankBarMoni00UIGameObject, "TankBar.png", new Vector3(ModInfo.icon_TankBarX, ModInfo.icon_TankBarY, 0f), ModInfo.icon_TankBarSize);
				}
				bool flag24 = ManageAllGUIElements.TankBarMoni00UIGameObject != null;
				if (flag24)
				{
					ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(false);
				}
			}
			bool flag25 = ManageAllGUIElements.TankBarMoni01UIGameObject == null;
			if (flag25)
			{
				ManageAllGUIElements.TankBarMoni01UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankBarMoni01UI", ModInfo.icon_TankPos);
				bool flag26 = ManageAllGUIElements.TankBarMoni01UIGameObject != null;
				if (flag26)
				{
					ManageAllGUIElements.TankBarMoni01UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankBarMoni01UIGameObject, "TankBar.png", new Vector3(ModInfo.icon_TankBarX + ModInfo.shiftRight, ModInfo.icon_TankBarY, 0f), ModInfo.icon_TankBarSize);
				}
				bool flag27 = ManageAllGUIElements.TankBarMoni01UIGameObject != null;
				if (flag27)
				{
					ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(false);
				}
			}
			bool flag28 = ManageAllGUIElements.TankBarMoni02UIGameObject == null;
			if (flag28)
			{
				ManageAllGUIElements.TankBarMoni02UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankBarMoni02UI", ModInfo.icon_TankPos);
				bool flag29 = ManageAllGUIElements.TankBarMoni02UIGameObject != null;
				if (flag29)
				{
					ManageAllGUIElements.TankBarMoni02UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankBarMoni02UIGameObject, "TankBar.png", new Vector3(ModInfo.icon_TankBarX + ModInfo.shiftRight * 2f, ModInfo.icon_TankBarY, 0f), ModInfo.icon_TankBarSize);
				}
				bool flag30 = ManageAllGUIElements.TankBarMoni02UIGameObject != null;
				if (flag30)
				{
					ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(false);
				}
			}
			bool flag31 = ManageAllGUIElements.TankBarMoni03UIGameObject == null;
			if (flag31)
			{
				ManageAllGUIElements.TankBarMoni03UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankBarMoni03UI", ModInfo.icon_TankPos);
				bool flag32 = ManageAllGUIElements.TankBarMoni03UIGameObject != null;
				if (flag32)
				{
					ManageAllGUIElements.TankBarMoni03UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankBarMoni03UIGameObject, "TankBar.png", new Vector3(ModInfo.icon_TankBarX + ModInfo.shiftRight * 3f, ModInfo.icon_TankBarY, 0f), ModInfo.icon_TankBarSize);
				}
				bool flag33 = ManageAllGUIElements.TankBarMoni03UIGameObject != null;
				if (flag33)
				{
					ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(false);
				}
			}
			bool flag34 = ManageAllGUIElements.TankBarMoni04UIGameObject == null;
			if (flag34)
			{
				ManageAllGUIElements.TankBarMoni04UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankBarMoni04UI", ModInfo.icon_TankPos);
				bool flag35 = ManageAllGUIElements.TankBarMoni04UIGameObject != null;
				if (flag35)
				{
					ManageAllGUIElements.TankBarMoni04UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankBarMoni04UIGameObject, "TankBar.png", new Vector3(ModInfo.icon_TankBarX + ModInfo.shiftRight * 4f, ModInfo.icon_TankBarY, 0f), ModInfo.icon_TankBarSize);
				}
				bool flag36 = ManageAllGUIElements.TankBarMoni04UIGameObject != null;
				if (flag36)
				{
					ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
				}
			}
			bool flag37 = ManageAllGUIElements.TankBarMoni05UIGameObject == null;
			if (flag37)
			{
				ManageAllGUIElements.TankBarMoni05UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankBarMoni05UI", ModInfo.icon_TankPos);
				bool flag38 = ManageAllGUIElements.TankBarMoni05UIGameObject != null;
				if (flag38)
				{
					ManageAllGUIElements.TankBarMoni05UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankBarMoni05UIGameObject, "TankBar.png", new Vector3(ModInfo.icon_TankBarX + ModInfo.shiftRight * 5f, ModInfo.icon_TankBarY, 0f), ModInfo.icon_TankBarSize);
				}
				bool flag39 = ManageAllGUIElements.TankBarMoni05UIGameObject != null;
				if (flag39)
				{
					ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
				}
			}
			bool flag40 = ManageAllGUIElements.TankIconMoni00UIGameObject == null;
			if (flag40)
			{
				ManageAllGUIElements.TankIconMoni00UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMoni00UI", ModInfo.icon_TankPos);
				bool flag41 = ManageAllGUIElements.TankIconMoni00UIGameObject != null;
				if (flag41)
				{
					ManageAllGUIElements.TankIconMoni00UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMoni00UIGameObject, "TankIconMonitor.png", ModInfo.icon_TankMoniPos, ModInfo.icon_TankMoniSize);
				}
				bool flag42 = ManageAllGUIElements.TankIconMoni00UIGameObject != null;
				if (flag42)
				{
					ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(false);
				}
			}
			bool flag43 = ManageAllGUIElements.TankIconMoni01UIGameObject == null;
			if (flag43)
			{
				ManageAllGUIElements.TankIconMoni01UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMoni01UI", ModInfo.icon_TankPos);
				bool flag44 = ManageAllGUIElements.TankIconMoni01UIGameObject != null;
				if (flag44)
				{
					ManageAllGUIElements.TankIconMoni01UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMoni01UIGameObject, "TankIconMonitor.png", new Vector3(ModInfo.icon_TankMoniX + ModInfo.shiftRight, ModInfo.icon_TankMoniY, 0f), ModInfo.icon_TankMoniSize);
				}
				bool flag45 = ManageAllGUIElements.TankIconMoni01UIGameObject != null;
				if (flag45)
				{
					ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(false);
				}
			}
			bool flag46 = ManageAllGUIElements.TankIconMoni02UIGameObject == null;
			if (flag46)
			{
				ManageAllGUIElements.TankIconMoni02UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMoni02UI", ModInfo.icon_TankPos);
				bool flag47 = ManageAllGUIElements.TankIconMoni02UIGameObject != null;
				if (flag47)
				{
					ManageAllGUIElements.TankIconMoni02UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMoni02UIGameObject, "TankIconMonitor.png", new Vector3(ModInfo.icon_TankMoniX + ModInfo.shiftRight * 2f, ModInfo.icon_TankMoniY, 0f), ModInfo.icon_TankMoniSize);
				}
				bool flag48 = ManageAllGUIElements.TankIconMoni02UIGameObject != null;
				if (flag48)
				{
					ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(false);
				}
			}
			bool flag49 = ManageAllGUIElements.TankIconMoni03UIGameObject == null;
			if (flag49)
			{
				ManageAllGUIElements.TankIconMoni03UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMoni03UI", ModInfo.icon_TankPos);
				bool flag50 = ManageAllGUIElements.TankIconMoni03UIGameObject != null;
				if (flag50)
				{
					ManageAllGUIElements.TankIconMoni03UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMoni03UIGameObject, "TankIconMonitor.png", new Vector3(ModInfo.icon_TankMoniX + ModInfo.shiftRight * 3f, ModInfo.icon_TankMoniY, 0f), ModInfo.icon_TankMoniSize);
				}
				bool flag51 = ManageAllGUIElements.TankIconMoni03UIGameObject != null;
				if (flag51)
				{
					ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(false);
				}
			}
			bool flag52 = ManageAllGUIElements.TankIconMoni04UIGameObject == null;
			if (flag52)
			{
				ManageAllGUIElements.TankIconMoni04UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMoni04UI", ModInfo.icon_TankPos);
				bool flag53 = ManageAllGUIElements.TankIconMoni04UIGameObject != null;
				if (flag53)
				{
					ManageAllGUIElements.TankIconMoni04UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMoni04UIGameObject, "TankIconMonitor.png", new Vector3(ModInfo.icon_TankMoniX + ModInfo.shiftRight * 4f, ModInfo.icon_TankMoniY, 0f), ModInfo.icon_TankMoniSize);
				}
				bool flag54 = ManageAllGUIElements.TankIconMoni04UIGameObject != null;
				if (flag54)
				{
					ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
				}
			}
			bool flag55 = ManageAllGUIElements.TankIconMoni05UIGameObject == null;
			if (flag55)
			{
				ManageAllGUIElements.TankIconMoni05UIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMoni05UI", ModInfo.icon_TankPos);
				bool flag56 = ManageAllGUIElements.TankIconMoni05UIGameObject != null;
				if (flag56)
				{
					ManageAllGUIElements.TankIconMoni05UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMoni05UIGameObject, "TankIconMonitor.png", new Vector3(ModInfo.icon_TankMoniX + ModInfo.shiftRight * 5f, ModInfo.icon_TankMoniY, 0f), ModInfo.icon_TankMoniSize);
				}
				bool flag57 = ManageAllGUIElements.TankIconMoni05UIGameObject != null;
				if (flag57)
				{
					ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
				}
			}
			bool flag58 = ManageAllGUIElements.TankTextObj00 == null;
			if (flag58)
			{
				ManageAllGUIElements.TankTextObj00 = PrepareGUIObjects.PrepareGUIObject("TankTextUI00", ModInfo.BG_Position);
				bool flag59 = ManageAllGUIElements.TankTextObj00 != null;
				if (flag59)
				{
					ManageAllGUIElements.TankTextObj00 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj00, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.TxtLeftRightX, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag60 = ManageAllGUIElements.TankTextObj00 != null;
				if (flag60)
				{
					ManageAllGUIElements.TankTextObj00.SetActive(false);
				}
			}
			bool flag61 = ManageAllGUIElements.TankTextObj01 == null;
			if (flag61)
			{
				ManageAllGUIElements.TankTextObj01 = PrepareGUIObjects.PrepareGUIObject("TankTextUI01", ModInfo.BG_Position);
				bool flag62 = ManageAllGUIElements.TankTextObj01 != null;
				if (flag62)
				{
					ManageAllGUIElements.TankTextObj01 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj01, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.TxtLeftRightX + ModInfo.shiftRight, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag63 = ManageAllGUIElements.TankTextObj01 != null;
				if (flag63)
				{
					ManageAllGUIElements.TankTextObj01.SetActive(false);
				}
			}
			bool flag64 = ManageAllGUIElements.TankTextObj02 == null;
			if (flag64)
			{
				ManageAllGUIElements.TankTextObj02 = PrepareGUIObjects.PrepareGUIObject("TankTextUI02", ModInfo.BG_Position);
				bool flag65 = ManageAllGUIElements.TankTextObj02 != null;
				if (flag65)
				{
					ManageAllGUIElements.TankTextObj02 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj02, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.TxtLeftRightX + ModInfo.shiftRight * 2f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag66 = ManageAllGUIElements.TankTextObj02 != null;
				if (flag66)
				{
					ManageAllGUIElements.TankTextObj02.SetActive(false);
				}
			}
			bool flag67 = ManageAllGUIElements.TankTextObj03 == null;
			if (flag67)
			{
				ManageAllGUIElements.TankTextObj03 = PrepareGUIObjects.PrepareGUIObject("TankTextUI03", ModInfo.BG_Position);
				bool flag68 = ManageAllGUIElements.TankTextObj03 != null;
				if (flag68)
				{
					ManageAllGUIElements.TankTextObj03 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj03, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.TxtLeftRightX + ModInfo.shiftRight * 3f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag69 = ManageAllGUIElements.TankTextObj03 != null;
				if (flag69)
				{
					ManageAllGUIElements.TankTextObj03.SetActive(false);
				}
			}
			bool flag70 = ManageAllGUIElements.TankTextObj04 == null;
			if (flag70)
			{
				ManageAllGUIElements.TankTextObj04 = PrepareGUIObjects.PrepareGUIObject("TankTextUI04", ModInfo.BG_Position);
				bool flag71 = ManageAllGUIElements.TankTextObj04 != null;
				if (flag71)
				{
					ManageAllGUIElements.TankTextObj04 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj04, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.TxtLeftRightX + ModInfo.shiftRight * 4f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag72 = ManageAllGUIElements.TankTextObj04 != null;
				if (flag72)
				{
					ManageAllGUIElements.TankTextObj04.SetActive(false);
				}
			}
			bool flag73 = ManageAllGUIElements.TankTextObj05 == null;
			if (flag73)
			{
				ManageAllGUIElements.TankTextObj05 = PrepareGUIObjects.PrepareGUIObject("TankTextUI05", ModInfo.BG_Position);
				bool flag74 = ManageAllGUIElements.TankTextObj05 != null;
				if (flag74)
				{
					ManageAllGUIElements.TankTextObj05 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj05, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.TxtLeftRightX + ModInfo.shiftRight * 5f, ModInfo.BGmoveUpDownY, 0f), ModInfo.BG_Size);
				}
				bool flag75 = ManageAllGUIElements.TankTextObj05 != null;
				if (flag75)
				{
					ManageAllGUIElements.TankTextObj05.SetActive(false);
				}
			}
		}
	}
}
