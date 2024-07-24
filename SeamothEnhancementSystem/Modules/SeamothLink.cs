using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace SeamothEnhancementSystem.Modules
{
	// Token: 0x02000017 RID: 23
	internal class SeamothLink : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public SeamothLink()
			: base("SeamothLink", "Seamoth Link", "Part of Vehicle Enhancement System enabling HUD-to-Seamoth link")
		{
			
				SeamothLink.TechTypeID = base.Info.TechType;
                this.SetPdaGroupCategory(TechGroup.VehicleUpgrades, TechCategory.VehicleUpgrades);
                this.SetUnlock(TechType.BaseUpgradeConsole);
                this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
                Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
                Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
                this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("SeamothLink"));
                this.SetRecipe(new(new Ingredient(ElectricalEnhancement.TechTypeID, 1), new Ingredient(ElectronicEnhancement.TechTypeID, 1), new Ingredient(MechanicalEnhancement.TechTypeID, 1)));
                this.SetGameObject(GetGameObjectAsync);
                this.Register();
            
		}

        public IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.ComputerChip);
            yield return task;
            GameObject prefab = task.GetResult();
            GameObject obj = GameObject.Instantiate(prefab);
            prefab.SetActive(false);

            obj.SetActive(true);
            gameObject.Set(obj);
        }
    }
}
