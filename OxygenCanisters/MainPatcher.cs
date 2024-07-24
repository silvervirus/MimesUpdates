using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using OxygenCanisters.Info;
using OxygenCanisters.Modules;
using Nautilus.Handlers;
using Nautilus.Utility;
using UnityEngine;
using ImageUtils = Nautilus.Utility.ImageUtils;
using Debug = UnityEngine.Debug;

namespace OxygenCanisters
{
	
	public class MainPatcher
	{
		
		public static string _AssetName
		{
			get
			{
				return "oxygencanisters";
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
            Harmony harmony = new Harmony("com.mimes.subnautica.oxygencanisterss");
           
			 
            OxygenCanisterMonitorChip oxygenCanisterMonitorChip = new OxygenCanisterMonitorChip();
			oxygenCanisterMonitorChip.Register();
			bool flag3 = !ModInfo.ExtraTabs && !ModInfo.OxygenAudioMonitor;
			if (flag3)
			{
				Atlas.Sprite sprite = ImageUtils.LoadSpriteFromFile(Path.Combine(MainPatcher.AssetsFolder, "OxygenIcon.png"), TextureFormat.BC7);
				CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Oxygen", "Oxygen", sprite, new string[] { "Personal", "Equipment" });
			}
			
			CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, oxygenCanisterMonitorChip.Info.TechType, new string[] { "Personal", "Equipment", "Oxygen" });
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
