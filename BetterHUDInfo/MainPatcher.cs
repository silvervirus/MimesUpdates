using System;
using System.IO;
using System.Reflection;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using BetterHUDInfo.Modules;
using HarmonyLib;
using Nautilus.Handlers;
using UnityEngine;
using static OVRPlugin;

namespace BetterHUDInfo
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("SeamothEnhancementSystem", BepInDependency.DependencyFlags.SoftDependency)]

    public class MainPatcher : BaseUnityPlugin
    {
        private const string
          MODNAME = "BetterHUDInfo",
          AUTHOR = "Upgrader Cookay",
          GUID = "com.BetterHUDInfo.Mimes",
          VERSION = "1.0.0.0";
        public static string _AssetName
		{
			get
			{
				return "betterhudbundle";
			}
		}

		public static ModInfo info;


		public void Awake()
		{
			Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "com.mimes.subnautica.betterhudinfo");
			EnhancedHUDChip enhancedHUDChip = new EnhancedHUDChip();
			enhancedHUDChip.Register();
            BetterHUDInfo.Configuration.Config.Load();
			OptionsPanelHandler.RegisterModOptions(new Options());
		}


		// Token: 0x04000001 RID: 1
		private static Assembly thisAssembly = Assembly.GetExecutingAssembly();

		// Token: 0x04000002 RID: 2
		private static string ModPath = Path.GetDirectoryName(MainPatcher.thisAssembly.Location);

		// Token: 0x04000003 RID: 3
		internal static string AssetsFolder = Path.Combine(MainPatcher.ModPath, "Assets");

		// Token: 0x04000004 RID: 4
		internal static AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(MainPatcher.AssetsFolder, "betterhudbundle"));
	}
}
