using System;
using SeamothEnhancementSystem.Configuration;
using Nautilus.Options;
using Nautilus.Options.Attributes;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.Options
{
	// Token: 0x0200000F RID: 15
	public class Options : ModOptions
	{
		
		public Options()
			: base("Seamoth Enhancement System")
		{
            
            var vehicleFontSize =ModSliderOption.Create("vehicleFontSizeSlider", "Font size (original font defult 39)", 10f, 40f, Config.VehicleFontSizeSliderValue);
            vehicleFontSize.OnChanged += this.Options_VehicleFontSizeSliderChanged;
			AddItem(vehicleFontSize);
            var ShowKeyPrompt = ModToggleOption.Create("showKeyPromptToggle", "Show key prompts", Config.ShowKeyPromptToggleValue);
            ShowKeyPrompt.OnChanged += this.Options_PromptToggleValueChanged;
			AddItem(ShowKeyPrompt);
            var ShowSpeedKmHToggle =ModToggleOption.Create("showSpeedKmhToggle", "Show speed in km/h", Config.ShowSpeedKmhToggleValue);
            ShowSpeedKmHToggle.OnChanged += this.Options_SpeedKmhToggleValueChanged;
			AddItem(ShowSpeedKmHToggle);
            var LightsLoHiKey = ModKeybindOption.Create("lightsLoHiKeybindPress", "Lights Lo/Hi key", GameInput.Device.Keyboard, Config.LightsLoHiKeybindValue);
            LightsLoHiKey.OnChanged += this.Options_LightsLoHiKeybindValueChanged;
			AddItem(LightsLoHiKey);
            var Crusiekey =ModKeybindOption.Create("cruiseKeybindPress", "Cruise Control key", GameInput.Device.Keyboard, Config.CruiseKeybindValue);
            Crusiekey.OnChanged += this.Options_CruiseKeybindValueChanged;
			AddItem(Crusiekey);
            var ModeKey =ModKeybindOption.Create("modeKeybindPress", "Green / Turbo mode key", GameInput.Device.Keyboard, Config.ModeKeybindValue);
            ModeKey.OnChanged += this.Options_ModeKeybindValueChanged;
			AddItem(ModeKey);
            var gearUpkey = ModKeybindOption.Create("gearUpKeybindPress", "Gear up key", GameInput.Device.Keyboard, Config.GearUpKeybindValue);
            gearUpkey.OnChanged += this.Options_GearUpKeybindValueChanged;
			AddItem(gearUpkey);
            var geardownkey =ModKeybindOption.Create("gearDownKeybindPress", "Gear down key", GameInput.Device.Keyboard, Config.GearDownKeybindValue);
            geardownkey.OnChanged += this.Options_GearDownKeybindValueChanged;
			AddItem(geardownkey);
            var healthkey= ModKeybindOption.Create("healthKeybindPress", "Health key", GameInput.Device.Keyboard, Config.HealthKeybindValue);
            healthkey.OnChanged += this.Options_HealthKeybindValueChanged;
			AddItem(healthkey);
            var powerkey = ModKeybindOption.Create("powerKeybindPress", "Power key", GameInput.Device.Keyboard, Config.PowerKeybindValue);
            powerkey.OnChanged += this.Options_PowerKeybindValueChanged;
			AddItem(powerkey);
            var safetychargeronkey =ModKeybindOption.Create("safetyChargerOnKeybindPress", "Safety charger on/off key", GameInput.Device.Keyboard, Config.SafetyChargerOnKeybindValue);
            safetychargeronkey.OnChanged += this.Options_SafetyChargerOnKeybindValueChanged;
			AddItem(safetychargeronkey);
            var safetycruiseonkey =ModKeybindOption.Create("safetyCruiseOnKeybindPress", "Safety cruise on/off key", GameInput.Device.Keyboard, Config.SafetyCruiseOnKeybindValue);
            safetycruiseonkey.OnChanged += this.Options_SafetyEjectOnKeybindValueChanged;
			AddItem(safetycruiseonkey);
            var safetyEjectOnkey= ModKeybindOption.Create("safetyEjectOnKeybindPress", "Safety eject on/off key", GameInput.Device.Keyboard, Config.SafetyEjectOnKeybindValue);
            safetyEjectOnkey.OnChanged += this.Options_SafetyEjectAbortKeybindValueChanged;
			AddItem(safetyEjectOnkey);
            var safetlyEjectAbortKey= ModKeybindOption.Create("safetyEjectAbortKeybindPress", "Safety eject abort key", GameInput.Device.Keyboard, Config.SafetyEjectAbortKeybindValue);
            safetlyEjectAbortKey.OnChanged += this.Options_SafetyCruiseOnKeybindValueChanged;
			AddItem(safetlyEjectAbortKey);
            var healthLowerlimit= ModSliderOption.Create("healthLowerLimitSlider", "Health low % stats colour change @", 1f, 49f, Config.HealthLowerLimitSliderValue);
            healthLowerlimit.OnChanged += this.Options_HealthLowerLimitSliderChanged;
			AddItem(healthLowerlimit);
            var healthupperlimit = ModSliderOption.Create("healthUpperLimitSlider", "Health high % stats colour change @", 51f, 100f, Config.HealthUpperLimitSliderValue);
            healthupperlimit.OnChanged += this.Options_HealthUpperLimitSliderChanged;
			AddItem(healthupperlimit);
            var powerlowerlimit =ModSliderOption.Create("powerLowerLimitSlider", "Power low % stats colour change @", 1f, 49f, Config.PowerLowerLimitSliderValue);
            powerlowerlimit.OnChanged += this.Options_PowerLowerLimitSliderChanged;
			AddItem(powerlowerlimit);
            var powerupperlimit= ModSliderOption.Create("powerUpperLimitSlider", "Power high % stats colour change @", 51f, 100f, Config.PowerUpperLimitSliderValue);
            powerupperlimit.OnChanged += this.Options_PowerUpperLimitSliderChanged;
			AddItem(powerupperlimit);
            var templowerlimit =ModSliderOption.Create("tempMothLowerLimitSlider", "°C low stats colour change @", 0f, 40f, Config.TempMothLowerLimitSliderValue);
            templowerlimit.OnChanged += this.Options_TempMothLowerLimitSliderChanged;
			AddItem(templowerlimit);
            var tempmothupperlimit= ModSliderOption.Create("tempMothUpperLimitSlider", "°C high stats colour change @", 41f, 50f, Config.TempMothUpperLimitSliderValue);
            tempmothupperlimit.OnChanged += this.Options_TempMothUpperLimitSliderChanged;
			AddItem(tempmothupperlimit);
        }

		// Token: 0x06000022 RID: 34 RVA: 0x0000401C File Offset: 0x0000221C
		public void Options_VehicleFontSizeSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "vehicleFontSizeSlider";
			if (!flag)
			{
				Config.VehicleFontSizeSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("VehicleFontSizeSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004068 File Offset: 0x00002268
		public void Options_PromptToggleValueChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showKeyPromptToggle";
			if (!flag)
			{
				Config.ShowKeyPromptToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowKeyPromptToggle", e.Value);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000040A8 File Offset: 0x000022A8
		public void Options_SpeedKmhToggleValueChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showSpeedKmhToggle";
			if (!flag)
			{
				Config.ShowSpeedKmhToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowSpeedKmhToggle", e.Value);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000040E8 File Offset: 0x000022E8
		public void Options_LightsLoHiKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "lightsLoHiKeybindPress";
			if (!flag)
			{
				Config.LightsLoHiKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("LightsLoHiKeybindPress", e.Value);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004128 File Offset: 0x00002328
		public void Options_CruiseKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "cruiseKeybindPress";
			if (!flag)
			{
				Config.CruiseKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("CruiseKeybindPress", e.Value);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004168 File Offset: 0x00002368
		public void Options_ModeKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "modeKeybindPress";
			if (!flag)
			{
				Config.ModeKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("ModeKeybindPress", e.Value);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000041A8 File Offset: 0x000023A8
		public void Options_GearUpKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "gearUpKeybindPress";
			if (!flag)
			{
				Config.GearUpKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("GearUpKeybindPress", e.Value);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000041E8 File Offset: 0x000023E8
		public void Options_GearDownKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "gearDownKeybindPress";
			if (!flag)
			{
				Config.GearDownKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("GearDownKeybindPress", e.Value);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004228 File Offset: 0x00002428
		public void Options_HealthKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "healthKeybindPress";
			if (!flag)
			{
				Config.HealthKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("HealthKeybindPress", e.Value);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004268 File Offset: 0x00002468
		public void Options_PowerKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "powerKeybindPress";
			if (!flag)
			{
				Config.PowerKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("PowerKeybindPress", e.Value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000042A8 File Offset: 0x000024A8
		public void Options_SafetyChargerOnKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "safetyChargerOnKeybindPress";
			if (!flag)
			{
				Config.SafetyChargerOnKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("SafetyChargerOnKeybindPress", e.Value);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000042E8 File Offset: 0x000024E8
		public void Options_SafetyEjectOnKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "safetyEjectOnKeybindPress";
			if (!flag)
			{
				Config.SafetyEjectOnKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("SafetyEjectOnKeybindPress", e.Value);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004328 File Offset: 0x00002528
		public void Options_SafetyEjectAbortKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "safetyEjectAbortKeybindPress";
			if (!flag)
			{
				Config.SafetyEjectAbortKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("SafetyEjectAbortKeybindPress", e.Value);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004368 File Offset: 0x00002568
		public void Options_SafetyCruiseOnKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "safetyCruiseOnKeybindPress";
			if (!flag)
			{
				Config.SafetyCruiseOnKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("SafetyCruiseOnKeybindPress", e.Value);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000043A8 File Offset: 0x000025A8
		public void Options_HealthLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "healthLowerLimitSlider";
			if (!flag)
			{
				Config.HealthLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HealthLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000043F4 File Offset: 0x000025F4
		public void Options_HealthUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "healthUpperLimitSlider";
			if (!flag)
			{
				Config.HealthUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HealthUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004440 File Offset: 0x00002640
		public void Options_PowerLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "powerLowerLimitSlider";
			if (!flag)
			{
				Config.PowerLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("PowerLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000448C File Offset: 0x0000268C
		public void Options_PowerUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "powerUpperLimitSlider";
			if (!flag)
			{
				Config.PowerUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("PowerUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000044D8 File Offset: 0x000026D8
		public void Options_TempMothLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "tempMothLowerLimitSlider";
			if (!flag)
			{
				Config.TempMothLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("TempMothLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004524 File Offset: 0x00002724
		public void Options_TempMothUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "tempMothUpperLimitSlider";
			if (!flag)
			{
				Config.TempMothUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("TempMothUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		
		
	}
}
