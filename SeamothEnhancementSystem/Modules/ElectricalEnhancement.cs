using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using static CraftData;
using System.Collections;
using System.Collections.Generic;
using Nautilus.Assets.Gadgets;

namespace SeamothEnhancementSystem.Modules
{
    
    public class ElectricalEnhancement : CustomPrefab
    {

        public static TechType TechTypeID;

        public static Atlas.Sprite Sprite;
        

        [SetsRequiredMembers]
        public ElectricalEnhancement(string classId = "ElectricalEnhancement", string displayName = "Electrical module", string description = "Part of Vehicle Enhancement System supplying Advanced Headlights and in-cabin Battery Exchange") : base(classId, displayName, description)
        {
            ElectricalEnhancement.TechTypeID = this.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.VehicleUpgrades, TechCategory.VehicleUpgrades);
            this.SetUnlock(TechType.BaseUpgradeConsole);
            this.SetEquipment(EquipmentType.SeamothModule).QuickSlotType = QuickSlotType.Passive;
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("ElectricalEnhancement"));
            this.SetRecipe(new(new Ingredient(TechType.Battery, 1), new Ingredient(TechType.CopperWire, 1), new Ingredient(TechType.ComputerChip, 1)));
            this.SetGameObject(GetGameObjectAsync);
            this.Register();
        }

       

        public IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.ExoHullModule1);
            yield return task;
            GameObject prefab = task.GetResult();
            GameObject obj = GameObject.Instantiate(prefab);
            prefab.SetActive(false);

            obj.SetActive(true);
            gameObject.Set(obj);
        }

       
    }
}
