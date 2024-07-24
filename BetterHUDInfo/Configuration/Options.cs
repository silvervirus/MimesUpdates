using System;
using BetterHUDInfo.InfoObjects;
using Nautilus.Options;
using Nautilus.Utility;
using UnityEngine;

namespace BetterHUDInfo.Configuration
{
	// Token: 0x02000031 RID: 49
	public class Options : ModOptions
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public Options()
			: base("Better HUD Info")
		{
            var controlsKey = ModKeybindOption.Create("controlsKeybindPress", "Main controls key", GameInput.Device.Keyboard, Config.ControlsKeybindValue);
            controlsKey.OnChanged += this.Options_ControlsKeybindValueChanged;
			AddItem(controlsKey);
            var fontsize = ModSliderOption.Create("fontSizeSlider", "Font size (game default is 30)", 10f, 35f, Config.FontSizeSliderValue);
            fontsize.OnChanged += this.Options_FontSizeSliderChanged;
			AddItem(fontsize);
            var ShowMainTop =ModToggleOption.Create("showMainTopToggle", "Main HUD display on", Config.ShowMainTopToggleValue);
            ShowMainTop.OnChanged += this.Options_MainTopToggleChanged;
			AddItem(ShowMainTop);
            var ShowBiome = ModToggleOption.Create("showBiomeToggle", ModInfo.colorBlue + "If main HUD on: " + ModInfo.colorEnd + "Show biome", Config.ShowBiomeToggleValue);
            ShowBiome.OnChanged += this.Options_BiomeToggleChanged;
			AddItem(ShowBiome);
            var ShowCoords = ModToggleOption.Create("showCoordsToggle", ModInfo.colorBlue + "If main HUD on: " + ModInfo.colorEnd + "Show coords", Config.ShowCoordsToggleValue);
            ShowCoords.OnChanged += this.Options_CoordsToggleChanged;
			AddItem(ShowCoords);
            var DisplayHud = ModChoiceOption<string>.Create("displayHUDChoice", "Main HUD display", new string[] { "All items 1 line", "All items 2 lines" }, Config.HUDDisplayChoiceIndex);
            DisplayHud.OnChanged += this.Options_HUDDisplayChoiceChanged;
			AddItem(DisplayHud);
            var CompassLimit = ModSliderOption.Create("compassLimitSlider", "Adjust compass (mod default = 30)", 10f, 40f, Config.MoveCompassSliderValue);
            CompassLimit.OnChanged += this.Options_MoveCompassSliderChanged;
			AddItem(CompassLimit);
            var SoftenHudColorOutside =ModToggleOption.Create("softenHUDColourOutsideToggle", "Soften HUD colour outside", Config.SoftenHUDColourOutsideToggleValue);
            SoftenHudColorOutside.OnChanged += this.Options_SoftenHUDColourOutsideToggleChanged;
			AddItem(SoftenHudColorOutside);
            var ShowClockOxy =ModToggleOption.Create("showClockOxyToggle", "Show time & oxygen HUD", Config.ShowClockOxyToggleValue);
            ShowClockOxy.OnChanged += this.Options_ClockOxyToggleChanged;
			AddItem(ShowClockOxy);
            var DisplayClock =ModChoiceOption<string>.Create("displayClockChoice", "12h / 24h", new string[] { "12h (am/pm)", "24h" }, Config.ClockDisplayChoiceIndex);
            DisplayClock.OnChanged += this.Options_DisplayClockChoiceChanged;
			AddItem(DisplayClock);
            var displayClockGameSystemChice = ModChoiceOption<string>.Create("displayClockGameSystemChoice", "Game or system time", new string[] { "Game time", "System time" }, Config.ClockGameSystemChoiceIndex);
            displayClockGameSystemChice.OnChanged += this.Options_ClockGameSystemChoiceChanged;
			AddItem(displayClockGameSystemChice);
            var ShowHullPowerTemp =ModToggleOption.Create("showHullPowerTempToggle", "Show hull, power, °C HUD", Config.ShowHullPowerTempToggleValue);
            ShowHullPowerTemp.OnChanged += this.Options_HullPowerTempToggleChanged;
			AddItem(ShowHullPowerTemp);
            var HulllowerLimit =ModSliderOption.Create("hullLowerLimitSlider", "Hull low stats colour change @", 1f, 7f, Config.HullLowerLimitSliderValue);
            HulllowerLimit.OnChanged += this.Options_HullLowerLimitSliderChanged;
			AddItem(HulllowerLimit);
            var HullUpperLimit =ModSliderOption.Create("hullUpperLimitSlider", "Hull high stats colour change @", 8f, 15f, Config.HullUpperLimitSliderValue);
            HullUpperLimit.OnChanged += this.Options_HullUpperLimitSliderChanged;
			AddItem(HullUpperLimit);
            var TempLowerLimit = ModSliderOption.Create("tempLowerLimitSlider", "°C low stats colour change @", 0f, 40f, Config.TempLowerLimitSliderValue);
            TempLowerLimit.OnChanged += this.Options_TempLowerLimitSliderChanged;
			AddItem(TempLowerLimit);
            var TempUpperLimit =ModSliderOption.Create("tempUpperLimitSlider", "°C high stats colour change @", 41f, 50f, Config.TempUpperLimitSliderValue);
            TempUpperLimit.OnChanged += this.Options_TempUpperLimitSliderChanged;
			AddItem(TempUpperLimit);
            var ShowLockBeam =ModToggleOption.Create("showLockBeamToggle", "Show external scanner beam", Config.ShowLockBeamToggleValue);
            ShowLockBeam.OnChanged += this.Options_LockBeamToggleChanged;
			AddItem(ShowLockBeam);
            var ShowHudControlHints=ModToggleOption.Create("showHUDControlHintsToggle", "Show HUD control key hints", Config.ShowHUDControlHintsToggleValue);
            ShowHudControlHints.OnChanged += this.Options_HUDControlHintsToggleChanged;


















        }

		// Token: 0x0600007A RID: 122 RVA: 0x00007E58 File Offset: 0x00006058
		public void Options_ControlsKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "controlsKeybindPress";
			if (!flag)
			{
				Config.ControlsKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("ControlsKeybindPress", e.Value);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007E98 File Offset: 0x00006098
		public void Options_FontSizeSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "fontSizeSlider";
			if (!flag)
			{
				Config.FontSizeSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("FontSizeSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007EE4 File Offset: 0x000060E4
		public void Options_MainTopToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showMainTopToggle";
			if (!flag)
			{
				Config.ShowMainTopToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowMainTopToggle", e.Value);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007F24 File Offset: 0x00006124
		public void Options_BiomeToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showBiomeToggle";
			if (!flag)
			{
				Config.ShowBiomeToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowBiomeToggle", e.Value);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007F64 File Offset: 0x00006164
		public void Options_CoordsToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showCoordsToggle";
			if (!flag)
			{
				Config.ShowCoordsToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowCoordsToggle", e.Value);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007FA4 File Offset: 0x000061A4
		public void Options_HUDDisplayChoiceChanged(object sender, ChoiceChangedEventArgs<string> e)
		{
			bool flag = e.Id != "displayHUDChoice";
			if (!flag)
			{
				Config.HUDDisplayChoiceIndex = e.Index;
				PlayerPrefs.SetInt("HUDDisplayChoice", e.Index);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007FE4 File Offset: 0x000061E4
		public void Options_MoveCompassSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "compassLimitSlider";
			if (!flag)
			{
				Config.MoveCompassSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HUDMoveCompassSlider", Mathf.Floor(e.Value));
				ModInfo.CompassIsAdjusted = false;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008034 File Offset: 0x00006234
		public void Options_SoftenHUDColourOutsideToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "softenHUDColourOutsideToggle";
			if (!flag)
			{
				Config.SoftenHUDColourOutsideToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("SoftenHUDColourOutsideToggle", e.Value);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008074 File Offset: 0x00006274
		public void Options_ClockOxyToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showClockOxyToggle";
			if (!flag)
			{
				Config.ShowClockOxyToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowClockOxyToggle", e.Value);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000080B4 File Offset: 0x000062B4
		public void Options_DisplayClockChoiceChanged(object sender, ChoiceChangedEventArgs<string> e)
		{
			bool flag = e.Id != "displayClockChoice";
			if (!flag)
			{
				Config.ClockDisplayChoiceIndex = e.Index;
				PlayerPrefs.SetInt("ClockDisplayChoice", e.Index);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000080F4 File Offset: 0x000062F4
		public void Options_ClockGameSystemChoiceChanged(object sender, ChoiceChangedEventArgs<string> e)
		{
			bool flag = e.Id != "displayClockGameSystemChoice";
			if (!flag)
			{
				Config.ClockGameSystemChoiceIndex = e.Index;
				PlayerPrefs.SetInt("ClockGameSystemChoice", e.Index);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008134 File Offset: 0x00006334
		public void Options_HullPowerTempToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showHullPowerTempToggle";
			if (!flag)
			{
				Config.ShowHullPowerTempToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowHullPowerTempToggle", e.Value);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008174 File Offset: 0x00006374
		public void Options_HullLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "hullLowerLimitSlider";
			if (!flag)
			{
				Config.HullLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HUDLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000081C0 File Offset: 0x000063C0
		public void Options_HullUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "hullUpperLimitSlider";
			if (!flag)
			{
				Config.HullUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("HUDUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000820C File Offset: 0x0000640C
		public void Options_TempLowerLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "tempLowerLimitSlider";
			if (!flag)
			{
				Config.TempLowerLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("TempLowerLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00008258 File Offset: 0x00006458
		public void Options_TempUpperLimitSliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "tempUpperLimitSlider";
			if (!flag)
			{
				Config.TempUpperLimitSliderValue = Mathf.Floor(e.Value);
				PlayerPrefs.SetFloat("TempUpperLimitSlider", Mathf.Floor(e.Value));
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000082A4 File Offset: 0x000064A4
		public void Options_LockBeamToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showLockBeamToggle";
			if (!flag)
			{
				Config.ShowLockBeamToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowLockBeamToggle", e.Value);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000082E4 File Offset: 0x000064E4
		public void Options_HUDControlHintsToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showHUDControlHintsToggle";
			if (!flag)
			{
				Config.ShowHUDControlHintsToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowHUDControlHintsToggle", e.Value);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008324 File Offset: 0x00006524
		
			
	}
}
