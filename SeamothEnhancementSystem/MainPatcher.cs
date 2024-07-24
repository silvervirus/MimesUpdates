using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.Modules;
using SeamothEnhancementSystem.Options;
using Nautilus.Handlers;
using UnityEngine;
using UnityEngine.UI;
using static OVRPlugin;

namespace SeamothEnhancementSystem
{

    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]

    public class MainPatcher : BaseUnityPlugin
    {
        private const string
          MODNAME = "SeamothEnhancementSystem",
          AUTHOR = "Upgrader Cookay",
          GUID = "com.SeamothEnhancementSystem.Mimes",
          VERSION = "1.0.0.0";
        public static string _AssetName
		{
			get
			{
				return "seamothguibundle";
			}
		}

		
		
		public void Awake()
		{
			Harmony harmonyInstance = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(),"com.mimes.subnautica.seamothenhancementsystem");

            ElectricalEnhancement electricalEnhancement = new ElectricalEnhancement();
            electricalEnhancement.Register();
            ElectronicEnhancement electronicEnhancement = new ElectronicEnhancement();
            electronicEnhancement.Register();
            MechanicalEnhancement mechanicalEnhancement = new MechanicalEnhancement();
            mechanicalEnhancement.Register();
            SeamothSafetyModule seamothSafetyModule = new SeamothSafetyModule();
            seamothSafetyModule.Register();
            SeamothLink seamothLink = new SeamothLink();
            seamothLink.Register();
            SeamothEnhancementSystemModule seamothEnhancementSystemModule = new SeamothEnhancementSystemModule();
            seamothEnhancementSystemModule.Register();
            GameObject gameObject = new GameObject("VehicleEnhancements");
			Sprite sprite = MainPatcher.assetBundle.LoadAsset<Sprite>("piloting_128x128");
			gameObject.gameObject.AddComponent<Image>().sprite = sprite;
			CraftTreeHandler.AddTabNode(CraftTree.Type.SeamothUpgrades, "vehicleEnhancements", "Vehicle piloting enhancements", sprite);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, electricalEnhancement.Info.TechType, new string[] { "vehicleEnhancements" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, electronicEnhancement.Info.TechType, new string[] { "vehicleEnhancements" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, mechanicalEnhancement.Info.TechType, new string[] { "vehicleEnhancements" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, seamothSafetyModule.Info.TechType, new string[] { "vehicleEnhancements" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, seamothLink.Info.TechType, new string[] { "vehicleEnhancements" });

            SeamothEnhancementSystem.Configuration.Config.Load();
            OptionsPanelHandler.RegisterModOptions(new Options.Options());

        }

		// Token: 0x04000001 RID: 1
		private static Assembly thisAssembly = Assembly.GetExecutingAssembly();

		// Token: 0x04000002 RID: 2
		private static string ModPath = Path.GetDirectoryName(MainPatcher.thisAssembly.Location);

		// Token: 0x04000003 RID: 3
		internal static string AssetsFolder = Path.Combine(MainPatcher.ModPath, "Assets");

		// Token: 0x04000004 RID: 4
		internal static AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(MainPatcher.AssetsFolder, "seamothguibundle"));
	}
}
