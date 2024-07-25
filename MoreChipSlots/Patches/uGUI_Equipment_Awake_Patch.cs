using System;
using HarmonyLib;
using MoreChipSlots.Configuration;
using MoreChipSlots.InfoObjects;
using UnityEngine;

namespace MoreChipSlots.Patches
{
    [HarmonyPatch(typeof(uGUI_Equipment))]
    [HarmonyPatch("Awake")]
    internal static class uGUI_Equipment_Awake_Patch
    {
       

        [HarmonyPrefix]
        public static void Prefix(uGUI_Equipment __instance)
        {
           
            uGUI_EquipmentSlot[] componentsInChildren = __instance.GetComponentsInChildren<uGUI_EquipmentSlot>(true);
            foreach (uGUI_EquipmentSlot uGUI_EquipmentSlot in componentsInChildren)
            {
                if (uGUI_EquipmentSlot.slot == ModInfo.SlotToCreate)
                {
                    if (MoreChipsConfig.FourSlotNumberChoiceIndex.Value == true)
                    {
                        ModInfo.FourChipsLayout();
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName3, ModInfo.Chip4_3_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName4, ModInfo.Chip4_4_Position);
                        
                       
                    }
                     if (MoreChipsConfig.SixSlotNumberChoiceIndex.Value == true)
                    {
                        ModInfo.SixChipsLayout();
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName3, ModInfo.Chip6_3_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName4, ModInfo.Chip6_4_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName5, ModInfo.Chip6_5_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName6, ModInfo.Chip6_6_Position);
                        
                       
                    }
                   
                    if (MoreChipsConfig.EightSlotNumberChoiceIndex.Value == true)
                    {
                        ModInfo.EightChipsLayout();
                        
                        //SetSlotPosition(ModInfo.SlotToCreate, ModInfo.Chip8_1_Position);
                        //SetSlotPosition(ModInfo.SlotName2, ModInfo.Chip8_2_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName3, ModInfo.Chip8_3_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName4, ModInfo.Chip8_4_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName5, ModInfo.Chip8_5_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName6, ModInfo.Chip8_6_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName7, ModInfo.Chip8_7_Position);
                        CreateSlot(uGUI_EquipmentSlot, __instance, ModInfo.SlotName8, ModInfo.Chip8_8_Position);
                       
                       
                    }
                   
                }
            }
        }

        public static void CreateSlot(uGUI_EquipmentSlot slot, uGUI_Equipment __instance, string thisSlotName, Vector3 thisPosition)
        {
            GameObject instantiatedObject = global::UnityEngine.Object.Instantiate(slot.gameObject, __instance.transform);
            

            uGUI_EquipmentSlot component = instantiatedObject.GetComponent<uGUI_EquipmentSlot>();
           

            component.slot = thisSlotName;
            component.gameObject.name = thisSlotName;
            component.gameObject.transform.localPosition = thisPosition;
        }

        private static void SetSlotPosition(string slotName, Vector3 position)
        {
            GameObject gameObject = GameObject.Find(slotName);
           
        }
    }
}
