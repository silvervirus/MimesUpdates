using System;
using System.Text;
using HarmonyLib;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using SeamothEnhancementSystem.InGame;
using SeamothEnhancementSystem.ManageGUI;
using UnityEngine;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(SeaMoth))]
	[HarmonyPatch("Update")]
	internal class SeaMoth_Update_Patch
	{
		
		[HarmonyPostfix]
		public static void Postfix(SeaMoth __instance)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = "<color=yellow>";
			string text2 = "</color>";
			bool safeEjectActive = SeamothInfo.safeEjectActive;
			if (safeEjectActive)
			{
				stringBuilder.AppendFormat(text + "Safe eject active\n" + text2, Array.Empty<object>());
				stringBuilder.AppendFormat(text + "Cancel " + text2 + "(<color=#ADF8FFFF>{0}</color>)", Config.SafetyEjectAbortKeybindValue.ToString());
				HandReticle.main.SetTextRaw(HandReticle.TextType.Use,stringBuilder.ToString() + string.Empty);
				MonitorEjectAbortKey.MonitorEjectAbortKeyDown();
			}
			bool pilotingMode = __instance.GetPilotingMode();
			if (pilotingMode)
			{
				EnergyMixin component = __instance.GetComponent<EnergyMixin>();
				EnergyInterface component2 = component.GetComponent<EnergyInterface>();
				float num;
				float num2;
				component2.GetValues(out num, out num2);
				bool showKeyPromptToggleValue = Config.ShowKeyPromptToggleValue;
				if (showKeyPromptToggleValue)
				{
					bool flag = SeamothInfo.electricalModuleIn || SeamothInfo.electronicModuleIn || SeamothInfo.mechanicalModuleIn || SeamothInfo.safetyModuleIn;
					if (flag)
					{
						bool flag2 = !SeamothInfo.seamothLinkModuleIn && !Subtitles.main.IsVisible();
						if (flag2)
						{
							DisplayPrompts.DisplayNoLinkPrompts();
						}
					}
				}
				bool flag3 = SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn && !FPSInputModule.current.lockMovement && SeamothInfo.BatteryInSlot == 1;
				if (flag3)
				{
					bool flag4 = !SeamothInfo.safetyModuleIn || !SeamothInfo.safeDepthChargerOn;
					if (flag4)
					{
						MonitorGearKeys.MonitorGearKeysDown();
					}
					else
					{
						bool flag5 = SeamothInfo.safetyModuleIn && SeamothInfo.safeDepthChargerOn && num > SeamothInfo.safeDepthChargerGearVal;
						if (flag5)
						{
							MonitorGearKeys.MonitorGearKeysDown();
						}
					}
					bool flag6 = !Subtitles.main.IsVisible() && Config.ShowKeyPromptToggleValue && SeamothInfo.BatteryInSlot == 1 && !Player.main.GetPDA().isInUse;
					if (flag6)
					{
						DisplayPrompts.DisplayMechanicalPrompts();
					}
					bool safetyModuleIn = SeamothInfo.safetyModuleIn;
					if (safetyModuleIn)
					{
						MonitorEjectOnKey.MonitorEjectOnKeyDown();
					}
				}
				bool flag7 = !SeamothInfo.seamothLinkModuleIn && Config.SeamothGearValue != 4f;
				if (flag7)
				{
					Config.SeamothGearValue = 4f;
					PlayerPrefs.SetFloat("SeamothGearValueSlider", Config.SeamothGearValue);
				}
				bool flag8 = SeamothInfo.electronicModuleIn && SeamothInfo.seamothLinkModuleIn && !FPSInputModule.current.lockMovement && SeamothInfo.BatteryInSlot == 1;
				if (flag8)
				{
					MonitorCruiseKey.MonitorCruiseKeyDown();
					bool flag9 = num > SeamothInfo.TurboModeCutoff;
					if (flag9)
					{
						MonitorModeKey.MonitorModeKeyDown();
					}
					else
					{
						bool flag10 = !SeamothInfo.ModeGreenOn;
						if (flag10)
						{
							SeamothInfo.ModeGreenOn = true;
							SeamothInfo.ModeChanged = true;
						}
					}
					bool flag11 = SeamothInfo.ModeGreenOn && Config.SeamothGearValue == 6f;
					if (flag11)
					{
						Config.SeamothGearValue = 5f;
						PlayerPrefs.SetFloat("SeamothGearValueSlider", Config.SeamothGearValue);
					}
					MonitorHealthKey.MonitorHealthKeyDown();
					MonitorPowerKey.MonitorPowerKeyDown();
					bool safetyModuleIn2 = SeamothInfo.safetyModuleIn;
					if (safetyModuleIn2)
					{
						MonitorSafetyCruiseOnKey.MonitorSafetyCruiseOnKeyDown();
					}
					bool flag12 = !Subtitles.main.IsVisible() && Config.ShowKeyPromptToggleValue && !Player.main.GetPDA().isInUse;
					if (flag12)
					{
						DisplayPrompts.DisplayElectronicPrompts(num);
					}
				}
				bool flag13 = SeamothInfo.electricalModuleIn && SeamothInfo.seamothLinkModuleIn && !FPSInputModule.current.lockMovement;
				if (flag13)
				{
					MonitorReloadKey.MonitorReloadKeyDown(__instance);
					bool flag14 = SeamothInfo.BatteryInSlot == 1;
					if (flag14)
					{
						bool flag15 = !SeamothInfo.safetyModuleIn || !SeamothInfo.safeDepthChargerOn;
						if (flag15)
						{
							MonitorLightBeamKey.MonitorLightBeamKeyDown(__instance);
						}
						else
						{
							bool flag16 = SeamothInfo.safetyModuleIn && SeamothInfo.safeDepthChargerOn && num > SeamothInfo.safeDepthChargerGearVal;
							if (flag16)
							{
								MonitorLightBeamKey.MonitorLightBeamKeyDown(__instance);
							}
						}
						SeaglideMapControlFix.SeaglideMapControlLightFix(__instance);
						bool flag17 = Player.main != null && !Player.main.GetPDA().isInUse && !FPSInputModule.current.lockMovement;
						if (flag17)
						{
							bool flag18 = !Subtitles.main.IsVisible() && Config.ShowKeyPromptToggleValue;
							if (flag18)
							{
								DisplayPrompts.DisplayElectricalPrompts();
							}
							bool preventLightToggle = SeamothInfo.preventLightToggle;
							if (preventLightToggle)
							{
								SeamothInfo.preventLightToggle = false;
							}
						}
						bool safetyModuleIn3 = SeamothInfo.safetyModuleIn;
						if (safetyModuleIn3)
						{
							MonitorSafetyChargerOnKey.MonitorSafetyChargerOnKeyDown();
						}
					}
					else
					{
						bool flag19 = SeamothInfo.MainBatteryCount > 0;
						if (flag19)
						{
							DisplayPrompts.DisplayInsertBattery();
						}
						else
						{
							DisplayPrompts.DisplayNoBattery();
						}
					}
					bool flag20 = Player.main != null && FPSInputModule.current.lockMovement;
					if (flag20)
					{
						DisplayPrompts.DisplayBatteryPrompts();
					}
				}
				bool flag21 = !SeamothInfo.electricalModuleIn;
				if (flag21)
				{
					bool highBeamOn = Vehicle_Update_Patch.HighBeamOn;
					if (highBeamOn)
					{
						Vehicle_Update_Patch.HighBeamOn = false;
					}
				}
				MonitorBatteryCount.MonitorSeamothBatteryCount(__instance);
				ToggleLightBeam.ToggleLoHighBeam(__instance);
				bool flag22 = Config.ShowKeyPromptToggleValue && !Player.main.GetPDA().isInUse && !FPSInputModule.current.lockMovement;
				if (flag22)
				{
					bool flag23 = SeamothInfo.electricalModuleIn || SeamothInfo.electronicModuleIn || SeamothInfo.mechanicalModuleIn || SeamothInfo.safetyModuleIn;
					if (flag23)
					{
						bool flag24 = SeamothInfo.seamothLinkModuleIn && !Subtitles.main.IsVisible();
						if (flag24)
						{
							DisplayPrompts.DisplaySafetyPrompts();
						}
					}
				}
			}
		}
	}
}
