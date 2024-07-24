using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x0200001E RID: 30
	internal class ManageHUD_ControlTxt
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00005F3C File Offset: 0x0000413C
		internal static void ManageHUD_ControlText()
		{
			Player main = Player.main;
			Text component = ManageAllGUIElements.HUD_ControlTextObject.GetComponent<Text>();
			RectTransform component2 = component.GetComponent<RectTransform>();
			bool flag = component != null;
			if (flag)
			{
				bool flag2 = main.GetVehicle() is Exosuit;
				if (flag2)
				{
					component2.localPosition = ModInfo.HUD_ControlText_ExoPos;
				}
				else
				{
					component2.localPosition = ModInfo.HUD_ControlText_Position;
				}
				bool flag3 = main != null && !Player.main.GetPDA().isInUse && Config.ShowHUDControlHintsToggleValue;
				if (flag3)
				{
					StringBuilder stringBuilder = new StringBuilder();
					component.fontSize = Mathf.RoundToInt((ModInfo.FontPlus + Config.FontSizeSliderValue) / 2f);
					string text = "(<color=#ADF8FFFF>" + uGUI.GetDisplayTextForBinding(Config.ControlsKeybindValue.ToString()) + "</color>)";
					stringBuilder.Append(ModInfo.caps + text + "   ");
					stringBuilder.Append(ModInfo.shift + text + "   ");
					stringBuilder.Append(ModInfo.ctrl + text + "    ");
					stringBuilder.Append(ModInfo.alt + text);
					component.text = stringBuilder.ToString();
					ManageAllGUIElements.HUD_ControlTextObject.SetActive(true);
				}
				else
				{
					component.text = "";
					ManageAllGUIElements.HUD_ControlTextObject.SetActive(false);
				}
			}
		}
	}
}
