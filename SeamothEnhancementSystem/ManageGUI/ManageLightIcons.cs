using System;
using SeamothEnhancementSystem.InfoObjects;
using SeamothEnhancementSystem.Patches;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000026 RID: 38
	internal class ManageLightIcons
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00008890 File Offset: 0x00006A90
		internal static void ManageLights()
		{
			bool flag = SeamothInfo.electricalModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag)
			{
				Vehicle vehicle = Player.main.GetVehicle() as SeaMoth;
				ToggleLights componentInChildren = vehicle.GetComponentInChildren<ToggleLights>();
				bool flag2 = false;
				bool flag3 = componentInChildren != null;
				if (flag3)
				{
					flag2 = componentInChildren.GetLightsActive();
				}
				bool flag4 = !flag2;
				if (flag4)
				{
					bool safeDepthChargerGearLightLock = SeamothInfo.safeDepthChargerGearLightLock;
					if (safeDepthChargerGearLightLock)
					{
						bool flag5 = ManageAllGUIElements.LightGrayUIGameObject != null;
						if (flag5)
						{
							ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
						}
						bool flag6 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
						if (flag6)
						{
							ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(false);
						}
						bool flag7 = ManageAllGUIElements.LightLowOffUIGameObject != null;
						if (flag7)
						{
							ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
						}
						bool flag8 = ManageAllGUIElements.LightLowOnUIGameObject != null;
						if (flag8)
						{
							ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
						}
						bool flag9 = ManageAllGUIElements.LightHighOffUIGameObject != null;
						if (flag9)
						{
							ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
						}
						bool flag10 = ManageAllGUIElements.LightHighOnUIGameObject != null;
						if (flag10)
						{
							ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
						}
						bool flag11 = ManageAllGUIElements.LightSafetyOffUIGameObject == null;
						if (flag11)
						{
							ManageAllGUIElements.LightSafetyOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightSafetyOffUI", GearInfo.light_Position);
						}
						bool flag12 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
						if (flag12)
						{
							ManageAllGUIElements.LightSafetyOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightSafetyOffUIGameObject, "light_safety_off_100x100", GearInfo.light_Position, GearInfo.light_Size);
						}
						bool flag13 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
						if (flag13)
						{
							ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(true);
						}
					}
					else
					{
						bool flag14 = !Vehicle_Update_Patch.HighBeamOn;
						if (flag14)
						{
							bool flag15 = ManageAllGUIElements.LightGrayUIGameObject != null;
							if (flag15)
							{
								ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
							}
							bool flag16 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
							if (flag16)
							{
								ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(false);
							}
							bool flag17 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
							if (flag17)
							{
								ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(false);
							}
							bool flag18 = ManageAllGUIElements.LightLowOnUIGameObject != null;
							if (flag18)
							{
								ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
							}
							bool flag19 = ManageAllGUIElements.LightHighOffUIGameObject != null;
							if (flag19)
							{
								ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
							}
							bool flag20 = ManageAllGUIElements.LightHighOnUIGameObject != null;
							if (flag20)
							{
								ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
							}
							bool flag21 = ManageAllGUIElements.LightLowOffUIGameObject == null;
							if (flag21)
							{
								ManageAllGUIElements.LightLowOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightLowOffUI", GearInfo.light_Position);
							}
							bool flag22 = ManageAllGUIElements.LightLowOffUIGameObject != null;
							if (flag22)
							{
								ManageAllGUIElements.LightLowOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightLowOffUIGameObject, "light_low_off_100x100", GearInfo.light_Position, GearInfo.light_Size);
							}
							bool flag23 = ManageAllGUIElements.LightLowOffUIGameObject != null;
							if (flag23)
							{
								ManageAllGUIElements.LightLowOffUIGameObject.SetActive(true);
							}
						}
						else
						{
							bool flag24 = ManageAllGUIElements.LightGrayUIGameObject != null;
							if (flag24)
							{
								ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
							}
							bool flag25 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
							if (flag25)
							{
								ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(false);
							}
							bool flag26 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
							if (flag26)
							{
								ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(false);
							}
							bool flag27 = ManageAllGUIElements.LightHighOnUIGameObject != null;
							if (flag27)
							{
								ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
							}
							bool flag28 = ManageAllGUIElements.LightLowOffUIGameObject != null;
							if (flag28)
							{
								ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
							}
							bool flag29 = ManageAllGUIElements.LightLowOnUIGameObject != null;
							if (flag29)
							{
								ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
							}
							bool flag30 = ManageAllGUIElements.LightHighOffUIGameObject == null;
							if (flag30)
							{
								ManageAllGUIElements.LightHighOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightHighOffUI", GearInfo.light_Position);
							}
							bool flag31 = ManageAllGUIElements.LightHighOffUIGameObject != null;
							if (flag31)
							{
								ManageAllGUIElements.LightHighOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightHighOffUIGameObject, "light_high_off_100x100", GearInfo.light_Position, GearInfo.light_Size);
							}
							bool flag32 = ManageAllGUIElements.LightHighOffUIGameObject != null;
							if (flag32)
							{
								ManageAllGUIElements.LightHighOffUIGameObject.SetActive(true);
							}
						}
					}
				}
				else
				{
					bool safeDepthChargerGearLightLock2 = SeamothInfo.safeDepthChargerGearLightLock;
					if (safeDepthChargerGearLightLock2)
					{
						bool flag33 = ManageAllGUIElements.LightGrayUIGameObject != null;
						if (flag33)
						{
							ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
						}
						bool flag34 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
						if (flag34)
						{
							ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(false);
						}
						bool flag35 = ManageAllGUIElements.LightLowOffUIGameObject != null;
						if (flag35)
						{
							ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
						}
						bool flag36 = ManageAllGUIElements.LightLowOnUIGameObject != null;
						if (flag36)
						{
							ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
						}
						bool flag37 = ManageAllGUIElements.LightHighOffUIGameObject != null;
						if (flag37)
						{
							ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
						}
						bool flag38 = ManageAllGUIElements.LightHighOnUIGameObject != null;
						if (flag38)
						{
							ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
						}
						bool flag39 = ManageAllGUIElements.LightSafetyOnUIGameObject == null;
						if (flag39)
						{
							ManageAllGUIElements.LightSafetyOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightSafetyOnUI", GearInfo.light_Position);
						}
						bool flag40 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
						if (flag40)
						{
							ManageAllGUIElements.LightSafetyOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightSafetyOnUIGameObject, "light_safety_on_100x100", GearInfo.light_Position, GearInfo.light_Size);
						}
						bool flag41 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
						if (flag41)
						{
							ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(true);
						}
					}
					else
					{
						bool flag42 = !Vehicle_Update_Patch.HighBeamOn;
						if (flag42)
						{
							bool flag43 = ManageAllGUIElements.LightGrayUIGameObject != null;
							if (flag43)
							{
								ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
							}
							bool flag44 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
							if (flag44)
							{
								ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(false);
							}
							bool flag45 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
							if (flag45)
							{
								ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(false);
							}
							bool flag46 = ManageAllGUIElements.LightHighOffUIGameObject != null;
							if (flag46)
							{
								ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
							}
							bool flag47 = ManageAllGUIElements.LightHighOnUIGameObject != null;
							if (flag47)
							{
								ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
							}
							bool flag48 = ManageAllGUIElements.LightLowOffUIGameObject != null;
							if (flag48)
							{
								ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
							}
							bool flag49 = ManageAllGUIElements.LightLowOnUIGameObject == null;
							if (flag49)
							{
								ManageAllGUIElements.LightLowOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightLowOnUI", GearInfo.light_Position);
							}
							bool flag50 = ManageAllGUIElements.LightLowOnUIGameObject != null;
							if (flag50)
							{
								ManageAllGUIElements.LightLowOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightLowOnUIGameObject, "light_low_on_100x100", GearInfo.light_Position, GearInfo.light_Size);
							}
							bool flag51 = ManageAllGUIElements.LightLowOnUIGameObject != null;
							if (flag51)
							{
								ManageAllGUIElements.LightLowOnUIGameObject.SetActive(true);
							}
						}
						else
						{
							bool flag52 = ManageAllGUIElements.LightGrayUIGameObject != null;
							if (flag52)
							{
								ManageAllGUIElements.LightGrayUIGameObject.SetActive(false);
							}
							bool flag53 = ManageAllGUIElements.LightSafetyOffUIGameObject != null;
							if (flag53)
							{
								ManageAllGUIElements.LightSafetyOffUIGameObject.SetActive(false);
							}
							bool flag54 = ManageAllGUIElements.LightSafetyOnUIGameObject != null;
							if (flag54)
							{
								ManageAllGUIElements.LightSafetyOnUIGameObject.SetActive(false);
							}
							bool flag55 = ManageAllGUIElements.LightLowOffUIGameObject != null;
							if (flag55)
							{
								ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
							}
							bool flag56 = ManageAllGUIElements.LightLowOnUIGameObject != null;
							if (flag56)
							{
								ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
							}
							bool flag57 = ManageAllGUIElements.LightHighOffUIGameObject != null;
							if (flag57)
							{
								ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
							}
							bool flag58 = ManageAllGUIElements.LightHighOnUIGameObject == null;
							if (flag58)
							{
								ManageAllGUIElements.LightHighOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightHighOnUI", GearInfo.light_Position);
							}
							bool flag59 = ManageAllGUIElements.LightHighOnUIGameObject != null;
							if (flag59)
							{
								ManageAllGUIElements.LightHighOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightHighOnUIGameObject, "light_high_on_100x100", GearInfo.light_Position, GearInfo.light_Size);
							}
							bool flag60 = ManageAllGUIElements.LightHighOnUIGameObject != null;
							if (flag60)
							{
								ManageAllGUIElements.LightHighOnUIGameObject.SetActive(true);
							}
						}
					}
				}
			}
			else
			{
				bool flag61 = ManageAllGUIElements.LightLowOnUIGameObject != null;
				if (flag61)
				{
					ManageAllGUIElements.LightLowOnUIGameObject.SetActive(false);
				}
				bool flag62 = ManageAllGUIElements.LightLowOffUIGameObject != null;
				if (flag62)
				{
					ManageAllGUIElements.LightLowOffUIGameObject.SetActive(false);
				}
				bool flag63 = ManageAllGUIElements.LightHighOffUIGameObject != null;
				if (flag63)
				{
					ManageAllGUIElements.LightHighOffUIGameObject.SetActive(false);
				}
				bool flag64 = ManageAllGUIElements.LightHighOnUIGameObject != null;
				if (flag64)
				{
					ManageAllGUIElements.LightHighOnUIGameObject.SetActive(false);
				}
				bool flag65 = ManageAllGUIElements.LightGrayUIGameObject == null;
				if (flag65)
				{
					ManageAllGUIElements.LightGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("LightGrayUI", GearInfo.light_Position);
				}
				bool flag66 = ManageAllGUIElements.LightGrayUIGameObject != null;
				if (flag66)
				{
					ManageAllGUIElements.LightGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.LightGrayUIGameObject, "light_gray_100x100", GearInfo.light_Position, GearInfo.light_Size);
				}
				bool flag67 = ManageAllGUIElements.LightGrayUIGameObject != null;
				if (flag67)
				{
					ManageAllGUIElements.LightGrayUIGameObject.SetActive(true);
				}
			}
		}
	}
}
