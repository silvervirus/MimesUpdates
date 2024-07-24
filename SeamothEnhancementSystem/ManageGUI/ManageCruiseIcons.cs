using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200001F RID: 31
	internal class ManageCruiseIcons
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00007630 File Offset: 0x00005830
		internal static void ManageCruiseControl()
		{
			bool flag = SeamothInfo.electronicModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag)
			{
				bool cruiseControlOn = SeamothInfo.CruiseControlOn;
				if (cruiseControlOn)
				{
					bool flag2 = ManageAllGUIElements.CruiseGrayUIGameObject != null;
					if (flag2)
					{
						ManageAllGUIElements.CruiseGrayUIGameObject.SetActive(false);
					}
					bool flag3 = ManageAllGUIElements.CruiseOffUIGameObject != null;
					if (flag3)
					{
						ManageAllGUIElements.CruiseOffUIGameObject.SetActive(false);
					}
					bool flag4 = ManageAllGUIElements.CruiseOnUIGameObject == null;
					if (flag4)
					{
						ManageAllGUIElements.CruiseOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("CruiseOnUI", GearInfo.cruise_Position);
					}
					bool flag5 = ManageAllGUIElements.CruiseOnUIGameObject != null;
					if (flag5)
					{
						ManageAllGUIElements.CruiseOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CruiseOnUIGameObject, "cruise_control_on_100x100", GearInfo.cruise_Position, GearInfo.cruise_Size);
					}
					bool flag6 = ManageAllGUIElements.CruiseOnUIGameObject != null;
					if (flag6)
					{
						ManageAllGUIElements.CruiseOnUIGameObject.SetActive(true);
					}
				}
				else
				{
					bool flag7 = ManageAllGUIElements.CruiseGrayUIGameObject != null;
					if (flag7)
					{
						ManageAllGUIElements.CruiseGrayUIGameObject.SetActive(false);
					}
					bool flag8 = ManageAllGUIElements.CruiseOnUIGameObject != null;
					if (flag8)
					{
						ManageAllGUIElements.CruiseOnUIGameObject.SetActive(false);
					}
					bool flag9 = ManageAllGUIElements.CruiseOffUIGameObject == null;
					if (flag9)
					{
						ManageAllGUIElements.CruiseOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("CruiseOffUI", GearInfo.cruise_Position);
					}
					bool flag10 = ManageAllGUIElements.CruiseOffUIGameObject != null;
					if (flag10)
					{
						ManageAllGUIElements.CruiseOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CruiseOffUIGameObject, "cruise_control_off_100x100", GearInfo.cruise_Position, GearInfo.cruise_Size);
					}
					bool flag11 = ManageAllGUIElements.CruiseOffUIGameObject != null;
					if (flag11)
					{
						ManageAllGUIElements.CruiseOffUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag12 = ManageAllGUIElements.CruiseOffUIGameObject != null;
				if (flag12)
				{
					ManageAllGUIElements.CruiseOffUIGameObject.SetActive(false);
				}
				bool flag13 = ManageAllGUIElements.CruiseOnUIGameObject != null;
				if (flag13)
				{
					ManageAllGUIElements.CruiseOnUIGameObject.SetActive(false);
				}
				bool flag14 = ManageAllGUIElements.CruiseGrayUIGameObject == null;
				if (flag14)
				{
					ManageAllGUIElements.CruiseGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("CruiseGrayUI", GearInfo.cruise_Position);
				}
				bool flag15 = ManageAllGUIElements.CruiseGrayUIGameObject != null;
				if (flag15)
				{
					ManageAllGUIElements.CruiseGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CruiseGrayUIGameObject, "cruise_control_gray_100x100", GearInfo.cruise_Position, GearInfo.cruise_Size);
				}
				bool flag16 = ManageAllGUIElements.CruiseGrayUIGameObject != null;
				if (flag16)
				{
					ManageAllGUIElements.CruiseGrayUIGameObject.SetActive(true);
				}
			}
		}
	}
}
