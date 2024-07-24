using System;
using System.Reflection;
using BepInEx;
using FMOD;
using HarmonyLib;
using MoonpoolDisplayRepair.Configuration;
using Nautilus.Handlers;
using static OVRPlugin;

namespace MoonpoolDisplayRepair
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    public class MainPatcher : BaseUnityPlugin
    {
        private const string
        MODNAME = "MoonpoolDisplayRepair",
        AUTHOR = "Upgrader Cookay",
        GUID = "MoonpoolDisplayRepair",
        VERSION = "1.0.0.0";
        public void Patch()
		{
			Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(),"com.mimes.subnautica.moonpooldisplayrepair");

            MoonpoolDisplayRepair.Configuration.Config.Load();
			OptionsPanelHandler.RegisterModOptions(new Options());
		}
	}
}
