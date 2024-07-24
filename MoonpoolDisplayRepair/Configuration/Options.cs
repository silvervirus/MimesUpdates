using System;
using Nautilus.Options;
using Nautilus.Utility;
using UnityEngine;

namespace MoonpoolDisplayRepair.Configuration
{
	// Token: 0x0200000F RID: 15
	public class Options : ModOptions
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002DB0 File Offset: 0x00000FB0
		public Options()
			: base("Moonpool Display Info")
		{
            var SeamothLowerLimit = ModSliderOption.Create("seamothLowerLimitSlider", "Sub low % stats colour change @", 1f, 49f, Config.SeamothLowerLimitSliderValue);
			SeamothLowerLimit.OnChanged += Options_SeamothLowerLimitSliderChanged;
			AddItem(SeamothLowerLimit);
            var SeamothUpperLimit = ModSliderOption.Create("seamothUpperLimitSlider", "Sub high % stats colour change @", 51f, 100f, Config.SeamothUpperLimitSliderValue);
			SeamothUpperLimit.OnChanged += Options_SeamothUpperLimitSliderChanged;
			AddItem(SeamothUpperLimit);
			var repairDockedSlider = ModSliderOption.Create("repairDockedSubSlider", "Docked sub repair (units)", 0f, 25f, Config.RepairDockedSubSliderValue);
			repairDockedSlider.OnChanged += Options_RepairDockedSubSliderChanged;
			AddItem(repairDockedSlider);
            var rechargeDockedSub = ModSliderOption.Create("rechargeDockedSubSlider", "Docked sub recharge (units)", 0f, 25f, Config.RechargeDockedSubSliderValue);
			rechargeDockedSub.OnChanged += Options_RechargeDockedSubSliderChanged;
			AddItem(rechargeDockedSub);
            var showoxygen = ModToggleOption.Create("showOxygenToggle", "Show base oxygen level", Config.ShowOxygenToggleValue);
			showoxygen.OnChanged += Options_OxygenToggleChanged;
			AddItem(showoxygen);
			var Showhullinfo = ModToggleOption.Create("showHullInfoToggle", "Show base hull strength", Config.ShowHullInfoToggleValue);
            Showhullinfo.OnChanged += Options_ToggleChanged;
			AddItem(Showhullinfo);
			var hulllowerlimit = ModSliderOption.Create("hullLowerLimitSlider", "Hull low stats colour change @", 1f, 7f, Config.HullLowerLimitSliderValue);
            hulllowerlimit.OnChanged += Options_HullLowerLimitSliderChanged;
			AddItem(hulllowerlimit);
			var hullupperlimit = ModSliderOption.Create("hullUpperLimitSlider", "Hull high stats colour change @", 8f, 15f, Config.HullUpperLimitSliderValue);
			hullupperlimit.OnChanged += Options_HullUpperLimitSliderChanged;
			AddItem(hullupperlimit);
			var showwatertempinfo = ModToggleOption.Create("showWaterTempInfoToggle", "Show base water °C", Config.ShowWaterTempToggleValue);
			showwatertempinfo.OnChanged += Options_WaterTempToggleChanged;
			AddItem(showwatertempinfo);
			var templowerlimit = ModSliderOption.Create("tempLowerLimitSlider", "°C low stats colour change @", 0f, 40f, Config.TempLowerLimitSliderValue);
			templowerlimit.OnChanged += Options_TempLowerLimitSliderChanged;
			AddItem(templowerlimit);
			var tempupperlimit = ModSliderOption.Create("tempUpperLimitSlider", "°C high stats colour change @", 41f, 50f, Config.TempUpperLimitSliderValue);
            tempupperlimit.OnChanged += Options_TempUpperLimitSliderChanged;
			AddItem(tempupperlimit);
			var DisplayClockChoice = ModChoiceOption<string>.Create("displayClockChoice", "Show clock", new string[] { "12h (am/pm)", "24h", "Do Not Show" }, Config.ClockDisplayChoiceIndex);
			DisplayClockChoice.OnChanged += Options_ClockGameSystemChoiceChanged;
			AddItem(DisplayClockChoice);
			var DisplayClockGameSystem = ModChoiceOption<string>.Create("displayClockGameSystemChoice", "Game or system time", new string[] { "Game time", "System time" }, Config.ClockGameSystemChoiceIndex);
			DisplayClockGameSystem.OnChanged += Options_ClockGameSystemChoiceChanged;
			AddItem(DisplayClockGameSystem);
        }	

		// Token: 0x0600001D RID: 29 RVA: 0x00002EC4 File Offset: 0x000010C4
		public void Options_SeamothLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "seamothLowerLimitSlider";
			if (!flag)
			{
				Config.SeamothLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("SeamothLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002F10 File Offset: 0x00001110
		public void Options_SeamothUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "seamothUpperLimitSlider";
			if (!flag)
			{
				Config.SeamothUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("SeamothUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002F5C File Offset: 0x0000115C
		public void Options_RepairDockedSubSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "repairDockedSubSlider";
			if (!flag)
			{
				Config.RepairDockedSubSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("RepairDockedSubSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002FA8 File Offset: 0x000011A8
		public void Options_RechargeDockedSubSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "rechargeDockedSubSlider";
			if (!flag)
			{
				Config.RechargeDockedSubSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("RechargeDockedSubSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002FF4 File Offset: 0x000011F4
		public void Options_OxygenToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showOxygenToggle";
			if (!flag)
			{
				Config.ShowOxygenToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("SMLHelperShowOxygenToggle", e.Value);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003034 File Offset: 0x00001234
		public void Options_ToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showHullInfoToggle";
			if (!flag)
			{
				Config.ShowHullInfoToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("SMLHelperShowHullInfoToggle", e.Value);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003074 File Offset: 0x00001274
		public void Options_HullLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "hullLowerLimitSlider";
			if (!flag)
			{
				Config.HullLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HullLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000030C0 File Offset: 0x000012C0
		public void Options_HullUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "hullUpperLimitSlider";
			if (!flag)
			{
				Config.HullUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HullUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000310C File Offset: 0x0000130C
		public void Options_WaterTempToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showWaterTempInfoToggle";
			if (!flag)
			{
				Config.ShowWaterTempToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("SMLHelperShowWaterTempToggle", e.Value);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000314C File Offset: 0x0000134C
		public void Options_TempLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "tempLowerLimitSlider";
			if (!flag)
			{
				Config.TempLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("TempLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003198 File Offset: 0x00001398
		public void Options_TempUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "tempUpperLimitSlider";
			if (!flag)
			{
				Config.TempUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("TempUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000031E4 File Offset: 0x000013E4
		public void Options_DisplayClockChoiceChanged(object sender, ChoiceChangedEventArgs<string> e)
		{
			bool flag = e.Id != "displayClockChoice";
			if (!flag)
			{
				Config.ClockDisplayChoiceIndex = e.Index;
				PlayerPrefs.SetInt("ClockDisplayChoice", e.Index);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003224 File Offset: 0x00001424
		public void Options_ClockGameSystemChoiceChanged(object sender, ChoiceChangedEventArgs<string> e)
		{
			bool flag = e.Id != "displayClockGameSystemChoice";
			if (!flag)
			{
				Config.ClockGameSystemChoiceIndex = e.Index;
				PlayerPrefs.SetInt("ClockGameSystemChoice", e.Index);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003264 File Offset: 0x00001464
		public void BuildModOptions()
		{
			
		}
	}
}
