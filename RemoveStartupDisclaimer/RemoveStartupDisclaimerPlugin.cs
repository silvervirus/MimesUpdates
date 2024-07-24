using System;
using BepInEx;
using HarmonyLib;
using RemoveStartupDisclaimer.Configuration;
using Nautilus.Handlers;

namespace RemoveStartupDisclaimer
{
	// Token: 0x02000002 RID: 2
	[BepInPlugin("com.mimes.subnautica.removestartupdisclaimer", "Remove Startup Disclaimer", "2.0.0")]
	public class RemoveStartupDisclaimerPlugin : BaseUnityPlugin
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private void Start()
		{
			Harmony harmony = new Harmony("com.mimes.subnautica.removestartupdisclaimer");
			harmony.PatchAll();
			ConfigData.Load();
			OptionsPanelHandler.RegisterModOptions(new OptionsData());
		}
	}
}
