using System;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000012 RID: 18
	internal class ManageFadeChangeTxt
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003B3C File Offset: 0x00001D3C
		public static void ManageFadeChangeText()
		{
			ModInfo.fadeTimer += Time.deltaTime;
			bool flag = ModInfo.fadeTimer > ModInfo.fadeTimerStop;
			if (flag)
			{
				ManageAllGUIElements.HUD_ChangeTextObject.GetComponent<Text>().CrossFadeAlpha(0f, 1f, false);
				ModInfo.changeShowing = false;
				ModInfo.fadeTimer = 0f;
			}
		}
	}
}
