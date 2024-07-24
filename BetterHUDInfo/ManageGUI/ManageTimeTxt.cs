using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.Helpers;
using BetterHUDInfo.InfoObjects;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000022 RID: 34
	internal class ManageTimeTxt
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000066B0 File Offset: 0x000048B0
		internal static void ManageTimeText()
		{
			Player main = Player.main;
			bool flag = main != null && Config.ShowClockOxyToggleValue;
			if (flag)
			{
				DayNightCycle main2 = DayNightCycle.main;
				bool flag2 = ModInfo.ChipInserted && !main.GetPDA().isInUse;
				if (flag2)
				{
					ModInfo.timeDisplayText = ManageAllGUIElements.TimeTextObject.GetComponent<Text>();
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
					ModInfo.timeDisplayText.text = text + TimeState.GetTime().ToString() + ModInfo.colorEnd;
					bool flag4 = main.IsPiloting();
					float num;
					float num2;
					if (flag4)
					{
						num = ModInfo.HUDTimeOxyTxt_H - ModInfo.HUDTimeOxyTxtPilot_H;
						num2 = ModInfo.HUDTimeOxyTxt_V - ModInfo.HUDTimeOxyTxtPilot_V;
					}
					else
					{
						num = ModInfo.HUDTimeOxyTxt_H;
						num2 = ModInfo.HUDTimeOxyTxt_V;
					}
					MoveGUI.MoveGUIElement(ManageAllGUIElements.TimeTextObject, num, num2 - ModInfo.MoveCompassDown);
					ManageAllGUIElements.TimeTextObject.SetActive(true);
				}
				else
				{
					ManageAllGUIElements.TimeTextObject.SetActive(false);
				}
			}
			else
			{
				ManageAllGUIElements.TimeTextObject.SetActive(false);
			}
		}
	}
}
