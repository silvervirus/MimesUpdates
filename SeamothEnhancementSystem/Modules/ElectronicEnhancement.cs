using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace SeamothEnhancementSystem.Modules
{
	// Token: 0x02000014 RID: 20
	internal class ElectronicEnhancement : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public ElectronicEnhancement()
			: base("ElectronicEnhancement", "Electronic module", "Part of Vehicle Enhancement System supplying Cruise Control and Turbo and Green engine modes")
		{
            ElectronicEnhancement.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.VehicleUpgrades, TechCategory.VehicleUpgrades);
            this.SetUnlock(TechType.BaseUpgradeConsole);
            this.SetEquipment(EquipmentType.SeamothModule).QuickSlotType = QuickSlotType.Passive;
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("ElectronicEnhancement"));
            this.SetRecipe(new(new Ingredient(TechType.VehiclePowerUpgradeModule, 1), new Ingredient(TechType.AdvancedWiringKit, 1), new Ingredient(TechType.ComputerChip, 1)));
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
