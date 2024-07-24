using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000024 RID: 36
	internal class ManageHealthTxt
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00008630 File Offset: 0x00006830
		internal static void ManageHealthText()
		{
			bool flag = ManageAllGUIElements.HealthTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.HealthTextObject = PrepareGUIObjects.PrepareGUIObject("HealthTextUI", GearInfo.health_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.HealthTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.HealthTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.HealthTextObject, 2f, false, SeamothInfo.electronicModuleIn, Color.white, GearInfo.health_txt_Position, GearInfo.health_txt_Size);
			}
			GearInfo.healthDisplayText = ManageAllGUIElements.HealthTextObject.GetComponent<Text>();
			bool electronicModuleIn = SeamothInfo.electronicModuleIn;
			if (electronicModuleIn)
			{
				string text = "<color=white>";
				string text2 = "<color=grey>";
				string text3 = "</color>";
				bool seamothLinkModuleIn = SeamothInfo.seamothLinkModuleIn;
				string text4;
				if (seamothLinkModuleIn)
				{
					text4 = text;
				}
				else
				{
					text4 = text2;
				}
				bool flag3 = Config.MarchThroughHealthValue == 1f;
				if (flag3)
				{
					GearInfo.healthDisplayText.text = text4 + "Health max units" + text3;
				}
				else
				{
					bool flag4 = Config.MarchThroughHealthValue == 2f;
					if (flag4)
					{
						GearInfo.healthDisplayText.text = text4 + "Health units" + text3;
					}
					else
					{
						GearInfo.healthDisplayText.text = text4 + "Health %" + text3;
					}
				}
				bool flag5 = ManageAllGUIElements.HealthTextObject != null;
				if (flag5)
				{
					ManageAllGUIElements.HealthTextObject.SetActive(true);
				}
			}
			else
			{
				bool flag6 = ManageAllGUIElements.HealthTextObject != null;
				if (flag6)
				{
					ManageAllGUIElements.HealthTextObject.SetActive(false);
				}
			}
		}
	}
}
