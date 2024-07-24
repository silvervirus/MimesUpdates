using System;
using BetterHUDInfo.InfoObjects;
using BetterHUDInfo.InGame;
using HarmonyLib;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x02000002 RID: 2
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Update")]
	internal class Player_Update_Patch
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			bool flag = __instance != null;
			if (flag)
			{
				SubRoot currentSub = __instance.currentSub;
				bool flag2 = !__instance.IsPiloting();
				if (flag2)
				{
					ModInfo.PlayerIsFree = true;
				}
				else
				{
					ModInfo.PlayerIsFree = false;
				}
				bool flag3 = __instance.inSeamoth || __instance.inExosuit;
				if (flag3)
				{
					ModInfo.PlayerInVehicle = true;
				}
				else
				{
					ModInfo.PlayerInVehicle = false;
				}
				bool flag4 = __instance.IsInSubmarine();
				if (flag4)
				{
					bool flag5 = !__instance.IsPiloting();
					if (flag5)
					{
						ModInfo.PlayerInCyclopsFree = true;
					}
					else
					{
						ModInfo.PlayerInCyclopsFree = false;
						CyclopsExternalCams componentInChildren = currentSub.GetComponentInChildren<CyclopsExternalCams>();
						bool usingCameras = componentInChildren.GetActive();
						bool flag6 = usingCameras;
						if (flag6)
						{
							ModInfo.PlayerInCyclopsCamera = true;
							ModInfo.PlayerInCyclopsPiloting = false;
						}
						else
						{
							ModInfo.PlayerInCyclopsCamera = false;
							ModInfo.PlayerInCyclopsPiloting = true;
						}
					}
				}
				else
				{
					ModInfo.PlayerInCyclopsFree = false;
					ModInfo.PlayerInCyclopsPiloting = false;
					ModInfo.PlayerInCyclopsCamera = false;
				}
				bool flag7 = __instance.IsInBase();
				if (flag7)
				{
					bool flag8 = !__instance.IsPiloting();
					if (flag8)
					{
						ModInfo.PlayerInBaseFree = true;
						ModInfo.PlayerInBaseCamera = false;
					}
					else
					{
						ModInfo.PlayerInBaseFree = false;
						ModInfo.PlayerInBaseCamera = true;
					}
				}
				else
				{
					ModInfo.PlayerInBaseFree = false;
					ModInfo.PlayerInBaseCamera = false;
				}
				bool chipInserted = ModInfo.ChipInserted;
				if (chipInserted)
				{
					MonitorKeys.MonitorBiomeKeysDown();
					MonitorKeys.MonitorTimeKeysDown();
					MonitorKeys.MonitorHullKeysDown();
					MonitorKeys.MonitorScannerKeysDown();
				}
			}
		}
	}
}
