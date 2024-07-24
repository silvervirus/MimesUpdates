using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x0200001A RID: 26
	internal class ManageHUD_ControlImg
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00005844 File Offset: 0x00003A44
		internal static void ManageHUD_Control(GameObject HUD_ControlObj, float this_x, float this_y, bool itemOn)
		{
			Player main = Player.main;
			bool flag = main != null;
			if (flag)
			{
				bool flag2 = ModInfo.ChipInserted && !main.GetPDA().isInUse;
				if (flag2)
				{
					Image component = HUD_ControlObj.GetComponent<Image>();
					RectTransform component2 = component.GetComponent<RectTransform>();
					bool flag3 = HUD_ControlObj == ManageAllGUIElements.BackControlUIGameObj;
					if (flag3)
					{
						bool flag4 = main.GetVehicle() is Exosuit;
						if (flag4)
						{
							component2.localPosition = new Vector3(this_x, this_y - 6f, 0f);
						}
						else
						{
							component2.localPosition = new Vector3(this_x, this_y, 0f);
						}
					}
					else
					{
						bool showHUDControlHintsToggleValue = Config.ShowHUDControlHintsToggleValue;
						if (showHUDControlHintsToggleValue)
						{
							bool flag5 = main.GetVehicle() is Exosuit;
							if (flag5)
							{
								component2.localPosition = new Vector3(this_x, this_y - 6f, 0f);
							}
							else
							{
								component2.localPosition = new Vector3(this_x, this_y, 0f);
							}
						}
						else
						{
							bool flag6 = main.GetVehicle() is Exosuit;
							if (flag6)
							{
								component2.localPosition = new Vector3(this_x, this_y - 16f, 0f);
							}
							else
							{
								component2.localPosition = new Vector3(this_x, this_y - 10f, 0f);
							}
						}
					}
					if (itemOn)
					{
						HUD_ControlObj.SetActive(true);
					}
					else
					{
						HUD_ControlObj.SetActive(false);
					}
				}
				else
				{
					HUD_ControlObj.SetActive(false);
				}
			}
		}
	}
}
