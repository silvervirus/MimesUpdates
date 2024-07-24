using System;
using System.Text;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000028 RID: 40
	internal class ManageMainSafetyDescTxt
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00009298 File Offset: 0x00007498
		internal static void ManageMainSafetyDescText()
		{
			bool flag = ManageAllGUIElements.MainSafetyDescTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.MainSafetyDescTextObject = PrepareGUIObjects.PrepareGUIObject("MainSafetyDescTextUI", GearInfo.safety_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.MainSafetyDescTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.MainSafetyDescTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.MainSafetyDescTextObject, 1.3f, true, true, Color.white, GearInfo.safety_txt_Position, GearInfo.safety_txt_Size);
			}
			GearInfo.safetyDisplayText = ManageAllGUIElements.MainSafetyDescTextObject.GetComponent<Text>();
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
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
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(text4);
				stringBuilder.Append("Safety");
				stringBuilder.Append('\n');
				int num = 0;
				bool safeDepthChargerOn = SeamothInfo.safeDepthChargerOn;
				if (safeDepthChargerOn)
				{
					num++;
				}
				bool safeCruiseOn = SeamothInfo.safeCruiseOn;
				if (safeCruiseOn)
				{
					num++;
				}
				bool safeEjectOn = SeamothInfo.safeEjectOn;
				if (safeEjectOn)
				{
					num++;
				}
				bool seamothLinkModuleIn2 = SeamothInfo.seamothLinkModuleIn;
				if (seamothLinkModuleIn2)
				{
					stringBuilder.Append(num.ToString() + "/3");
				}
				else
				{
					stringBuilder.Append("N/A");
				}
				stringBuilder.Append(text3);
				GearInfo.safetyDisplayText.text = stringBuilder.ToString();
				bool flag3 = ManageAllGUIElements.MainSafetyDescTextObject != null;
				if (flag3)
				{
					ManageAllGUIElements.MainSafetyDescTextObject.SetActive(true);
				}
			}
			else
			{
				bool flag4 = ManageAllGUIElements.MainSafetyDescTextObject != null;
				if (flag4)
				{
					ManageAllGUIElements.MainSafetyDescTextObject.SetActive(false);
				}
			}
		}
	}
}
