using System;
using HarmonyLib;
using MoreChipSlots.Configuration;
using MoreChipSlots.InfoObjects;
using UnityEngine;

namespace MoreChipSlots.Patches
{
    [HarmonyPatch(typeof(Inventory))]
    [HarmonyPatch("UnlockDefaultEquipmentSlots")]
    internal static class Inventory_UnlockDefaultEquipmentSlots_Patch
    {
        

        [HarmonyPostfix]
        public static void Postfix(Inventory __instance)
        {

            if (MoreChipsConfig.FourSlotNumberChoiceIndex.Value == true )
            {
                DefineSlot(__instance.equipment, ModInfo.SlotName3);
                DefineSlot(__instance.equipment, ModInfo.SlotName4);

            }
            if (MoreChipsConfig.SixSlotNumberChoiceIndex.Value == true)
            {
                DefineSlot(__instance.equipment, ModInfo.SlotName3);
                DefineSlot(__instance.equipment, ModInfo.SlotName4);
                DefineSlot(__instance.equipment, ModInfo.SlotName5);
                DefineSlot(__instance.equipment, ModInfo.SlotName6);
            }

            if (MoreChipsConfig.EightSlotNumberChoiceIndex.Value == true)
            {

                DefineSlot(__instance.equipment, ModInfo.SlotName3);
                DefineSlot(__instance.equipment, ModInfo.SlotName4);
                DefineSlot(__instance.equipment, ModInfo.SlotName5);
                DefineSlot(__instance.equipment, ModInfo.SlotName6);
                DefineSlot(__instance.equipment, ModInfo.SlotName7);
                DefineSlot(__instance.equipment, ModInfo.SlotName8);
            }

            if (MoreChipsConfig.FourSlotNumberChoiceIndex.Value == true)
            {
                // Add slots
                __instance.equipment.AddSlot(ModInfo.SlotName3);
                __instance.equipment.AddSlot(ModInfo.SlotName4);
            }
            if (MoreChipsConfig.SixSlotNumberChoiceIndex.Value == true)   
            {
                __instance.equipment.AddSlot(ModInfo.SlotName3);
                __instance.equipment.AddSlot(ModInfo.SlotName4);
                __instance.equipment.AddSlot(ModInfo.SlotName5);
                __instance.equipment.AddSlot(ModInfo.SlotName6);
            }

            if (MoreChipsConfig.EightSlotNumberChoiceIndex.Value == true)
            {
                __instance.equipment.AddSlot(ModInfo.SlotName3);
                __instance.equipment.AddSlot(ModInfo.SlotName4);
                __instance.equipment.AddSlot(ModInfo.SlotName5);
                __instance.equipment.AddSlot(ModInfo.SlotName6);
                __instance.equipment.AddSlot(ModInfo.SlotName7);
                __instance.equipment.AddSlot(ModInfo.SlotName8);
            }
        }

        private static void DefineSlot(Equipment equipment, string slotName)
        {
            if (!Equipment.slotMapping.ContainsKey(slotName))
            {
                // Define the slot type. Adjust the slot type as needed.
                Equipment.slotMapping.Add(slotName, EquipmentType.Chip); // Assuming EquipmentType.Chip is a valid type
            }
        }
    }
}
