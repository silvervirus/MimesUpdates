using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000020 RID: 32
	internal class ManageCruiseTxt
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00007870 File Offset: 0x00005A70
		internal static void ManageCruiseText()
		{
			bool flag = SeamothInfo.CruiseControlOn && SeamothInfo.electronicModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag)
			{
				bool flag2 = ManageAllGUIElements.CruiseSetTextObject == null;
				if (flag2)
				{
					ManageAllGUIElements.CruiseSetTextObject = PrepareGUIObjects.PrepareGUIObject("CruiseSetTextUI", GearInfo.cruise_txt_Position);
				}
				bool flag3 = ManageAllGUIElements.CruiseSetTextObject != null;
				if (flag3)
				{
					ManageAllGUIElements.CruiseSetTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.CruiseSetTextObject, 1.5f, true, SeamothInfo.electronicModuleIn, Color.white, GearInfo.cruise_txt_Position, GearInfo.cruise_txt_Size);
				}
				GearInfo.cruiseDisplayText = ManageAllGUIElements.CruiseSetTextObject.GetComponent<Text>();
				bool flag4 = Config.SeamothGearValue == 5f;
				if (flag4)
				{
					GearInfo.cruiseDisplayText.text = GearInfo.colorYellow + Player.main.GetVehicle().forwardForce.ToString("F1") + GearInfo.colorEnd;
				}
				else
				{
					bool flag5 = Config.SeamothGearValue == 6f;
					if (flag5)
					{
						GearInfo.cruiseDisplayText.text = GearInfo.colorRed + Player.main.GetVehicle().forwardForce.ToString("F1") + GearInfo.colorEnd;
					}
					else
					{
						GearInfo.cruiseDisplayText.text = Player.main.GetVehicle().forwardForce.ToString("F1");
					}
				}
				bool flag6 = ManageAllGUIElements.CruiseSetTextObject != null;
				if (flag6)
				{
					ManageAllGUIElements.CruiseSetTextObject.SetActive(true);
				}
			}
			else
			{
				bool flag7 = ManageAllGUIElements.CruiseSetTextObject != null;
				if (flag7)
				{
					ManageAllGUIElements.CruiseSetTextObject.SetActive(false);
				}
			}
		}
	}
}
