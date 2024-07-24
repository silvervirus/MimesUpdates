using System;
using HarmonyLib;
using SeamothEnhancementSystem.InfoObjects;
using SeamothEnhancementSystem.ManageGUI;

namespace SeamothEnhancementSystem.Patches
{
    // Token: 0x02000009 RID: 9
    [HarmonyPatch(typeof(Player))]
    [HarmonyPatch("Update")]
    internal class Player_Update_Patch
    {
        // Token: 0x06000012 RID: 18 RVA: 0x0000241C File Offset: 0x0000061C
        [HarmonyPostfix]
        public static void Postfix(Player __instance)
        {
            bool flag = __instance != null;
            if (flag)
            {
                Vehicle vehicle = __instance.GetVehicle() as SeaMoth;
                bool flag2 = vehicle != null;
                if (flag2)
                {
                    SeamothInfo.CheckModuleStatus(vehicle);
                    bool flag3 = __instance.GetMode() == Player.Mode.LockedPiloting;
                    bool flag4 = (SeamothInfo.electricalModuleIn || SeamothInfo.electronicModuleIn || SeamothInfo.mechanicalModuleIn) && flag3 && !Player.main.GetPDA().isInUse;
                    if (flag4)
                    {
                        ManageAllGUIElements.ManageAllGuiElements();
                    }
                    else
                    {
                        ManageAllGUIElements.TurnUIOff();
                    }
                    bool flag5 = SeamothInfo.safeEjectActive && vehicle.prevVelocity == GameInput.GetMoveDirection();
                    if (flag5)
                    {
                        Player.main.TryEject();
                    }
                }
                else
                {
                    ManageAllGUIElements.TurnUIOff();
                }
            }
        }
    }
}
