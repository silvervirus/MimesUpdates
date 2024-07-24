using System;
using System.IO;
using System.Reflection;
using BepInEx;
using ExtraTabs.InfoObjects;
using FMOD;
using HarmonyLib;
using Nautilus.Handlers;
using Nautilus.Utility;
using UnityEngine;
using static OVRPlugin;
using Debug = UnityEngine.Debug;

namespace ExtraTabs
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("StealthModule", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("ToolsFlashLight", BepInDependency.DependencyFlags.SoftDependency)]
    public class MainPatcher : BaseUnityPlugin
    {
        private const string
         MODNAME = "ExtraTabs",
         AUTHOR = "Upgrader Cookay",
         GUID = "com.ExtraTabs.Mimes",
         VERSION = "1.0.0.0";
        public static string _AssetName
		{
			get
			{
				return "toolsflashlight";
			}
		}

		
		
		public static void Patch()
		{
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("StealthModule", out BepInEx.PluginInfo stealthModule);

            // Check if the plugin is loaded
            bool flag = stealthModule != null && stealthModule.Instance != null;

            if (flag)
            {

                var extraTabsPlugin = stealthModule.Instance;
                if (extraTabsPlugin == true)
                {
                    ModInfo.StealthModule = true;
                    Debug.Log("StealthModule Found Enabling");
                }
                else
                {
                    Debug.Log("StealthModule not found");
                }
            }
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("ToolsFlashLight", out BepInEx.PluginInfo toolsFlashLight);

            // Check if the plugin is loaded
            bool flag2 = toolsFlashLight != null && toolsFlashLight.Instance != null;

            if (flag2)
            {

                var toolsFlashLightPlugin = toolsFlashLight.Instance;
                if (toolsFlashLightPlugin == true)
                {
                    ModInfo.ToolsFlashLight = true;
                    Debug.Log("ToolsFlashLight Found Enabling");
                }
                else
                {
                    Debug.Log("ToolsFlashLight not found");
                }
            }
            
			Harmony harmony = new Harmony("com.mimes.subnautica.extratabs");
			Atlas.Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "ChipsIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite2 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "WearableIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite3 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "GlovesIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite4 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "FinsIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite5 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "BagsIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite6 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "OxygenIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite7 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "ItemsIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite8 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "TabletsIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite9 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "SeamothDepthIcon.png"), TextureFormat.BC7);
			Atlas.Sprite sprite10 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "SeamothAltIcon.png"), TextureFormat.BC7);
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Chips", "Chips", sprite, new string[] { "Personal", "Equipment" });
			bool toolsFlashLights = ModInfo.ToolsFlashLight;
			if (toolsFlashLights)
			{
				Atlas.Sprite sprite11 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "ToolChipsIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "ToolChips", "Tool Chips", sprite11, new string[] { "Personal", "Equipment" });
			}
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Wearable", "Wearable", sprite2, new string[] { "Personal", "Equipment" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Bags", "Bags", sprite5, new string[] { "Personal", "Equipment" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Oxygen", "Oxygen", sprite6, new string[] { "Personal", "Equipment" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Items", "Items", sprite7, new string[] { "Personal", "Equipment" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Tablets", "Tablets", sprite8, new string[] { "Personal", "Equipment" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Chips", "Chip Upgrades", sprite);
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Wearable", "Wearable Upgrades", sprite2);
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Gloves", "Glove Upgrades", sprite3, new string[] { "Wearable" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Fins", "Fin Upgrades", sprite4, new string[] { "Wearable" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "ReinforcedSuits", "Dive Suit Upgrades", sprite2, new string[] { "Wearable" });
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Items", "Item Upgrades", sprite7);
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "AltSeamothMenu", "Seamoth Upgrades", sprite10);
			CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "SeamothDepth", "Depth Modules", sprite9, new string[] { "AltSeamothMenu" });
			bool stealthModules = ModInfo.StealthModule;
			if (stealthModules)
			{
				Atlas.Sprite sprite12 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "SeamothStealthIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Stealth", "Stealth Modules", sprite12, new string[] { "AltSeamothMenu" });
			}
			CraftTreeHandler.RemoveNode(CraftTree.Type.Workbench, new string[] { "SeamothMenu" });
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
