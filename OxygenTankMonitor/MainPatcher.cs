using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using OxygenTankMonitor.InfoObjects;
using OxygenTankMonitor.Modules;
using Nautilus.Handlers;
using Nautilus.Utility;
using UnityEngine;
using Debug = UnityEngine.Debug;
using static OVRPlugin;

namespace OxygenTankMonitor
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("ExtraTabs", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("OxygenAudioMonitor", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("OxygenCanisters", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("MoreModifiedItems", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("ToolsFlashLight", BepInDependency.DependencyFlags.SoftDependency)]
    public class MainPatcher : BaseUnityPlugin
    {
        private const string
         MODNAME = "Oxygen Tank Monitor",
         AUTHOR = "Upgrader Cookay",
         GUID = "OxygenTankMonitor",
         VERSION = "1.0.0.0";
        public static string _AssetName
		{
			get
			{
				return "oxygentankmonitor";
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
          
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("OxygenAudioMonitor", out BepInEx.PluginInfo oxygenAudioMonitor);

            // Check if the plugin is loaded
            bool flag1 = oxygenAudioMonitor != null && oxygenAudioMonitor.Instance != null;

            if (flag1)
            {

                var oxygenAudioMonitorPlugin = oxygenAudioMonitor.Instance;
                if (oxygenAudioMonitorPlugin == true)
                {
                    ModInfo.OxygenAudioMonitor = true;
                    Debug.Log("OxygenAudioMonitor Found Enabling");
                }
                else
                {
                    Debug.Log("OxygenAudioMonitor not found");
                }
            }
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("OxygenCanisters", out BepInEx.PluginInfo oxygenCanisters);
            bool flag2 = oxygenCanisters != null && oxygenCanisters.Instance != null;

            if (flag2)
            {

                var oxygenCanistersPlugin = oxygenCanisters.Instance;
                if (oxygenCanistersPlugin == true)
                {
                    ModInfo.OxygenCanisters = true;
                    Debug.Log("OxygenCanisters Found Enabling");
                }
                else
                {
                    Debug.Log("OxygenCanisters not found");
                }
            }

            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("MoreModifiedItems", out BepInEx.PluginInfo MoreModifiedItems);
            bool flag3 = MoreModifiedItems != null && MoreModifiedItems.Instance != null;

            if (flag3)
            {

                var MoreModifiedItemsPlugin = MoreModifiedItems.Instance;
                if (MoreModifiedItemsPlugin == true)
                {
                    ModInfo.ScubaManifold = true;
                    Debug.Log("MoreModifiedItems Found Enabling");
                }
                else
                {
                    Debug.Log("MoreModifiedItems not found");
                }
            }
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("ToolsFlashLight", out BepInEx.PluginInfo ToolsFlashLight);
            bool flag4 = ToolsFlashLight != null && ToolsFlashLight.Instance != null;

            if (flag4)
            {

                var ToolsFlashLightPlugin = ToolsFlashLight.Instance;
                if (ToolsFlashLightPlugin == true)
                {
                    ModInfo.ToolsFlashLight= true;
                    Debug.Log("MoreModifiedItems Found Enabling");
                }
                else
                {
                    Debug.Log("MoreModifiedItems not found");
                }
            }
           
			Harmony harmony = new Harmony("com.mimes.subnautica.oxygentankmonitor");
			OxygenTankMonitorChip oxygenTankMonitorChip = new OxygenTankMonitorChip();
			oxygenTankMonitorChip.Register();
			SnorkelModeChip snorkelModeChip = new SnorkelModeChip();
			snorkelModeChip.Register();
			ComboChip comboChip = new ComboChip();
			comboChip.Register();
			bool flag6 = !ModInfo.ExtraTabs && !ModInfo.OxygenAudioMonitor && !ModInfo.OxygenCanisters;
			if (flag6)
			{
				Atlas.Sprite sprite = Nautilus.Utility.ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "OxygenIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Oxygen", "Oxygen", sprite, new string[] { "Personal", "Equipment" });
			}
			bool flag7 = !ModInfo.ExtraTabs && !ModInfo.ToolsFlashLight;
			if (flag7)
			{
				Atlas.Sprite sprite2 = Nautilus.Utility.ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "ChipsIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Chips", "Chip Upgrades", sprite2);
			}
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, oxygenTankMonitorChip.Info.TechType, new string[] { "Personal", "Equipment", "Oxygen" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, snorkelModeChip.Info.TechType, new string[] { "Personal", "Equipment", "Oxygen" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, comboChip.Info.TechType, new string[] { "Chips" });
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
