using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using BetterHUDInfo.InGame;
using BetterHUDInfo.ManageGUI;
using HarmonyLib;
using UnityEngine;

namespace BetterHUDInfo.Patches
{
	// Token: 0x02000009 RID: 9
	[HarmonyPatch(typeof(uGUI_PowerIndicator))]
	[HarmonyPatch("UpdatePower")]
	internal class uGUI_PowerIndicator_UpdatePower_Patch
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002508 File Offset: 0x00000708
		[HarmonyPostfix]
		public static void Postfix(uGUI_PowerIndicator __instance)
		{
			int value = Traverse.Create(__instance).Field("cachedPower").GetValue<int>();
			int value2 = Traverse.Create(__instance).Field("cachedMaxPower").GetValue<int>();
			Player main = Player.main;
			bool flag = main != null;
			if (flag)
			{
				SubRoot currentSub = main.currentSub;
				StringBuilder stringBuilder = new StringBuilder();
				ModInfo.CheckChipStatus(main);
				bool chipInserted = ModInfo.ChipInserted;
				if (chipInserted)
				{
					ManageAllGUIElements.ManageAllUI();
				}
				else
				{
					ManageAllGUIElements.TurnUIOff();
				}
				bool flag2 = ModInfo.ChipInserted && Config.ShowMainTopToggleValue && Config.HUDDisplayChoiceIndex == 1;
				if (flag2)
				{
					ModInfo.MoveCompassDown = Mathf.Floor(Config.MoveCompassSliderValue);
				}
				else
				{
					bool playerInCyclopsCamera = ModInfo.PlayerInCyclopsCamera;
					if (playerInCyclopsCamera)
					{
						ModInfo.MoveCompassDown = Mathf.Floor(Config.MoveCompassSliderValue);
					}
					else
					{
						ModInfo.MoveCompassDown = ModInfo.CompassSteady;
					}
				}
				bool flag3 = main.IsInBase() && ModInfo.ChipInserted && !Player.main.GetPDA().isInUse;
				if (flag3)
				{
					PlayerInBase.ProcessInBase(__instance, value, value2, currentSub);
				}
				bool flag4 = !main.IsInside() && ModInfo.ChipInserted && !Player.main.GetPDA().isInUse;
				if (flag4)
				{
					PlayerOutside.ProcessOutside(__instance);
				}
				bool flag5 = ModInfo.PlayerInVehicle && ModInfo.ChipInserted && !Player.main.GetPDA().isInUse;
				if (flag5)
				{
					PlayerInVehicle.ProcessInVehicle(__instance);
				}
				bool flag6 = main.IsInSubmarine() && ModInfo.ChipInserted && !Player.main.GetPDA().isInUse;
				if (flag6)
				{
					PlayerInCyclops.ProcessInCyclops(__instance);
				}
			}
		}
	}
}
