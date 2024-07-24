using System;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200002C RID: 44
	internal class ManageTemperTxt
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00009920 File Offset: 0x00007B20
		internal static void ManageTemperText()
		{
			bool flag = ManageAllGUIElements.TemperTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.TemperTextObject = PrepareGUIObjects.PrepareGUIObject("TemperTextUI", GearInfo.temper_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.TemperTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.TemperTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TemperTextObject, 2f, false, SeamothInfo.electronicModuleIn, Color.white, GearInfo.temper_txt_Position, GearInfo.temper_txt_Size);
			}
			GearInfo.temperDisplayText = ManageAllGUIElements.TemperTextObject.GetComponent<Text>();
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
				GearInfo.temperDisplayText.text = text4 + "Water temp" + text3;
				bool flag3 = ManageAllGUIElements.TemperTextObject != null;
				if (flag3)
				{
					ManageAllGUIElements.TemperTextObject.SetActive(true);
				}
			}
			else
			{
				bool flag4 = ManageAllGUIElements.TemperTextObject != null;
				if (flag4)
				{
					ManageAllGUIElements.TemperTextObject.SetActive(false);
				}
			}
		}
	}
}
