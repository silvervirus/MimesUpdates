using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000023 RID: 35
	internal class ManageGearTxt
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0000854C File Offset: 0x0000674C
		internal static void ManageGearText()
		{
			string text = "<color=grey>";
			string text2 = "</color>";
			bool flag = ManageAllGUIElements.GearTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.GearTextObject = PrepareGUIObjects.PrepareGUIObject("GearTextUI", GearInfo.gear_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.GearTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.GearTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.GearTextObject, 1.5f, true, SeamothInfo.mechanicalModuleIn, Color.white, GearInfo.gear_txt_Position, GearInfo.gear_txt_Size);
			}
			GearInfo.gearDisplayText = ManageAllGUIElements.GearTextObject.GetComponent<Text>();
			bool flag3 = SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn;
			string text3;
			if (flag3)
			{
				text3 = Config.SeamothGearValue.ToString();
			}
			else
			{
				text3 = text + Config.SeamothGearValue.ToString() + text2;
			}
			GearInfo.gearDisplayText.text = text3;
			bool flag4 = ManageAllGUIElements.GearTextObject != null;
			if (flag4)
			{
				ManageAllGUIElements.GearTextObject.SetActive(true);
			}
		}
	}
}
