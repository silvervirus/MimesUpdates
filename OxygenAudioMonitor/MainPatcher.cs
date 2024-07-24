using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using OxygenAudioMonitor.InfoObjects;
using OxygenAudioMonitor.Modules;
using Nautilus.Handlers;
using Nautilus.Utility;
using UnityEngine;
using Debug = UnityEngine.Debug;
using ImageUtils = Nautilus.Utility.ImageUtils;
using static OVRPlugin;

namespace OxygenAudioMonitor
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("ExtraTabs", BepInDependency.DependencyFlags.SoftDependency)]
    public class MainPatcher : BaseUnityPlugin
    {
        private const string
        MODNAME = "OxygenAudioMonitor",
        AUTHOR = "Upgrader Cookay",
        GUID = "OxygenAudioMonitor",
        VERSION = "1.0.0.0";
        public static string _AssetName
		{
			get
			{
				return "oxygenaudiomonitor";
			}
		}

	
		
		public void Awake()
		{
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("ExtraTabs", out BepInEx.PluginInfo extraTabs);

            // Check if the plugin is loaded
            bool flag = extraTabs != null && extraTabs.Instance != null;

            if (flag)
            {

                var extraTabsPlugin = extraTabs.Instance;
                if (extraTabsPlugin == true)
                {
                    ModInfo.ExtraTabs = true;
                    Debug.Log("ExtraTabs Found Enabling");
                }
                else
                {
                    Debug.Log("ExtraTabs not found");
                }
            }
            Harmony harmony = new Harmony("com.mimes.subnautica.oxygenaudiomonitor");
			OxygenAudioMonitorChip oxygenAudioMonitorChip = new OxygenAudioMonitorChip();
			oxygenAudioMonitorChip.Register();
			bool flag2 = !ModInfo.ExtraTabs;
			if (flag2)
			{
				Atlas.Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "OxygenIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Oxygen", "Oxygen", sprite, new string[] { "Personal", "Equipment" });
			}
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, oxygenAudioMonitorChip.Info.TechType, new string[] { "Personal", "Equipment", "Oxygen" });
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}

		// Token: 0x04000001 RID: 1
		private static Assembly thisAssembly = Assembly.GetExecutingAssembly();

		// Token: 0x04000002 RID: 2
		private static string ModPath = Path.GetDirectoryName(MainPatcher.thisAssembly.Location);

		// Token: 0x04000003 RID: 3
		internal static string AssetsFolder = Path.Combine(MainPatcher.ModPath, "Assets");
	}
}
