using System;
using Nautilus.Options;
using Nautilus.Utility;

namespace RemoveStartupDisclaimer.Configuration
{
	// Token: 0x02000005 RID: 5
	public class OptionsData : ModOptions
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000020B9 File Offset: 0x000002B9
		public OptionsData()
			: base("Remove Startup Disclaimer")
		{
            var RemoveFlashingLights = ModToggleOption.Create("removeFlashingLightsDisclaimerToggle", "Remove Flashing Ligts Disclaimer", ConfigData.RemoveFlashingLightsDisclaimerValue);
            RemoveFlashingLights.OnChanged += this.Options_RemoveFlashingLightsDisclaimerToggleChanged;
			AddItem(RemoveFlashingLights);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020DC File Offset: 0x000002DC
		public void Options_RemoveFlashingLightsDisclaimerToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "removeFlashingLightsDisclaimerToggle";
			if (!flag)
			{
				ConfigData.RemoveFlashingLightsDisclaimerValue = e.Value;
				PlayerPrefsExtra.SetBool("RemoveFlashingLightsDisclaimerToggle", e.Value);
			}
		}

		
		
	}
}
