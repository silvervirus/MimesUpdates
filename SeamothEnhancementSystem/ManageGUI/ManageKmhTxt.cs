using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000025 RID: 37
	internal class ManageKmhTxt
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x0000878C File Offset: 0x0000698C
		internal static void ManageKmhText()
		{
			bool flag = ManageAllGUIElements.KmhTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.KmhTextObject = PrepareGUIObjects.PrepareGUIObject("KmhTextUI", GearInfo.kmh_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.KmhTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.KmhTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.KmhTextObject, 1.5f, true, SeamothInfo.mechanicalModuleIn, Color.yellow, GearInfo.kmh_txt_Position, GearInfo.kmh_txt_Size);
			}
			GearInfo.kmhDisplayText = ManageAllGUIElements.KmhTextObject.GetComponent<Text>();
			string text = "<color=white>";
			string text2 = "<color=grey>";
			string text3 = "</color>";
			bool flag3 = SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn;
			string text4;
			if (flag3)
			{
				text4 = text;
			}
			else
			{
				text4 = text2;
			}
			bool showSpeedKmhToggleValue = Config.ShowSpeedKmhToggleValue;
			if (showSpeedKmhToggleValue)
			{
				GearInfo.kmhDisplayText.text = text4 + "km/h" + text3;
			}
			else
			{
				GearInfo.kmhDisplayText.text = text4 + "nm/h" + text3;
			}
			bool flag4 = ManageAllGUIElements.KmhTextObject != null;
			if (flag4)
			{
				ManageAllGUIElements.KmhTextObject.SetActive(true);
			}
		}
	}
}
