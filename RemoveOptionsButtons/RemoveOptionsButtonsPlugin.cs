using System;
using BepInEx;
using HarmonyLib;
using RemoveOptionsButtons.Configuration;
using Nautilus.Handlers;

namespace RemoveOptionsButtons
{
	
	[BepInPlugin("com.mimes.subnautica.removeoptionsbuttons", "Remove Options Buttons", "2.0.0")]
	public class RemoveOptionsButtonsPlugin : BaseUnityPlugin
	{
		
		private void Start()
		{
			Harmony harmony = new Harmony("com.mimes.subnautica.removeoptionsbuttons");
			harmony.PatchAll();
			ConfigData.Load();
			OptionsPanelHandler.RegisterModOptions(new OptionsData());
		}
	}
}
