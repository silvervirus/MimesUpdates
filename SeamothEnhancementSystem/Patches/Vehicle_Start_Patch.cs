using System;
using BepInEx.Bootstrap;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;
using Debug = UnityEngine.Debug;

namespace SeamothEnhancementSystem.Patches
{
	// Token: 0x0200000D RID: 13
	[HarmonyPatch(typeof(Vehicle))]
	[HarmonyPatch("Start")]
	internal class Vehicle_Start_Patch
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003628 File Offset: 0x00001828
		[HarmonyPrefix]
		public static void Prefix()
		{
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("SeaglideMapControls", out BepInEx.PluginInfo seaglideMapControls);

            // Check if the plugin is loaded
            bool flag = seaglideMapControls != null && seaglideMapControls.Instance != null;

            if (flag)
            {
                
                var seaglideMapPlugin = seaglideMapControls.Instance;
                if (seaglideMapPlugin == true)
                {
                    OtherModsInfo.SeaglideMapControls = true;
                    Debug.Log("SeaglideMapControls Found Enabling");
                }
                else
                {
                    Debug.Log("SeaglideMapControls not found");
                }
            }
          
            BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue("VehicleOxygenUpgrade", out BepInEx.PluginInfo vehicleOxygenUpgrade);
            // Check if the plugin is loaded
            bool flag1 = vehicleOxygenUpgrade != null && vehicleOxygenUpgrade.Instance != null;

            if (flag)
            {
                // The plugin is loaded, you can now interact with it
                // For example, you might want to cast it to a specific type
                var vehicleOxygenPlugin = vehicleOxygenUpgrade.Instance;
                if (vehicleOxygenPlugin == true)
                {
                    OtherModsInfo.VehicleOxygenUpgrade = true;
                    Debug.Log("VehicleOxygenUpgrade Found Enabling");
                }
            }
            else 
            {
                Debug.Log("VehicleOxygenUpgrade not found");
            }
            
        }
	}
}
