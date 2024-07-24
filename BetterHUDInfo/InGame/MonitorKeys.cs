using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using BetterHUDInfo.ManageGUI;
using Nautilus.Utility;
using UnityEngine;

namespace BetterHUDInfo.InGame
{
	// Token: 0x0200000C RID: 12
	internal class MonitorKeys
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000029E8 File Offset: 0x00000BE8
		public static void MonitorBiomeKeysDown()
		{
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.CapsLock) && KeyCodeUtils.GetKeyDown(Config.ControlsKeybindValue);
			if (flag)
			{
				bool showMainTopToggleValue = Config.ShowMainTopToggleValue;
				if (showMainTopToggleValue)
				{
					Config.ShowMainTopToggleValue = false;
					ManageHUD_ChangeTxt.ManageHUD_ChangeText("LOCATION\nOFF");
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
				else
				{
					Config.ShowMainTopToggleValue = true;
					ManageHUD_ChangeTxt.ManageHUD_ChangeText("LOCATION\nON");
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002A68 File Offset: 0x00000C68
		public static void MonitorTimeKeysDown()
		{
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(Config.ControlsKeybindValue);
			if (flag)
			{
				bool showClockOxyToggleValue = Config.ShowClockOxyToggleValue;
				if (showClockOxyToggleValue)
				{
					Config.ShowClockOxyToggleValue = false;
					ManageHUD_ChangeTxt.ManageHUD_ChangeText("TIME & OXYGEN\nOFF");
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
				else
				{
					Config.ShowClockOxyToggleValue = true;
					ManageHUD_ChangeTxt.ManageHUD_ChangeText("TIME & OXYGEN\nON");
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public static void MonitorHullKeysDown()
		{
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(Config.ControlsKeybindValue);
			if (flag)
			{
				bool showHullPowerTempToggleValue = Config.ShowHullPowerTempToggleValue;
				if (showHullPowerTempToggleValue)
				{
					Config.ShowHullPowerTempToggleValue = false;
					bool playerInCyclopsCamera = ModInfo.PlayerInCyclopsCamera;
					if (playerInCyclopsCamera)
					{
						ManageHUD_ChangeTxt.ManageHUD_ChangeText("COMPASS HULL POWER °C\nOFF");
					}
					else
					{
						bool playerInBaseCamera = ModInfo.PlayerInBaseCamera;
						if (playerInBaseCamera)
						{
							ManageHUD_ChangeTxt.ManageHUD_ChangeText("TEMPERATURE\nOFF");
						}
						else
						{
							ManageHUD_ChangeTxt.ManageHUD_ChangeText("EXTERNAL SCANNER\nOFF");
						}
					}
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
				else
				{
					Config.ShowHullPowerTempToggleValue = true;
					bool flag2 = ModInfo.PlayerInCyclopsCamera || ModInfo.PlayerInBaseCamera;
					if (flag2)
					{
						ManageHUD_ChangeTxt.ManageHUD_ChangeText("COMPASS HULL POWER °C\nON");
					}
					else
					{
						bool playerInBaseCamera2 = ModInfo.PlayerInBaseCamera;
						if (playerInBaseCamera2)
						{
							ManageHUD_ChangeTxt.ManageHUD_ChangeText("TEMPERATURE\nON");
						}
						else
						{
							ManageHUD_ChangeTxt.ManageHUD_ChangeText("EXTERNAL SCANNER\nSTANDBY");
						}
					}
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002BD0 File Offset: 0x00000DD0
		public static void MonitorScannerKeysDown()
		{
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.LeftAlt) && KeyCodeUtils.GetKeyDown(Config.ControlsKeybindValue);
			if (flag)
			{
				bool scannerIsOn = ModInfo.ScannerIsOn;
				if (scannerIsOn)
				{
					ModInfo.ScannerIsOn = false;
					Utils.PlayEnvSound(ModInfo.lightsOffSound, ModInfo.lightsOffSound.gameObject.transform.position, 20f);
					ManageHUD_ChangeTxt.ManageHUD_ChangeText("ACTIVE SCAN\nOFF");
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
				else
				{
					bool flag2 = Config.ShowHullPowerTempToggleValue && !Player.main.IsInside();
					if (flag2)
					{
						ModInfo.ScannerIsOn = true;
						Utils.PlayEnvSound(ModInfo.lightsOnSound, ModInfo.lightsOnSound.gameObject.transform.position, 20f);
						ManageHUD_ChangeTxt.ManageHUD_ChangeText("ACTIVE SCAN\nON");
						ModInfo.changeShowing = true;
						ModInfo.fadeTimer = 0f;
					}
					else
					{
						bool flag3 = Player.main.IsInside();
						if (flag3)
						{
							ManageHUD_ChangeTxt.ManageHUD_ChangeText("ACTIVE SCAN\nOUTSIDE USE ONLY");
							ModInfo.changeShowing = true;
							ModInfo.fadeTimer = 0f;
						}
						else
						{
							bool flag4 = !Config.ShowHullPowerTempToggleValue;
							if (flag4)
							{
								ManageHUD_ChangeTxt.ManageHUD_ChangeText("UNABLE TO COMPLY\nEXTERNAL SCANNER OFF");
								ModInfo.changeShowing = true;
								ModInfo.fadeTimer = 0f;
							}
						}
					}
				}
			}
			bool flag5 = !Config.ShowHullPowerTempToggleValue || Player.main.IsPiloting() || Player.main.IsInsideWalkable();
			if (flag5)
			{
				bool scannerIsOn2 = ModInfo.ScannerIsOn;
				if (scannerIsOn2)
				{
					ModInfo.ScannerIsOn = false;
					Utils.PlayEnvSound(ModInfo.lightsOffSound, ModInfo.lightsOffSound.gameObject.transform.position, 20f);
					ManageHUD_ChangeTxt.ManageHUD_ChangeText("ACTIVE SCAN\nOFF");
					ModInfo.changeShowing = true;
					ModInfo.fadeTimer = 0f;
				}
			}
		}
	}
}
