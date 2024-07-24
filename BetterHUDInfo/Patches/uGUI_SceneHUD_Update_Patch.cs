using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using HarmonyLib;
using UnityEngine;

namespace BetterHUDInfo.Patches
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(uGUI_SceneHUD))]
	[HarmonyPatch("Update")]
	internal class uGUI_SceneHUD_Update_Patch
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002400 File Offset: 0x00000600
		[HarmonyPostfix]
		private static void Postfix(uGUI_SceneHUD __instance)
		{
			Transform transform = __instance.transform.Find("Content");
			bool flag = transform != null;
			if (flag)
			{
				RectTransform rectTransform = transform.Find("DepthCompass") as RectTransform;
				bool flag2 = rectTransform != null;
				if (flag2)
				{
					bool playerInCyclopsCamera = ModInfo.PlayerInCyclopsCamera;
					if (playerInCyclopsCamera)
					{
						rectTransform.anchoredPosition = new Vector2(0f, -60f - ModInfo.MoveCompassDown);
					}
					else
					{
						bool flag3 = Config.HUDDisplayChoiceIndex == 1;
						if (flag3)
						{
							rectTransform.anchoredPosition = new Vector2(0f, -30f - ModInfo.MoveCompassDown);
						}
						else
						{
							rectTransform.anchoredPosition = new Vector2(0f, -30f);
						}
					}
				}
			}
		}
	}
}
