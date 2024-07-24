using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200002B RID: 43
	internal class ManageSpeedTxt
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x000097C8 File Offset: 0x000079C8
		internal static void ManageSpeedText()
		{
			string text = "<color=grey>";
			string text2 = "</color>";
			bool flag = ManageAllGUIElements.SpeedNowTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.SpeedNowTextObject = PrepareGUIObjects.PrepareGUIObject("SpeedNowTextUI", GearInfo.speed_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.SpeedNowTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.SpeedNowTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.SpeedNowTextObject, 0.65f, true, SeamothInfo.mechanicalModuleIn, Color.white, GearInfo.speed_txt_Position, GearInfo.speed_txt_Size);
			}
			GearInfo.speedDisplayText = ManageAllGUIElements.SpeedNowTextObject.GetComponent<Text>();
			bool flag3 = SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag3)
			{
				bool showSpeedKmhToggleValue = Config.ShowSpeedKmhToggleValue;
				if (showSpeedKmhToggleValue)
				{
					GearInfo.speedDisplayText.text = Mathf.RoundToInt(Player.main.GetVehicle().useRigidbody.velocity.magnitude).ToString();
				}
				else
				{
					GearInfo.speedDisplayText.text = Mathf.RoundToInt(Player.main.GetVehicle().useRigidbody.velocity.magnitude / 1.852f).ToString();
				}
			}
			else
			{
				GearInfo.speedDisplayText.text = text + "-" + text2;
			}
			bool flag4 = ManageAllGUIElements.SpeedNowTextObject != null;
			if (flag4)
			{
				ManageAllGUIElements.SpeedNowTextObject.SetActive(true);
			}
		}
	}
}
