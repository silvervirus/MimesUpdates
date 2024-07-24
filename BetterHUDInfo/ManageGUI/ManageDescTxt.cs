using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x0200001D RID: 29
	internal class ManageDescTxt
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00005CE4 File Offset: 0x00003EE4
		internal static void ManageControlsDescText(GameObject thisDescTextObject)
		{
			bool flag = ModInfo.ChipInserted && !Player.main.GetPDA().isInUse;
			if (flag)
			{
				Player main = Player.main;
				Text component = thisDescTextObject.GetComponent<Text>();
				RectTransform component2 = component.GetComponent<RectTransform>();
				bool flag2 = main.GetVehicle() is Exosuit;
				if (flag2)
				{
					component2.localPosition = ModInfo.HUD_ControlDescExoText_Position;
				}
				else
				{
					component2.localPosition = ModInfo.HUD_ControlDescText_Position;
				}
				Text component3 = thisDescTextObject.GetComponent<Text>();
				component3.fontSize = Mathf.RoundToInt((ModInfo.FontPlus + Config.FontSizeSliderValue) / 2f);
				component3.text = ModInfo.colorWhite + "Enhanced HUD controls" + ModInfo.colorEnd;
				thisDescTextObject.SetActive(true);
			}
			else
			{
				thisDescTextObject.SetActive(false);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005DB0 File Offset: 0x00003FB0
		internal static void ManageDescText(GameObject thisDescTextObject)
		{
			Player main = Player.main;
			bool flag = main != null;
			if (flag)
			{
				bool flag2 = Config.ShowHullPowerTempToggleValue && ModInfo.PlayerIsFree && !Player.main.GetPDA().isInUse;
				if (flag2)
				{
					Text component = thisDescTextObject.GetComponent<Text>();
					component.fontSize = Mathf.RoundToInt((ModInfo.FontPlus + Config.FontSizeSliderValue) / 2f);
					bool flag3 = (!main.IsInside() && ModInfo.ObjectLock && ModInfo.ScannerIsOn) || (main.IsInside() && !main.IsPiloting());
					if (flag3)
					{
						bool flag4 = thisDescTextObject == ManageAllGUIElements.HullDescTextObject;
						if (flag4)
						{
							component.text = ModInfo.colorWhite + "Hull" + ModInfo.colorEnd;
						}
						bool flag5 = thisDescTextObject == ManageAllGUIElements.PowerDescTextObject;
						if (flag5)
						{
							component.text = ModInfo.colorWhite + "Charge" + ModInfo.colorEnd;
						}
						thisDescTextObject.SetActive(true);
					}
					else
					{
						thisDescTextObject.SetActive(false);
					}
					bool flag6 = thisDescTextObject == ManageAllGUIElements.TemperDescTextObject;
					if (flag6)
					{
						bool flag7 = main.IsUnderwater();
						if (flag7)
						{
							component.text = ModInfo.colorWhite + "Water temp" + ModInfo.colorEnd;
						}
						else
						{
							component.text = ModInfo.colorWhite + "Air temp" + ModInfo.colorEnd;
						}
						thisDescTextObject.SetActive(true);
					}
				}
				else
				{
					thisDescTextObject.SetActive(false);
				}
			}
		}
	}
}
