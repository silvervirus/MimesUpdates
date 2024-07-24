using System;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200001E RID: 30
	internal class ManageChargerIcons
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00006C48 File Offset: 0x00004E48
		internal static void ManageCharger()
		{
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
			{
				bool flag = SeamothInfo.electricalModuleIn && SeamothInfo.seamothLinkModuleIn;
				if (flag)
				{
					bool safeDepthChargerOn = SeamothInfo.safeDepthChargerOn;
					if (safeDepthChargerOn)
					{
						bool flag2 = SeamothInfo.safeDepthChargerActive && SeamothInfo.BatteryInSlot > 0;
						if (flag2)
						{
							bool flag3 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
							if (flag3)
							{
								ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(false);
							}
							bool flag4 = ManageAllGUIElements.ChargerOnUIGameObject != null;
							if (flag4)
							{
								ManageAllGUIElements.ChargerOnUIGameObject.SetActive(false);
							}
							bool flag5 = ManageAllGUIElements.ChargerOffUIGameObject != null;
							if (flag5)
							{
								ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
							}
							bool flag6 = ManageAllGUIElements.ChargerActiveUIGameObject == null;
							if (flag6)
							{
								ManageAllGUIElements.ChargerActiveUIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerActiveUI", GearInfo.charger_Position);
							}
							bool flag7 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
							if (flag7)
							{
								ManageAllGUIElements.ChargerActiveUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerActiveUIGameObject, "safety_charger_active_100x100", GearInfo.charger_Position, GearInfo.charger_Size);
							}
							bool flag8 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
							if (flag8)
							{
								ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(true);
							}
							float num = 5f;
							SeamothInfo.ChargerTimer += Time.deltaTime;
							switch ((int)SeamothInfo.ChargerTimer)
							{
							case 1:
							{
								bool flag9 = ManageAllGUIElements.ChargerBar01UIGameObject == null;
								if (flag9)
								{
									ManageAllGUIElements.ChargerBar01UIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerBar01UI", GearInfo.charger_Position);
								}
								bool flag10 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
								if (flag10)
								{
									ManageAllGUIElements.ChargerBar01UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerBar01UIGameObject, "charger_bar_01", GearInfo.charger_Position, GearInfo.charger_Size);
								}
								bool flag11 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
								if (flag11)
								{
									ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(true);
								}
								break;
							}
							case 2:
							{
								bool flag12 = ManageAllGUIElements.ChargerBar02UIGameObject == null;
								if (flag12)
								{
									ManageAllGUIElements.ChargerBar02UIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerBar02UI", GearInfo.charger_Position);
								}
								bool flag13 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
								if (flag13)
								{
									ManageAllGUIElements.ChargerBar02UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerBar02UIGameObject, "charger_bar_02", GearInfo.charger_Position, GearInfo.charger_Size);
								}
								bool flag14 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
								if (flag14)
								{
									ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(true);
								}
								break;
							}
							case 3:
							{
								bool flag15 = ManageAllGUIElements.ChargerBar03UIGameObject == null;
								if (flag15)
								{
									ManageAllGUIElements.ChargerBar03UIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerBar03UI", GearInfo.charger_Position);
								}
								bool flag16 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
								if (flag16)
								{
									ManageAllGUIElements.ChargerBar03UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerBar03UIGameObject, "charger_bar_03", GearInfo.charger_Position, GearInfo.charger_Size);
								}
								bool flag17 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
								if (flag17)
								{
									ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(true);
								}
								break;
							}
							case 4:
							{
								bool flag18 = ManageAllGUIElements.ChargerBar04UIGameObject == null;
								if (flag18)
								{
									ManageAllGUIElements.ChargerBar04UIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerBar04UI", GearInfo.charger_Position);
								}
								bool flag19 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
								if (flag19)
								{
									ManageAllGUIElements.ChargerBar04UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerBar04UIGameObject, "charger_bar_04", GearInfo.charger_Position, GearInfo.charger_Size);
								}
								bool flag20 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
								if (flag20)
								{
									ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(true);
								}
								break;
							}
							default:
							{
								bool flag21 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
								if (flag21)
								{
									ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
								}
								bool flag22 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
								if (flag22)
								{
									ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
								}
								bool flag23 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
								if (flag23)
								{
									ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
								}
								bool flag24 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
								if (flag24)
								{
									ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
								}
								break;
							}
							}
							bool flag25 = SeamothInfo.ChargerTimer >= num;
							if (flag25)
							{
								SeamothInfo.ChargerTimer = 0f;
							}
						}
						else
						{
							SeamothInfo.ChargerTimer = 0f;
							bool flag26 = SeamothInfo.BatteryInSlot > 0;
							if (flag26)
							{
								bool flag27 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
								if (flag27)
								{
									ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(false);
								}
								bool flag28 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
								if (flag28)
								{
									ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(false);
								}
								bool flag29 = ManageAllGUIElements.ChargerOffUIGameObject != null;
								if (flag29)
								{
									ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
								}
								bool flag30 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
								if (flag30)
								{
									ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
								}
								bool flag31 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
								if (flag31)
								{
									ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
								}
								bool flag32 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
								if (flag32)
								{
									ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
								}
								bool flag33 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
								if (flag33)
								{
									ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
								}
								bool flag34 = ManageAllGUIElements.ChargerOnUIGameObject == null;
								if (flag34)
								{
									ManageAllGUIElements.ChargerOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerOnUI", GearInfo.charger_Position);
								}
								bool flag35 = ManageAllGUIElements.ChargerOnUIGameObject != null;
								if (flag35)
								{
									ManageAllGUIElements.ChargerOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerOnUIGameObject, "safety_charger_on_100x100", GearInfo.charger_Position, GearInfo.charger_Size);
								}
								bool flag36 = ManageAllGUIElements.ChargerOnUIGameObject != null;
								if (flag36)
								{
									ManageAllGUIElements.ChargerOnUIGameObject.SetActive(true);
								}
							}
							else
							{
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
								bool flag39 = ManageAllGUIElements.ChargerOffUIGameObject != null;
								if (flag39)
								{
									ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
								}
								bool flag40 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
								if (flag40)
								{
									ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
								}
								bool flag41 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
								if (flag41)
								{
									ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
								}
								bool flag42 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
								if (flag42)
								{
									ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
								}
								bool flag43 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
								if (flag43)
								{
									ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
								}
								bool flag44 = ManageAllGUIElements.ChargerActiveUIGameObject == null;
								if (flag44)
								{
									ManageAllGUIElements.ChargerActiveUIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerActiveUI", GearInfo.charger_Position);
								}
								bool flag45 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
								if (flag45)
								{
									ManageAllGUIElements.ChargerActiveUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerActiveUIGameObject, "safety_charger_active_100x100", GearInfo.charger_Position, GearInfo.charger_Size);
								}
								bool flag46 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
								if (flag46)
								{
									ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(true);
								}
							}
						}
					}
					else
					{
						bool flag47 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
						if (flag47)
						{
							ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(false);
						}
						bool flag48 = ManageAllGUIElements.ChargerOnUIGameObject != null;
						if (flag48)
						{
							ManageAllGUIElements.ChargerOnUIGameObject.SetActive(false);
						}
						bool flag49 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
						if (flag49)
						{
							ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(false);
						}
						bool flag50 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
						if (flag50)
						{
							ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
						}
						bool flag51 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
						if (flag51)
						{
							ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
						}
						bool flag52 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
						if (flag52)
						{
							ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
						}
						bool flag53 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
						if (flag53)
						{
							ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
						}
						bool flag54 = ManageAllGUIElements.ChargerOffUIGameObject == null;
						if (flag54)
						{
							ManageAllGUIElements.ChargerOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerOffUI", GearInfo.charger_Position);
						}
						bool flag55 = ManageAllGUIElements.ChargerOffUIGameObject != null;
						if (flag55)
						{
							ManageAllGUIElements.ChargerOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerOffUIGameObject, "safety_charger_off_100x100", GearInfo.charger_Position, GearInfo.charger_Size);
						}
						bool flag56 = ManageAllGUIElements.ChargerOffUIGameObject != null;
						if (flag56)
						{
							ManageAllGUIElements.ChargerOffUIGameObject.SetActive(true);
						}
					}
				}
				else
				{
					bool flag57 = ManageAllGUIElements.ChargerOffUIGameObject != null;
					if (flag57)
					{
						ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
					}
					bool flag58 = ManageAllGUIElements.ChargerOnUIGameObject != null;
					if (flag58)
					{
						ManageAllGUIElements.ChargerOnUIGameObject.SetActive(false);
					}
					bool flag59 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
					if (flag59)
					{
						ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(false);
					}
					bool flag60 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
					if (flag60)
					{
						ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
					}
					bool flag61 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
					if (flag61)
					{
						ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
					}
					bool flag62 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
					if (flag62)
					{
						ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
					}
					bool flag63 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
					if (flag63)
					{
						ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
					}
					bool flag64 = ManageAllGUIElements.ChargerGrayUIGameObject == null;
					if (flag64)
					{
						ManageAllGUIElements.ChargerGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("ChargerGrayUI", GearInfo.charger_Position);
					}
					bool flag65 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
					if (flag65)
					{
						ManageAllGUIElements.ChargerGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChargerGrayUIGameObject, "safety_charger_gray_100x100", GearInfo.charger_Position, GearInfo.charger_Size);
					}
					bool flag66 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
					if (flag66)
					{
						ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag67 = ManageAllGUIElements.ChargerGrayUIGameObject != null;
				if (flag67)
				{
					ManageAllGUIElements.ChargerGrayUIGameObject.SetActive(false);
				}
				bool flag68 = ManageAllGUIElements.ChargerOffUIGameObject != null;
				if (flag68)
				{
					ManageAllGUIElements.ChargerOffUIGameObject.SetActive(false);
				}
				bool flag69 = ManageAllGUIElements.ChargerOnUIGameObject != null;
				if (flag69)
				{
					ManageAllGUIElements.ChargerOnUIGameObject.SetActive(false);
				}
				bool flag70 = ManageAllGUIElements.ChargerActiveUIGameObject != null;
				if (flag70)
				{
					ManageAllGUIElements.ChargerActiveUIGameObject.SetActive(false);
				}
				bool flag71 = ManageAllGUIElements.ChargerBar01UIGameObject != null;
				if (flag71)
				{
					ManageAllGUIElements.ChargerBar01UIGameObject.SetActive(false);
				}
				bool flag72 = ManageAllGUIElements.ChargerBar02UIGameObject != null;
				if (flag72)
				{
					ManageAllGUIElements.ChargerBar02UIGameObject.SetActive(false);
				}
				bool flag73 = ManageAllGUIElements.ChargerBar03UIGameObject != null;
				if (flag73)
				{
					ManageAllGUIElements.ChargerBar03UIGameObject.SetActive(false);
				}
				bool flag74 = ManageAllGUIElements.ChargerBar04UIGameObject != null;
				if (flag74)
				{
					ManageAllGUIElements.ChargerBar04UIGameObject.SetActive(false);
				}
			}
		}
	}
}
