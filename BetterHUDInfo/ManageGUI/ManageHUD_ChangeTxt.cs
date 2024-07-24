using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000019 RID: 25
	internal class ManageHUD_ChangeTxt
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00005740 File Offset: 0x00003940
		internal static void ManageHUD_ChangeText(string thisChangeString)
		{
			Player main = Player.main;
			bool flag = ManageAllGUIElements.HUD_ChangeTextObject != null;
			if (flag)
			{
				Text component = ManageAllGUIElements.HUD_ChangeTextObject.GetComponent<Text>();
				bool flag2 = main != null && !Player.main.GetPDA().isInUse;
				if (flag2)
				{
					ManageAllGUIElements.HUD_ChangeTextObject.SetActive(true);
					component.CrossFadeAlpha(1f, 0f, false);
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
					stringBuilder.Append(ModInfo.colorBlue);
					stringBuilder.Append(thisChangeString);
					stringBuilder.Append(ModInfo.colorEnd);
					stringBuilder.Append("</size>");
					component.text = stringBuilder.ToString();
				}
				else
				{
					component.text = "";
					ManageAllGUIElements.HUD_ChangeTextObject.SetActive(false);
				}
			}
		}
	}
}
