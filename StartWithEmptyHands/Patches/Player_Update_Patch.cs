using System;
using HarmonyLib;
using StartWithEmptyHands.InfoObjects;

namespace StartWithEmptyHands.Patches
{
    [HarmonyPatch(typeof(Player))]
    [HarmonyPatch("Update")]
    internal class Player_Update_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Player __instance)
        {
            bool flag = !PAXTerrainController.main.isActiveAndEnabled && ModInfo.runOnce;  // Updated property name
            if (flag)
            {
                Inventory.main.quickSlots.DeselectImmediate();
                ModInfo.runOnce = false;
            }
        }
    }
}
