using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using HarmonyLib;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000021 RID: 33
	internal class ManageScannerTxt
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00006530 File Offset: 0x00004730
		internal static void ManageScannerText()
		{
			Player main = Player.main;
			HandReticle.IconType value = Traverse.Create(HandReticle.main).Field("iconType").GetValue<HandReticle.IconType>();
			Text component = ManageAllGUIElements.ScannerTextObject.GetComponent<Text>();
			bool flag = main != null && Config.ShowHullPowerTempToggleValue && !main.IsInside() && !Player.main.GetPDA().isInUse && value == HandReticle.IconType.Default && ModInfo.ScannerIsOn;
			if (flag)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
				bool flag2 = !ModInfo.StopAtZero && !ModInfo.ObjectLock;
				if (flag2)
				{
					stringBuilder.Append("SCANNING...");
				}
				bool flag3 = ModInfo.StopAtZero && !ModInfo.ObjectLock;
				if (flag3)
				{
					stringBuilder.Append("INITIATING TARGET LOCK...");
				}
				bool objectLock = ModInfo.ObjectLock;
				if (objectLock)
				{
					stringBuilder.Append("TARGET LOCK ACTIVE");
					stringBuilder.Append('\n');
					stringBuilder.Append(ModInfo.colorBlue);
					stringBuilder.Append(ModInfo.TargetName);
					stringBuilder.Append(ModInfo.colorEnd);
				}
				stringBuilder.Append("</size>");
				component.text = stringBuilder.ToString();
				ManageAllGUIElements.ScannerTextObject.SetActive(true);
			}
			else
			{
				component.text = "";
				ManageAllGUIElements.ScannerTextObject.SetActive(false);
			}
		}
	}
}
