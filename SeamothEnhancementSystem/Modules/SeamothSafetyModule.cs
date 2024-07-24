using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace SeamothEnhancementSystem.Modules
{
	// Token: 0x02000018 RID: 24
	public class SeamothSafetyModule : CustomPrefab
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005205 File Offset: 0x00003405
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000520C File Offset: 0x0000340C
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public SeamothSafetyModule()
			: base("SafetyModule", "Seamoth safety module", "Part of Vehicle Enhancement System. Provides emergency Deep Trickle Charger, colision Auto Cut-off Cruise Control, and Seamoth - Player No-collision Exit")
		{
			
			
            SeamothSafetyModule.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.VehicleUpgrades, TechCategory.VehicleUpgrades);
            this.SetUnlock(TechType.BaseUpgradeConsole);
            this.SetEquipment(EquipmentType.SeamothModule).QuickSlotType = QuickSlotType.Passive;
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("SafetyModule"));
            this.SetRecipe(new(new Ingredient(TechType.Floater, 1),
                    new Ingredient(TechType.PowerCell, 1),
                    new Ingredient(TechType.PurpleBrainCoralPiece, 1),
                    new Ingredient(TechType.ComputerChip, 1),
                    new Ingredient(TechType.SpikePlantSeed, 1),
                    new Ingredient(TechType.AdvancedWiringKit, 1)));
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
