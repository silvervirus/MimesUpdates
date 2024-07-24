using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Modules;
using Nautilus.Handlers;
using Nautilus.Utility;
using UnityEngine;
using static OVRPlugin;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace ImmersiveOutcropBreak
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    public class MainPatcher : BaseUnityPlugin
    {
        private const string
        MODNAME = "ImmersiveOutcropBreak",
        AUTHOR = "Upgrader Cookay",
        GUID = "com.ImmersiveOutcropBreak.Mimes",
        VERSION = "1.0.0.0";
        public static string _AssetName
		{
			get
			{
				return "immersiveoutcropbreak";
			}
		}

		
		
		public void Awake()
		{
			Harmony harmony = new Harmony("com.mimes.subnautica.immersiveoutcropbreak");
			BasicShaleGloves basicShaleGloves = new BasicShaleGloves();
			basicShaleGloves.Register();
			StandardShaleGloves standardShaleGloves = new StandardShaleGloves();
			standardShaleGloves.Register();
			AdvancedShaleGloves advancedShaleGloves = new AdvancedShaleGloves();
			advancedShaleGloves.Register();
			LoTechGloveChip loTechGloveChip = new LoTechGloveChip();
			loTechGloveChip.Register();
			MidTechGloveChip midTechGloveChip = new MidTechGloveChip();
			midTechGloveChip.Register();
			HiTechGloveChip hiTechGloveChip = new HiTechGloveChip();
			hiTechGloveChip.Register();
			Atlas.Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "chip_128x128.png"), TextureFormat.BC7);
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, loTechGloveChip.Info.TechType, new string[] { "Personal", "Equipment", "Chips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, basicShaleGloves.Info.TechType, new string[] { "Personal", "Equipment", "Wearable" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, midTechGloveChip.Info.TechType, new string[] { "Chips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, hiTechGloveChip.Info.TechType, new string[] { "Chips" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, standardShaleGloves.Info.TechType, new string[] { "Wearable", "Gloves" });
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, advancedShaleGloves.Info.TechType, new string[] { "Wearable", "Gloves" });
			harmony.PatchAll(Assembly.GetExecutingAssembly());
            ImmersiveOutcropBreak.Configuration.Config.Load();
			OptionsPanelHandler.RegisterModOptions(new Options());
		}

		// Token: 0x04000001 RID: 1
		private static Assembly thisAssembly = Assembly.GetExecutingAssembly();

		// Token: 0x04000002 RID: 2
		private static string ModPath = Path.GetDirectoryName(MainPatcher.thisAssembly.Location);

		// Token: 0x04000003 RID: 3
		internal static string AssetsFolder = Path.Combine(MainPatcher.ModPath, "Assets");

		// Token: 0x04000004 RID: 4
		internal static AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(MainPatcher.AssetsFolder, "immersiveoutcropbreak"));
	}
}
