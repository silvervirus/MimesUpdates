using System;
using Nautilus.Options;
using Nautilus.Utility;

namespace RemoveOptionsButtons.Configuration
{
	// Token: 0x02000006 RID: 6
	public class OptionsData : ModOptions
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020F6 File Offset: 0x000002F6
		public OptionsData()
			: base("Remove Options Buttons")
		{
            var RemoveRedeemKey = ModToggleOption.Create("RemoveRedeemaKeyButtonToggle", "Remove Redeem a Key Button", ConfigData.RemoveRedeemaKeyButtonValue);
            var RemoveTroubShooting = ModToggleOption.Create("RemoveTroubleshootingButtonToggle", "Remove Troubleshooting Button", ConfigData.RemoveTroubleshootingButtonValue);
            RemoveRedeemKey.OnChanged += this.Options_RemoveRedeemaKeyButtonToggleChanged;
			AddItem(RemoveRedeemKey);
			RemoveTroubShooting.OnChanged += this.Options_RemoveTroubleshootingButtonToggleChanged;
			AddItem(RemoveTroubShooting);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000212C File Offset: 0x0000032C
		public void Options_RemoveRedeemaKeyButtonToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "RemoveRedeemaKeyButtonToggle";
			if (!flag)
			{
				ConfigData.RemoveRedeemaKeyButtonValue = e.Value;
				PlayerPrefsExtra.SetBool("SMLHelperRemoveRedeemaKeyButtonToggle", e.Value);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000216C File Offset: 0x0000036C
		public void Options_RemoveTroubleshootingButtonToggleChanged(object sender, ToggleChangedEventArgs e)
		{
			bool flag = e.Id != "RemoveTroubleshootingButtonToggle";
			if (!flag)
			{
				ConfigData.RemoveTroubleshootingButtonValue = e.Value;
				PlayerPrefsExtra.SetBool("SMLHelperRemoveTroubleshootingButtonToggle", e.Value);
			}
		}

		
		
	}
}
