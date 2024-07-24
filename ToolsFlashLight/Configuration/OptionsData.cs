using System;
using Nautilus.Options;
using Nautilus.Utility;

namespace ToolsFlashLight.Configuration
{
	// Token: 0x02000023 RID: 35
	public class OptionsData : ModOptions
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0000474C File Offset: 0x0000294C
		public OptionsData()
			: base("Tools Flash Light")
		{
			var Lightsonoffkey = ModKeybindOption.Create("lightOnOffKeybindPress", "In game tool light toggle", GameInput.Device.Keyboard, ConfigData.LightOnOffKeybindValue);
			Lightsonoffkey.OnChanged += Options_LightOnOffKeybindValueChanged;
			AddItem(Lightsonoffkey);
			var LightsIntensUpKey = ModKeybindOption.Create("lightIntensUpKeybindPress", "Tool light intensity up", GameInput.Device.Keyboard, ConfigData.LightIntensUpKeybindValue);
			LightsIntensUpKey.OnChanged += Options_LightIntensUpKeybindValueChanged;
			AddItem(LightsIntensUpKey);
			var LightIntensDownkey = ModKeybindOption.Create("lightIntensDownKeybindPress", "Tool light intensity down", GameInput.Device.Keyboard, ConfigData.LightIntensDownKeybindValue);
			LightIntensDownkey.OnChanged += Options_LightIntensDownKeybindValueChanged;
			AddItem(LightIntensDownkey);
			var ShowLightHintToggle = ModKeybindOption.Create("lightIntensDownKeybindPress", "Tool light intensity down", GameInput.Device.Keyboard, ConfigData.LightIntensDownKeybindValue);
			AddItem(ShowLightHintToggle);
			var ShowLightAdjustToggle = ModToggleOption.Create("showLightAdjustToggle", "Show light adjust key hint", ConfigData.ShowLightAdjustToggleValue);
			AddItem(ShowLightAdjustToggle);
            
        }

		// Token: 0x06000093 RID: 147 RVA: 0x000047C8 File Offset: 0x000029C8
		public void Options_LightOnOffKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "lightOnOffKeybindPress";
			if (!flag)
			{
				ConfigData.LightOnOffKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("LightOnOffKeybindPress", e.Value);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004808 File Offset: 0x00002A08
		public void Options_LightIntensUpKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "lightIntensUpKeybindPress";
			if (!flag)
			{
				ConfigData.LightIntensUpKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("LightIntensUpKeybindPress", e.Value);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004848 File Offset: 0x00002A48
		public void Options_LightIntensDownKeybindValueChanged(object sender, KeybindChangedEventArgs e)
		{
			bool flag = e.Id != "lightIntensDownKeybindPress";
			if (!flag)
			{
				ConfigData.LightIntensDownKeybindValue = e.Value;
				PlayerPrefsExtra.SetKeyCode("LightIntensDownKeybindPress", e.Value);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004888 File Offset: 0x00002A88
		public void Options_ShowLightHintToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showLightHintToggle";
			if (!flag)
			{
				ConfigData.ShowLightHintToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowLightHintToggle", e.Value);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000048C8 File Offset: 0x00002AC8
		public void Options_ShowLightAdjustToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "showLightAdjustToggle";
			if (!flag)
			{
				ConfigData.ShowLightAdjustToggleValue = e.Value;
				PlayerPrefsExtra.SetBool("ShowLightAdjustToggle", e.Value);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004908 File Offset: 0x00002B08
		public  void BuildModOptions()
		{
			
		}
	}
}
