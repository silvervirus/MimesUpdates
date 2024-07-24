using System;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200001D RID: 29
	internal class ManageCcIcons
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000066D4 File Offset: 0x000048D4
		internal static void ManageCc()
		{
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
			{
				bool flag = SeamothInfo.electronicModuleIn && SeamothInfo.seamothLinkModuleIn;
				if (flag)
				{
					bool safeCruiseOn = SeamothInfo.safeCruiseOn;
					if (safeCruiseOn)
					{
						bool cruiseControlOn = SeamothInfo.CruiseControlOn;
						if (cruiseControlOn)
						{
							bool flag2 = ManageAllGUIElements.CcGrayUIGameObject != null;
							if (flag2)
							{
								ManageAllGUIElements.CcGrayUIGameObject.SetActive(false);
							}
							bool flag3 = ManageAllGUIElements.CcOnUIGameObject != null;
							if (flag3)
							{
								ManageAllGUIElements.CcOnUIGameObject.SetActive(false);
							}
							bool flag4 = ManageAllGUIElements.CcOffUIGameObject != null;
							if (flag4)
							{
								ManageAllGUIElements.CcOffUIGameObject.SetActive(false);
							}
							bool flag5 = ManageAllGUIElements.CcArrow01UIGameObject != null;
							if (flag5)
							{
								ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
							}
							bool flag6 = ManageAllGUIElements.CcActiveUIGameObject == null;
							if (flag6)
							{
								ManageAllGUIElements.CcActiveUIGameObject = PrepareGUIObjects.PrepareGUIObject("CcActiveUI", GearInfo.cc_Position);
							}
							bool flag7 = ManageAllGUIElements.CcActiveUIGameObject != null;
							if (flag7)
							{
								ManageAllGUIElements.CcActiveUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CcActiveUIGameObject, "safety_cruise_active_100x100", GearInfo.cc_Position, GearInfo.cc_Size);
							}
							bool flag8 = ManageAllGUIElements.CcActiveUIGameObject != null;
							if (flag8)
							{
								ManageAllGUIElements.CcActiveUIGameObject.SetActive(true);
							}
							float num = 2f;
							SeamothInfo.CcTimer += Time.deltaTime;
							int num2 = (int)SeamothInfo.CcTimer;
							int num3 = num2;
							if (num3 != 1)
							{
								bool flag9 = ManageAllGUIElements.CcArrow01UIGameObject == null;
								if (flag9)
								{
									ManageAllGUIElements.CcArrow01UIGameObject = PrepareGUIObjects.PrepareGUIObject("CcArrow01UI", GearInfo.cc_Position);
								}
								bool flag10 = ManageAllGUIElements.CcArrow01UIGameObject != null;
								if (flag10)
								{
									ManageAllGUIElements.CcArrow01UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CcArrow01UIGameObject, "cruise_arrow_01", GearInfo.cc_Position, GearInfo.cc_Size);
								}
								bool flag11 = ManageAllGUIElements.CcArrow01UIGameObject != null;
								if (flag11)
								{
									ManageAllGUIElements.CcArrow01UIGameObject.SetActive(true);
								}
							}
							else
							{
								bool flag12 = ManageAllGUIElements.CcArrow01UIGameObject != null;
								if (flag12)
								{
									ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
								}
							}
							bool flag13 = SeamothInfo.CcTimer >= num;
							if (flag13)
							{
								SeamothInfo.CcTimer = 0f;
							}
						}
						else
						{
							SeamothInfo.CcTimer = 0f;
							bool flag14 = ManageAllGUIElements.CcGrayUIGameObject != null;
							if (flag14)
							{
								ManageAllGUIElements.CcGrayUIGameObject.SetActive(false);
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
							bool flag18 = ManageAllGUIElements.CcOnUIGameObject == null;
							if (flag18)
							{
								ManageAllGUIElements.CcOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("CcOnUI", GearInfo.cc_Position);
							}
							bool flag19 = ManageAllGUIElements.CcOnUIGameObject != null;
							if (flag19)
							{
								ManageAllGUIElements.CcOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CcOnUIGameObject, "safety_cruise_yes_100x100", GearInfo.cc_Position, GearInfo.cc_Size);
							}
							bool flag20 = ManageAllGUIElements.CcOnUIGameObject != null;
							if (flag20)
							{
								ManageAllGUIElements.CcOnUIGameObject.SetActive(true);
							}
						}
					}
					else
					{
						bool flag21 = ManageAllGUIElements.CcGrayUIGameObject != null;
						if (flag21)
						{
							ManageAllGUIElements.CcGrayUIGameObject.SetActive(false);
						}
						bool flag22 = ManageAllGUIElements.CcOnUIGameObject != null;
						if (flag22)
						{
							ManageAllGUIElements.CcOnUIGameObject.SetActive(false);
						}
						bool flag23 = ManageAllGUIElements.CcActiveUIGameObject != null;
						if (flag23)
						{
							ManageAllGUIElements.CcActiveUIGameObject.SetActive(false);
						}
						bool flag24 = ManageAllGUIElements.CcArrow01UIGameObject != null;
						if (flag24)
						{
							ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
						}
						bool flag25 = ManageAllGUIElements.CcOffUIGameObject == null;
						if (flag25)
						{
							ManageAllGUIElements.CcOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("CcOffUI", GearInfo.cc_Position);
						}
						bool flag26 = ManageAllGUIElements.CcOffUIGameObject != null;
						if (flag26)
						{
							ManageAllGUIElements.CcOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CcOffUIGameObject, "safety_cruise_no_100x100", GearInfo.cc_Position, GearInfo.cc_Size);
						}
						bool flag27 = ManageAllGUIElements.CcOffUIGameObject != null;
						if (flag27)
						{
							ManageAllGUIElements.CcOffUIGameObject.SetActive(true);
						}
					}
				}
				else
				{
					bool flag28 = ManageAllGUIElements.CcOnUIGameObject != null;
					if (flag28)
					{
						ManageAllGUIElements.CcOnUIGameObject.SetActive(false);
					}
					bool flag29 = ManageAllGUIElements.CcActiveUIGameObject != null;
					if (flag29)
					{
						ManageAllGUIElements.CcActiveUIGameObject.SetActive(false);
					}
					bool flag30 = ManageAllGUIElements.CcArrow01UIGameObject != null;
					if (flag30)
					{
						ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
					}
					bool flag31 = ManageAllGUIElements.CcOffUIGameObject != null;
					if (flag31)
					{
						ManageAllGUIElements.CcOffUIGameObject.SetActive(false);
					}
					bool flag32 = ManageAllGUIElements.CcGrayUIGameObject == null;
					if (flag32)
					{
						ManageAllGUIElements.CcGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("CcGrayUI", GearInfo.eject_Position);
					}
					bool flag33 = ManageAllGUIElements.CcGrayUIGameObject != null;
					if (flag33)
					{
						ManageAllGUIElements.CcGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CcGrayUIGameObject, "safety_cruise_gray_100x100", GearInfo.cc_Position, GearInfo.cc_Size);
					}
					bool flag34 = ManageAllGUIElements.CcGrayUIGameObject != null;
					if (flag34)
					{
						ManageAllGUIElements.CcGrayUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag35 = ManageAllGUIElements.CcGrayUIGameObject != null;
				if (flag35)
				{
					ManageAllGUIElements.CcGrayUIGameObject.SetActive(false);
				}
				bool flag36 = ManageAllGUIElements.CcOnUIGameObject != null;
				if (flag36)
				{
					ManageAllGUIElements.CcOnUIGameObject.SetActive(false);
				}
				bool flag37 = ManageAllGUIElements.CcActiveUIGameObject != null;
				if (flag37)
				{
					ManageAllGUIElements.CcActiveUIGameObject.SetActive(false);
				}
				bool flag38 = ManageAllGUIElements.CcArrow01UIGameObject != null;
				if (flag38)
				{
					ManageAllGUIElements.CcArrow01UIGameObject.SetActive(false);
				}
				bool flag39 = ManageAllGUIElements.CcOffUIGameObject != null;
				if (flag39)
				{
					ManageAllGUIElements.CcOffUIGameObject.SetActive(false);
				}
			}
		}
	}
}
