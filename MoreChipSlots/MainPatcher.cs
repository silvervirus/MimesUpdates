using System;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using FMOD;
using HarmonyLib;
using MoreChipSlots.Configuration;
using MoreChipSlots.InfoObjects;
using Nautilus.Handlers;
using static OVRPlugin;

namespace MoreChipSlots
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    public class MainPatcher : BaseUnityPlugin
    {

       
        private const string
         MODNAME = "MoreChipSlots",
         AUTHOR = "Upgrader Cookay",
         GUID = "MoreChipSlots",
         VERSION = "1.0.0.0";
        public void Awake()
		{
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "com.mimes.subnautica.morechipslots");
            MoreChipsConfig.LoadConfig(Config);
            bool flag = MoreChipsConfig.FourSlotNumberChoiceIndex.Value == true;
			if (flag)
			{
				Equipment.slotMapping[ModInfo.SlotName3] = EquipmentType.Chip;
				Equipment.slotMapping[ModInfo.SlotName4] = EquipmentType.Chip;
			}
           
			bool flag2 = MoreChipsConfig.SixSlotNumberChoiceIndex.Value == true;
			if (flag2)
			{
                Equipment.slotMapping[ModInfo.SlotName3] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName4] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName5] = EquipmentType.Chip;
				Equipment.slotMapping[ModInfo.SlotName6] = EquipmentType.Chip;
			}
			
			bool flag3 = MoreChipsConfig.EightSlotNumberChoiceIndex.Value == true;
			if (flag3)
			{
                Equipment.slotMapping[ModInfo.SlotName3] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName4] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName5] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName6] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName6] = EquipmentType.Chip;
                Equipment.slotMapping[ModInfo.SlotName7] = EquipmentType.Chip;
				Equipment.slotMapping[ModInfo.SlotName8] = EquipmentType.Chip;
			}
			
			
		}
	}
}
