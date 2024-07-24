using System;
using Nautilus.Options;
using Nautilus.Utility;
using UnityEngine;

namespace ImmersiveOutcropBreak.Configuration
{
	// Token: 0x0200001E RID: 30
	public class Options : ModOptions
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000050B0 File Offset: 0x000032B0
		public Options()
			: base("Immersive Outcrop Break")
		{
            var Pulseonoff = ModToggleOption.Create("pulseOnOffToggle", "Game load pulses on", Config.PulseToggleValue);
             Pulseonoff.OnChanged += this.Options_PulseToggleChanged;
			AddItem(Pulseonoff);
            var PulseonoffKey = ModKeybindOption.Create("pulseOnOffKeybindPress", "In game pulses toggle", GameInput.Device.Keyboard, Config.PulseKeybindValue);
			PulseonoffKey.OnChanged += this.Options_PulseKeybindValueChanged;  
			AddItem(PulseonoffKey);
            var OutCropABtoggle = ModToggleOption.Create("outcropAutoBreakOnToggle", "Game load Outcrop auto break on", Config.OutcropAutoBreakOnToggleValue);
            OutCropABtoggle.OnChanged += this.Options_OutcropAutoBreakOnToggleChanged;
			AddItem(OutCropABtoggle);
            var OutCropABkey = ModKeybindOption.Create("outcropAutoBreakKeybindPress", "In game auto break toggle", GameInput.Device.Keyboard, Config.OutcropAutoBreakKeybindValue);
            OutCropABkey.OnChanged += this.Options_OutcropAutoBreakKeybindValueChanged;
			AddItem(OutCropABkey);
            var OutCropAPtoggle = ModToggleOption.Create("outcropAutoPickupToggle", "Game load Outcrop auto pickup on", Config.OutcropAutoPickupToggleValue);
            OutCropAPtoggle.OnChanged += this.Options_OutcropAutoPickupToggleChanged;
			AddItem(OutCropAPtoggle);
            var OutcropAPkey = ModKeybindOption.Create("outcropAutoPickupKeybindPress", "In game auto pickup toggle", GameInput.Device.Keyboard, Config.OutcropAutoPickupKeybindValue);
            OutcropAPkey.OnChanged += this.Options_OutcropAutoPickupKeybindValueChanged;
			AddItem(OutcropAPkey);
            var ShowIVYkey = ModKeybindOption.Create("showInventoryKeybindPress", "In game show inventory toggle", GameInput.Device.Keyboard, Config.ShowInventoryKeybindValue);
            ShowIVYkey.OnChanged += this.Options_ShowInventoryKeybindValueChanged;
			AddItem(ShowIVYkey);
            var ShowPulseHintToggle = ModToggleOption.Create("showPulseHintToggle", "Pulse hint", Config.ShowPulseHintToggleValue);
            ShowPulseHintToggle.OnChanged += this.Options_ShowPulseHintToggleChanged;
			AddItem(ShowPulseHintToggle);
            var ShowIVYtoggle= ModToggleOption.Create("showInventoryHintToggle", "Inventory hint", Config.ShowInventoryHintToggleValue);
            ShowIVYtoggle.OnChanged += this.Options_ShowInventoryHintToggleChanged;
			AddItem(ShowIVYtoggle);
            var ShowAPHToggle= ModToggleOption.Create("showAutoPickupHintToggle", "Auto pickup hint", Config.ShowAutoPickupHintToggleValue);
            ShowAPHToggle.OnChanged += this.Options_ShowAutoPickupHintToggleChanged;
			AddItem(ShowAPHToggle);
            var ShowABHtoggle= ModToggleOption.Create("showAutoBreakHintToggle", "Auto break hint", Config.ShowAutoBreakHintToggleValue);
            ShowABHtoggle.OnChanged += this.Options_ShowAutoBreakHintToggleChanged;
			AddItem(ShowABHtoggle);
			var FirstPDslider= ModSliderOption.Create("firstPulseDelaySlider", "First pulse delay", 100f, 1000f, (float)Config.FirstPulseDelaySliderValue);
            FirstPDslider.OnChanged += this.Options_FirstPulseDelaySliderChanged;
			AddItem(FirstPDslider);
            var PulseInCDSlider = ModSliderOption.Create("pulseIncrementDelaySlider", "Pulse increment delay", 100f, 1000f, (float)Config.PulseIncrementDelaySliderValue);
            PulseInCDSlider.OnChanged += this.Options_PulseIncrementDelaySliderChanged;
			AddItem(PulseInCDSlider);
            var PulseGUItoggle = ModToggleOption.Create("PulseGUIToggle", "GUI icon for PulseGUI on", Config.PulseGUIToggleValue);
            PulseGUItoggle.OnChanged += this.Options_PulseGUIToggleChanged;
			AddItem(PulseGUItoggle);
            var ABGUItoggle= ModToggleOption.Create("autoBreakGUIToggle", "GUI icon for AutoBreak on", Config.AutoBreakGUIToggleValue);
            ABGUItoggle.OnChanged += this.Options_AutoBreakGUIToggleChanged;
			AddItem(ABGUItoggle);
            var APPGUItoggle= ModToggleOption.Create("autoPickupGUIToggle", "GUI icon for AutoPickup on", Config.AutoPickupGUIToggleValue);
            APPGUItoggle.OnChanged += this.Options_AutoPickupGUIToggleChanged;
			AddItem(APPGUItoggle);
















        }

		// Token: 0x060000A2 RID: 162 RVA: 0x000051FC File Offset: 0x000033FC
		public void Options_PulseToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "pulseToggle";
			if (!flag)
			{
				Config.PulseToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("PulseToggle", e.Value);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000523C File Offset: 0x0000343C
		public void Options_PulseKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "pulseKeybindPress";
			if (!flag)
			{
				Config.PulseKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("PulseKeybindPress", e.Value);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000527C File Offset: 0x0000347C
		public void Options_OutcropAutoBreakOnToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "outcropAutoBreakOnToggle";
			if (!flag)
			{
				Config.OutcropAutoBreakOnToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("OutcropAutoBreakOnToggle", e.Value);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000052BC File Offset: 0x000034BC
		public void Options_OutcropAutoBreakKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "outcropAutoBreakKeybindPress";
			if (!flag)
			{
				Config.OutcropAutoBreakKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("OutcropAutoBreakKeybindPress", e.Value);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000052FC File Offset: 0x000034FC
		public void Options_OutcropAutoPickupToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "outcropAutoPickupToggle";
			if (!flag)
			{
				Config.OutcropAutoPickupToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("OutcropAutoPickupToggle", e.Value);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000533C File Offset: 0x0000353C
		public void Options_OutcropAutoPickupKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "outcropAutoPickupKeybindPress";
			if (!flag)
			{
				Config.OutcropAutoPickupKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("OutcropAutoPickupKeybindPress", e.Value);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000537C File Offset: 0x0000357C
		public void Options_ShowInventoryKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "showInventoryKeybindPress";
			if (!flag)
			{
				Config.ShowInventoryKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("ShowInventoryKeybindPress", e.Value);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000053BC File Offset: 0x000035BC
		public void Options_ShowPulseHintToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showPulseHintToggle";
			if (!flag)
			{
				Config.ShowPulseHintToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowPulseHintToggle", e.Value);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000053FC File Offset: 0x000035FC
		public void Options_ShowInventoryHintToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showInventoryHintToggle";
			if (!flag)
			{
				Config.ShowInventoryHintToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowInventoryHintToggle", e.Value);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000543C File Offset: 0x0000363C
		public void Options_ShowAutoPickupHintToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showAutoPickupHintToggle";
			if (!flag)
			{
				Config.ShowAutoPickupHintToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowAutoPickupHintToggle", e.Value);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000547C File Offset: 0x0000367C
		public void Options_ShowAutoBreakHintToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showAutoBreakHintToggle";
			if (!flag)
			{
				Config.ShowAutoBreakHintToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowAutoBreakHintToggle", e.Value);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000054BC File Offset: 0x000036BC
		public void Options_FirstPulseDelaySliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "firstPulseDelaySlider";
			if (!flag)
			{
				Config.FirstPulseDelaySliderValue = (int)e.Value;
				PlayerPrefs.SetInt("FirstPulseDelaySlider", (int)e.Value);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005500 File Offset: 0x00003700
		public void Options_PulseIncrementDelaySliderChanged(object sender, SliderChangedEventArgs e)
		{
			bool flag = e.Id != "pulseIncrementDelaySlider";
			if (!flag)
			{
				Config.PulseIncrementDelaySliderValue = (int)e.Value;
				PlayerPrefs.SetInt("PulseIncrementDelaySlider", (int)e.Value);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005544 File Offset: 0x00003744
		public void Options_PulseGUIToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "pulseGUIToggle";
			if (!flag)
			{
				Config.PulseGUIToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("PulseGUIToggle", e.Value);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005584 File Offset: 0x00003784
		public void Options_AutoBreakGUIToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "autoBreakGUIToggle";
			if (!flag)
			{
				Config.AutoBreakGUIToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("AutoBreakGUIToggle", e.Value);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000055C4 File Offset: 0x000037C4
		public void Options_AutoPickupGUIToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "autoPickupGUIToggle";
			if (!flag)
			{
				Config.AutoPickupGUIToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("AutoPickupGUIToggle", e.Value);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005604 File Offset: 0x00003804
		
	}
}
