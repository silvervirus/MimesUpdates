using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200002A RID: 42
	internal class ManagePowerTxt
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000966C File Offset: 0x0000786C
		internal static void ManagePowerText()
		{
			bool flag = ManageAllGUIElements.PowerTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.PowerTextObject = PrepareGUIObjects.PrepareGUIObject("PowerTextUI", GearInfo.power_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.PowerTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.PowerTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.PowerTextObject, 2f, false, SeamothInfo.electronicModuleIn, Color.white, GearInfo.power_txt_Position, GearInfo.power_txt_Size);
			}
			GearInfo.powerDisplayText = ManageAllGUIElements.PowerTextObject.GetComponent<Text>();
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
				bool flag3 = Config.MarchThroughPowerValue == 1f;
				if (flag3)
				{
					GearInfo.powerDisplayText.text = text4 + "Power max units" + text3;
				}
				else
				{
					bool flag4 = Config.MarchThroughPowerValue == 2f;
					if (flag4)
					{
						GearInfo.powerDisplayText.text = text4 + "Power units" + text3;
					}
					else
					{
						GearInfo.powerDisplayText.text = text4 + "Power %" + text3;
					}
				}
				bool flag5 = ManageAllGUIElements.PowerTextObject != null;
				if (flag5)
				{
					ManageAllGUIElements.PowerTextObject.SetActive(true);
				}
			}
			else
			{
				bool flag6 = ManageAllGUIElements.PowerTextObject != null;
				if (flag6)
				{
					ManageAllGUIElements.PowerTextObject.SetActive(false);
				}
			}
		}
	}
}
