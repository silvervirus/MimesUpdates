using System;
using System.Text;
using HarmonyLib;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using SeamothEnhancementSystem.Patches;
using UnityEngine;
using static HandReticle;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000030 RID: 48
	internal class DisplayPrompts
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00009C3C File Offset: 0x00007E3C
		public static void DisplayNoLinkPrompts()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			stringBuilder.Append(DisplayPrompts.colorRed + "No Seamoth link chip" + DisplayPrompts.colorEnd);
			stringBuilder.Append('\n');
			stringBuilder.Append(value);
			string text = stringBuilder.ToString();
            HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text + value2);
        }

		// Token: 0x060000BB RID: 187 RVA: 0x00009CC4 File Offset: 0x00007EC4
		public static void DisplaySafetyPrompts()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
			{
				stringBuilder.Append("Safety");
				bool electricalModuleIn = SeamothInfo.electricalModuleIn;
				if (electricalModuleIn)
				{
					bool safeDepthChargerOn = SeamothInfo.safeDepthChargerOn;
					if (safeDepthChargerOn)
					{
						stringBuilder.Append(" Charger ");
					}
					else
					{
						stringBuilder.Append(DisplayPrompts.colorRed + " Charger " + DisplayPrompts.colorEnd);
					}
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.SafetyChargerOnKeybindValue.ToString());
				}
				bool electronicModuleIn = SeamothInfo.electronicModuleIn;
				if (electronicModuleIn)
				{
					bool safeCruiseOn = SeamothInfo.safeCruiseOn;
					if (safeCruiseOn)
					{
						stringBuilder.Append(" Cruise ");
					}
					else
					{
						stringBuilder.Append(DisplayPrompts.colorRed + " Cruise " + DisplayPrompts.colorEnd);
					}
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.SafetyCruiseOnKeybindValue.ToString());
				}
				bool mechanicalModuleIn = SeamothInfo.mechanicalModuleIn;
				if (mechanicalModuleIn)
				{
					bool safeEjectOn = SeamothInfo.safeEjectOn;
					if (safeEjectOn)
					{
						stringBuilder.Append(" Exit ");
					}
					else
					{
						stringBuilder.Append(DisplayPrompts.colorRed + " Exit " + DisplayPrompts.colorEnd);
					}
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.SafetyEjectOnKeybindValue.ToString());
				}
			}
			stringBuilder.Append('\n');
			stringBuilder.Append(value2);
			string text = stringBuilder.ToString();
            HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value + text);

        }

		// Token: 0x060000BC RID: 188 RVA: 0x00009E64 File Offset: 0x00008064
		public static void DisplayElectricalPrompts()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			bool safeDepthChargerGearLightLock = SeamothInfo.safeDepthChargerGearLightLock;
			if (safeDepthChargerGearLightLock)
			{
				stringBuilder.Append(DisplayPrompts.colorRed + "Lights safety lock" + DisplayPrompts.colorEnd);
			}
			else
			{
				bool flag = !Vehicle_Update_Patch.LightsAreOn;
				if (flag)
				{
					stringBuilder.Append("Lights on ");
					string displayTextForBinding = uGUI.GetDisplayTextForBinding("MouseButtonRight");
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", displayTextForBinding);
				}
				else
				{
					bool highBeamOn = Vehicle_Update_Patch.HighBeamOn;
					if (highBeamOn)
					{
						stringBuilder.Append("Light Lo ");
					}
					else
					{
						stringBuilder.Append("Light Hi ");
					}
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.LightsLoHiKeybindValue.ToString());
					stringBuilder.Append(" off ");
					string displayTextForBinding2 = uGUI.GetDisplayTextForBinding("MouseButtonRight");
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", displayTextForBinding2);
				}
			}
			stringBuilder.Append(" Battery ");
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", uGUI.GetDisplayTextForBinding("R"));
			stringBuilder.Append('\n');
			stringBuilder.Append(value2);
			string text = stringBuilder.ToString();
            HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value + text);
			

        }

		// Token: 0x060000BD RID: 189 RVA: 0x00009FC4 File Offset: 0x000081C4
		public static void DisplayInsertBattery()
		{
			bool showKeyPromptToggleValue = Config.ShowKeyPromptToggleValue;
			if (showKeyPromptToggleValue)
			{
				StringBuilder stringBuilder = new StringBuilder();
				string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
				string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
				stringBuilder.Append(DisplayPrompts.colorRed + "Insert main battery " + DisplayPrompts.colorEnd);
				stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", uGUI.GetDisplayTextForBinding("R"));
				stringBuilder.Append('\n');
				stringBuilder.Append(value);
				string text = stringBuilder.ToString();
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use,  text + value2);
            }
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000A074 File Offset: 0x00008274
		public static void DisplayNoBattery()
		{
			bool showKeyPromptToggleValue = Config.ShowKeyPromptToggleValue;
			if (showKeyPromptToggleValue)
			{
				StringBuilder stringBuilder = new StringBuilder();
				string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
				string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
				stringBuilder.Append(DisplayPrompts.colorRed + "No battery" + DisplayPrompts.colorEnd);
				stringBuilder.Append('\n');
				stringBuilder.Append(value);
				string text = stringBuilder.ToString();
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text + value2);
            }
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000A10C File Offset: 0x0000830C
		public static void DisplayBatteryPrompts()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} ", Language.main.Get("ItemSelectorPrevious"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>) ", uGUI.GetDisplayTextForBinding("MouseWheelDown"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>) ", KeyCode.S);
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", KeyCode.A);
			stringBuilder.AppendFormat(", {0} ", Language.main.Get("ItemSelectorNext"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>) ", uGUI.GetDisplayTextForBinding("MouseWheelUp"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>) ", KeyCode.W);
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", KeyCode.D);
			stringBuilder.AppendFormat("\n{0} ", Language.main.Get("ItelSelectorSelect"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", uGUI.GetDisplayTextForBinding("MouseButtonLeft"));
			stringBuilder.AppendFormat(", {0} ", Language.main.Get("ItemSelectorCancel"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>) ", uGUI.GetDisplayTextForBinding("MouseButtonRight"));
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>) ", KeyCode.E);
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", KeyCode.Escape);
			HandReticle.main.SetTextRaw(HandReticle.TextType.Use,"" + stringBuilder.ToString());
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000A270 File Offset: 0x00008470
		public static void DisplayElectronicPrompts(float thisCharge)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			stringBuilder.Append(" Cruise ");
			bool cruiseControlOn = SeamothInfo.CruiseControlOn;
			if (cruiseControlOn)
			{
				stringBuilder.Append(DisplayPrompts.colorYellow + "off " + DisplayPrompts.colorEnd);
			}
			else
			{
				stringBuilder.Append("on ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.CruiseKeybindValue.ToString());
			bool flag = thisCharge > SeamothInfo.TurboModeCutoff;
			if (flag)
			{
				bool modeGreenOn = SeamothInfo.ModeGreenOn;
				if (modeGreenOn)
				{
					stringBuilder.Append(" Turbo mode ");
				}
				else
				{
					stringBuilder.Append(" Green mode ");
				}
				stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.ModeKeybindValue.ToString());
			}
			else
			{
				stringBuilder.Append(DisplayPrompts.colorRed + " Turbo offline " + DisplayPrompts.colorEnd);
			}
			stringBuilder.Append('\n');
			stringBuilder.Append("Cycle health ");
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.HealthKeybindValue.ToString());
			stringBuilder.Append(" power ");
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.PowerKeybindValue.ToString());
			stringBuilder.Append('\n');
			stringBuilder.Append(value2);
			string text = stringBuilder.ToString();
            HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value + text);
        }

		// Token: 0x060000C1 RID: 193 RVA: 0x0000A400 File Offset: 0x00008600
		public static void DisplayMechanicalPrompts()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			bool flag = SeamothInfo.ModeGreenOn && Config.SeamothGearValue == 5f;
			float num;
			if (flag)
			{
				num = 6f;
			}
			else
			{
				num = Config.SeamothGearValue;
			}
			bool safeDepthChargerGearLightLock = SeamothInfo.safeDepthChargerGearLightLock;
			if (safeDepthChargerGearLightLock)
			{
				stringBuilder.Append(DisplayPrompts.colorRed + "Gear safety lock" + DisplayPrompts.colorEnd);
			}
			else
			{
				float num2 = num;
				float num3 = num2;
				if (num3 != 1f)
				{
					if (num3 != 6f)
					{
						stringBuilder.Append("Gear up ");
						stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.GearUpKeybindValue.ToString());
						stringBuilder.Append(" down ");
						stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.GearDownKeybindValue.ToString());
					}
					else
					{
						stringBuilder.Append("Gear down ");
						stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.GearDownKeybindValue.ToString());
					}
				}
				else
				{
					stringBuilder.Append("Gear up ");
					stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.GearUpKeybindValue.ToString());
				}
			}
			stringBuilder.Append('\n');
			stringBuilder.Append(value2);
			string text = stringBuilder.ToString();
            HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value+ text);
		}

		// Token: 0x040000B4 RID: 180
		public static string colorGrey = "<color=grey>";

		// Token: 0x040000B5 RID: 181
		public static string colorYellow = "<color=yellow>";

		// Token: 0x040000B6 RID: 182
		public static string colorRed = "<color=red>";

		// Token: 0x040000B7 RID: 183
		public static string colorEnd = "</color>";

        
    }
}
