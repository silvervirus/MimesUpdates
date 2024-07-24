using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Nautilus.Handlers;
using Nautilus.Utility;
using ToolsFlashLight.Configuration;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.Modules;
using UnityEngine;
using static OVRPlugin;
using Debug = UnityEngine.Debug;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace ToolsFlashLight
{

    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]

    public class MainPatcher : BaseUnityPlugin
    {
        private const string
      MODNAME = "ToolsFlashLight",
      AUTHOR = "Upgrader Cookay",
      GUID = "com.ToolsFlashLight.Mimes",
      VERSION = "1.0.0.0";

        public static string _AssetName
		{
			get
			{
				return "toolsflashlight";
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		
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
            Harmony harmony = new Harmony("com.mimes.subnautica.toolsflashlight");
			BuilderLightChip builderLightChip = new BuilderLightChip();
			builderLightChip.Register();
			CutterLightChip cutterLightChip = new CutterLightChip();
			cutterLightChip.Register();
			ScannerLightChip scannerLightChip = new ScannerLightChip();
			scannerLightChip.Register();
			WelderLightChip welderLightChip = new WelderLightChip();
			welderLightChip.Register();
			ToolsLightChip toolsLightChip = new ToolsLightChip();
			toolsLightChip.Register();
			bool flag2 = !ModInfo.ExtraTabs;
			if (flag2)
			{
				Atlas.Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "ToolChipsIcon.png"), TextureFormat.BC7);
				Atlas.Sprite sprite2 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "ChipsIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "ToolChips", "Tool Chips", sprite, new string[] { "Personal", "Equipment" });
				CraftTreeHandler.AddTabNode(CraftTree.Type.Workbench, "Chips", "Chip Upgrades", sprite2);
			}
			Atlas.Sprite sprite3 = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "TabNodeIcon.png"), TextureFormat.BC7);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, toolsLightChip.Info.TechType, new string[] { "Chips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, builderLightChip.Info.TechType, new string[] { "Personal", "Equipment", "ToolChips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, cutterLightChip.Info.TechType, new string[] { "Personal", "Equipment", "ToolChips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, scannerLightChip.Info.TechType, new string[] { "Personal", "Equipment", "ToolChips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, welderLightChip.Info.TechType, new string[] { "Personal", "Equipment", "ToolChips" });
			harmony.PatchAll(Assembly.GetExecutingAssembly());
			ConfigData.Load();
			OptionsPanelHandler.RegisterModOptions(new OptionsData());
		}

		// Token: 0x04000001 RID: 1
		private static Assembly thisAssembly = Assembly.GetExecutingAssembly();

		// Token: 0x04000002 RID: 2
		private static string ModPath = Path.GetDirectoryName(MainPatcher.thisAssembly.Location);

		// Token: 0x04000003 RID: 3
		internal static string AssetsFolder = Path.Combine(MainPatcher.ModPath, "Assets");
	}
}
