using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;
using BetterHUDInfo.InfoObjects;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x0200001F RID: 31
	internal class ManageOxyTxt
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000060B8 File Offset: 0x000042B8
		internal static void ManageOxyText()
		{
			Player main = Player.main;
			bool flag = main != null && Config.ShowClockOxyToggleValue;
			if (flag)
			{
				bool flag2 = ModInfo.ChipInserted && !main.GetPDA().isInUse;
				if (flag2)
				{
					ModInfo.oxyDisplayText = ManageAllGUIElements.OxyTextObject.GetComponent<Text>();
					bool flag3 = Config.SoftenHUDColourOutsideToggleValue && (!main.IsInside() || main.IsPiloting());
					string text;
					if (flag3)
					{
						text = AdjustColours.SoftenColours();
					}
					else
					{
						text = ModInfo.colorWhite;
					}
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
					stringBuilder.Append(text);
					bool flag4 = main.IsUnderwater();
					if (flag4)
					{
						stringBuilder.Append("Under H<size=");
						stringBuilder.Append((Config.FontSizeSliderValue / 2f).ToString());
						stringBuilder.Append(">2</size>0 ");
					}
					else
					{
						stringBuilder.Append("Air O<size=");
						stringBuilder.Append((Config.FontSizeSliderValue / 2f).ToString());
						stringBuilder.Append(">2</size>: ");
						stringBuilder.Append(OxygenState.GetOxygen());
					}
					stringBuilder.Append(ModInfo.colorEnd);
					stringBuilder.Append("</size>");
					ModInfo.oxyDisplayText.text = stringBuilder.ToString();
					bool flag5 = main.IsPiloting();
					float num;
					float num2;
					if (flag5)
					{
						num = ModInfo.HUDTimeOxyTxt_H - ModInfo.HUDTimeOxyTxtPilot_H;
						num2 = ModInfo.HUDTimeOxyTxt_V - ModInfo.HUDTimeOxyTxtPilot_V;
					}
					else
					{
						num = ModInfo.HUDTimeOxyTxt_H;
						num2 = ModInfo.HUDTimeOxyTxt_V;
					}
					MoveGUI.MoveGUIElement(ManageAllGUIElements.OxyTextObject, -1f * num, num2 - ModInfo.MoveCompassDown);
					ManageAllGUIElements.OxyTextObject.SetActive(true);
				}
				else
				{
					ManageAllGUIElements.OxyTextObject.SetActive(false);
				}
			}
			else
			{
				ManageAllGUIElements.OxyTextObject.SetActive(false);
			}
		}
	}
}
