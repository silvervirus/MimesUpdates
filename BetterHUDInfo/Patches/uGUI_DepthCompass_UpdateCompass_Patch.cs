using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using HarmonyLib;

namespace BetterHUDInfo.Patches
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(uGUI_DepthCompass))]
	[HarmonyPatch("UpdateCompass")]
	internal class uGUI_DepthCompass_UpdateCompass_Patch
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000022BC File Offset: 0x000004BC
		[HarmonyPostfix]
		public static void Postfix(uGUI_DepthCompass __instance)
		{
			bool flag = ModInfo.PlayerInCyclopsCamera && Config.ShowHullPowerTempToggleValue;
			if (flag)
			{
				Player main = Player.main;
				SubRoot currentSub = main.currentSub;
				CyclopsHelmHUDManager componentInChildren = currentSub.GetComponentInChildren<CyclopsHelmHUDManager>();
				int num = (int)componentInChildren.crushDamage.GetDepth();
				int num2 = (int)componentInChildren.crushDamage.crushDepth;
				__instance.compass.SetVisible(true);
				__instance.compass.direction = MainCamera.camera.transform.eulerAngles.y / 360f;
				__instance.submersibleDepth.enabled = true;
				__instance.submersibleDepth.text = num.ToString();
				__instance.submersibleDepthSuffix.enabled = true;
				__instance.submersibleCrushDepth.enabled = true;
				__instance.submersibleCrushDepth.text = num2.ToString();
				__instance.submersibleBackground.enabled = true;
			}
			else
			{
				bool playerInCyclopsCamera = ModInfo.PlayerInCyclopsCamera;
				if (playerInCyclopsCamera)
				{
					__instance.compass.SetVisible(false);
					__instance.submersibleDepth.enabled = false;
					__instance.submersibleDepthSuffix.enabled = false;
					__instance.submersibleCrushDepth.enabled = false;
					__instance.submersibleBackground.enabled = false;
				}
			}
		}
	}
}
