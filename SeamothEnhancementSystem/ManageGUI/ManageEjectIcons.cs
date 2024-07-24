using System;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000021 RID: 33
	internal class ManageEjectIcons
	{
		// Token: 0x0600009D RID: 157 RVA: 0x000079F8 File Offset: 0x00005BF8
		internal static void ManageEject()
		{
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
			{
				bool flag = SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn;
				if (flag)
				{
					bool safeEjectOn = SeamothInfo.safeEjectOn;
					if (safeEjectOn)
					{
						bool safeEjectActive = SeamothInfo.safeEjectActive;
						if (safeEjectActive)
						{
							bool flag2 = ManageAllGUIElements.EjectGrayUIGameObject != null;
							if (flag2)
							{
								ManageAllGUIElements.EjectGrayUIGameObject.SetActive(false);
							}
							bool flag3 = ManageAllGUIElements.EjectOnUIGameObject != null;
							if (flag3)
							{
								ManageAllGUIElements.EjectOnUIGameObject.SetActive(false);
							}
							bool flag4 = ManageAllGUIElements.EjectOffUIGameObject != null;
							if (flag4)
							{
								ManageAllGUIElements.EjectOffUIGameObject.SetActive(false);
							}
							bool flag5 = ManageAllGUIElements.EjectActiveUIGameObject == null;
							if (flag5)
							{
								ManageAllGUIElements.EjectActiveUIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectActiveUI", GearInfo.eject_Position);
							}
							bool flag6 = ManageAllGUIElements.EjectActiveUIGameObject != null;
							if (flag6)
							{
								ManageAllGUIElements.EjectActiveUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectActiveUIGameObject, "safety_eject_active_100x100", GearInfo.eject_Position, GearInfo.eject_Size);
							}
							bool flag7 = ManageAllGUIElements.EjectActiveUIGameObject != null;
							if (flag7)
							{
								ManageAllGUIElements.EjectActiveUIGameObject.SetActive(true);
							}
							float num = 4f;
							SeamothInfo.EjectTimer += Time.deltaTime;
							int num2 = (int)SeamothInfo.EjectTimer;
							int num3 = num2;
							if (num3 != 1)
							{
								if (num3 != 2)
								{
									bool flag8 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
									if (flag8)
									{
										ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
									}
									bool flag9 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
									if (flag9)
									{
										ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
									}
									bool flag10 = ManageAllGUIElements.EjectPilot03UIGameObject == null;
									if (flag10)
									{
										ManageAllGUIElements.EjectPilot03UIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectPilot03UI", GearInfo.eject_Position);
									}
									bool flag11 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
									if (flag11)
									{
										ManageAllGUIElements.EjectPilot03UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectPilot03UIGameObject, "eject_pilot_03", GearInfo.eject_Position, GearInfo.eject_Size);
									}
									bool flag12 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
									if (flag12)
									{
										ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(true);
									}
								}
								else
								{
									bool flag13 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
									if (flag13)
									{
										ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
									}
									bool flag14 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
									if (flag14)
									{
										ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
									}
									bool flag15 = ManageAllGUIElements.EjectPilot02UIGameObject == null;
									if (flag15)
									{
										ManageAllGUIElements.EjectPilot02UIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectPilot02UI", GearInfo.eject_Position);
									}
									bool flag16 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
									if (flag16)
									{
										ManageAllGUIElements.EjectPilot02UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectPilot02UIGameObject, "eject_pilot_02", GearInfo.eject_Position, GearInfo.eject_Size);
									}
									bool flag17 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
									if (flag17)
									{
										ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(true);
									}
								}
							}
							else
							{
								bool flag18 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
								if (flag18)
								{
									ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
								}
								bool flag19 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
								if (flag19)
								{
									ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
								}
								bool flag20 = ManageAllGUIElements.EjectPilot01UIGameObject == null;
								if (flag20)
								{
									ManageAllGUIElements.EjectPilot01UIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectPilot01UI", GearInfo.eject_Position);
								}
								bool flag21 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
								if (flag21)
								{
									ManageAllGUIElements.EjectPilot01UIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectPilot01UIGameObject, "eject_pilot_01", GearInfo.eject_Position, GearInfo.eject_Size);
								}
								bool flag22 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
								if (flag22)
								{
									ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(true);
								}
							}
							bool flag23 = SeamothInfo.EjectTimer >= num;
							if (flag23)
							{
								SeamothInfo.EjectTimer = 1f;
							}
						}
						else
						{
							SeamothInfo.EjectTimer = 1f;
							bool flag24 = ManageAllGUIElements.EjectGrayUIGameObject != null;
							if (flag24)
							{
								ManageAllGUIElements.EjectGrayUIGameObject.SetActive(false);
							}
							bool flag25 = ManageAllGUIElements.EjectActiveUIGameObject != null;
							if (flag25)
							{
								ManageAllGUIElements.EjectActiveUIGameObject.SetActive(false);
							}
							bool flag26 = ManageAllGUIElements.EjectOffUIGameObject != null;
							if (flag26)
							{
								ManageAllGUIElements.EjectOffUIGameObject.SetActive(false);
							}
							bool flag27 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
							if (flag27)
							{
								ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
							}
							bool flag28 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
							if (flag28)
							{
								ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
							}
							bool flag29 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
							if (flag29)
							{
								ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
							}
							bool flag30 = ManageAllGUIElements.EjectOnUIGameObject == null;
							if (flag30)
							{
								ManageAllGUIElements.EjectOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectOnUI", GearInfo.eject_Position);
							}
							bool flag31 = ManageAllGUIElements.EjectOnUIGameObject != null;
							if (flag31)
							{
								ManageAllGUIElements.EjectOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectOnUIGameObject, "safety_eject_yes_100x100", GearInfo.eject_Position, GearInfo.eject_Size);
							}
							bool flag32 = ManageAllGUIElements.EjectOnUIGameObject != null;
							if (flag32)
							{
								ManageAllGUIElements.EjectOnUIGameObject.SetActive(true);
							}
						}
					}
					else
					{
						bool flag33 = ManageAllGUIElements.EjectGrayUIGameObject != null;
						if (flag33)
						{
							ManageAllGUIElements.EjectGrayUIGameObject.SetActive(false);
						}
						bool flag34 = ManageAllGUIElements.EjectActiveUIGameObject != null;
						if (flag34)
						{
							ManageAllGUIElements.EjectActiveUIGameObject.SetActive(false);
						}
						bool flag35 = ManageAllGUIElements.EjectOnUIGameObject != null;
						if (flag35)
						{
							ManageAllGUIElements.EjectOnUIGameObject.SetActive(false);
						}
						bool flag36 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
						if (flag36)
						{
							ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
						}
						bool flag37 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
						if (flag37)
						{
							ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
						}
						bool flag38 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
						if (flag38)
						{
							ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
						}
						bool flag39 = ManageAllGUIElements.EjectOffUIGameObject == null;
						if (flag39)
						{
							ManageAllGUIElements.EjectOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectOffUI", GearInfo.eject_Position);
						}
						bool flag40 = ManageAllGUIElements.EjectOffUIGameObject != null;
						if (flag40)
						{
							ManageAllGUIElements.EjectOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectOffUIGameObject, "safety_eject_no_100x100", GearInfo.eject_Position, GearInfo.eject_Size);
						}
						bool flag41 = ManageAllGUIElements.EjectOffUIGameObject != null;
						if (flag41)
						{
							ManageAllGUIElements.EjectOffUIGameObject.SetActive(true);
						}
					}
				}
				else
				{
					bool flag42 = ManageAllGUIElements.EjectActiveUIGameObject != null;
					if (flag42)
					{
						ManageAllGUIElements.EjectActiveUIGameObject.SetActive(false);
					}
					bool flag43 = ManageAllGUIElements.EjectOnUIGameObject != null;
					if (flag43)
					{
						ManageAllGUIElements.EjectOnUIGameObject.SetActive(false);
					}
					bool flag44 = ManageAllGUIElements.EjectOffUIGameObject != null;
					if (flag44)
					{
						ManageAllGUIElements.EjectOffUIGameObject.SetActive(false);
					}
					bool flag45 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
					if (flag45)
					{
						ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
					}
					bool flag46 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
					if (flag46)
					{
						ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
					}
					bool flag47 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
					if (flag47)
					{
						ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
					}
					bool flag48 = ManageAllGUIElements.EjectGrayUIGameObject == null;
					if (flag48)
					{
						ManageAllGUIElements.EjectGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("EjectGrayUI", GearInfo.eject_Position);
					}
					bool flag49 = ManageAllGUIElements.EjectGrayUIGameObject != null;
					if (flag49)
					{
						ManageAllGUIElements.EjectGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EjectGrayUIGameObject, "safety_eject_gray_100x100", GearInfo.eject_Position, GearInfo.eject_Size);
					}
					bool flag50 = ManageAllGUIElements.EjectGrayUIGameObject != null;
					if (flag50)
					{
						ManageAllGUIElements.EjectGrayUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag51 = ManageAllGUIElements.EjectGrayUIGameObject != null;
				if (flag51)
				{
					ManageAllGUIElements.EjectGrayUIGameObject.SetActive(false);
				}
				bool flag52 = ManageAllGUIElements.EjectActiveUIGameObject != null;
				if (flag52)
				{
					ManageAllGUIElements.EjectActiveUIGameObject.SetActive(false);
				}
				bool flag53 = ManageAllGUIElements.EjectOnUIGameObject != null;
				if (flag53)
				{
					ManageAllGUIElements.EjectOnUIGameObject.SetActive(false);
				}
				bool flag54 = ManageAllGUIElements.EjectOffUIGameObject != null;
				if (flag54)
				{
					ManageAllGUIElements.EjectOffUIGameObject.SetActive(false);
				}
				bool flag55 = ManageAllGUIElements.EjectPilot01UIGameObject != null;
				if (flag55)
				{
					ManageAllGUIElements.EjectPilot01UIGameObject.SetActive(false);
				}
				bool flag56 = ManageAllGUIElements.EjectPilot02UIGameObject != null;
				if (flag56)
				{
					ManageAllGUIElements.EjectPilot02UIGameObject.SetActive(false);
				}
				bool flag57 = ManageAllGUIElements.EjectPilot03UIGameObject != null;
				if (flag57)
				{
					ManageAllGUIElements.EjectPilot03UIGameObject.SetActive(false);
				}
			}
		}
	}
}
