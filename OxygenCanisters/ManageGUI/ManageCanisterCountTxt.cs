using System;
using OxygenCanisters.Helpers;
using OxygenCanisters.Info;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x0200000B RID: 11
	internal class ManageCanisterCountTxt
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002E20 File Offset: 0x00001020
		internal static void ManageCanisterCountText()
		{
			bool flag = ManageAllGUIElements.CanisterCountTextObject == null;
			if (flag)
			{
				ManageAllGUIElements.CanisterCountTextObject = PrepareGUIObjects.PrepareGUIObject("CanisterCountTextUI", ModInfo.count_txt_Position);
			}
			bool flag2 = ManageAllGUIElements.CanisterCountTextObject != null;
			if (flag2)
			{
				ManageAllGUIElements.CanisterCountTextObject = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.CanisterCountTextObject, ModInfo.fontSize, true, Color.white, new Vector3(ModInfo.canisterX, ModInfo.canisterY, 0f), ModInfo.count_txt_Size);
			}
			ModInfo.countDisplayText = ManageAllGUIElements.CanisterCountTextObject.GetComponent<Text>();
			ModInfo.countDisplayText.text = CheckConditions.OxygenCanisterInInventory().ToString();
			bool flag3 = ManageAllGUIElements.CanisterCountTextObject != null;
			if (flag3)
			{
				ManageAllGUIElements.CanisterCountTextObject.SetActive(true);
			}
		}
	}
}
