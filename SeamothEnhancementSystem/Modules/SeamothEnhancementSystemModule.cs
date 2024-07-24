using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace SeamothEnhancementSystem.Modules
{
	// Token: 0x02000016 RID: 22
	public class SeamothEnhancementSystemModule : CustomPrefab
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004FF6 File Offset: 0x000031F6
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00004FFD File Offset: 0x000031FD
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public SeamothEnhancementSystemModule()
			: base("SeamothEnhancementSystemModule", "Seamoth enhancement system", "Ads Advanced Headlights & in-cabin Battery Exchange, Cruise Control & Turbo and Green engine modes, Advanced Gearbox & Speedometer, enhances Health, Power and Temperature displays")
		{
			
			SeamothEnhancementSystemModule.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.VehicleUpgrades, TechCategory.VehicleUpgrades);
            this.SetUnlock(TechType.Workbench);
            this.SetEquipment(EquipmentType.SeamothModule).QuickSlotType = QuickSlotType.Passive;
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("SeamothEnhancementSystemModule"));
            this.SetRecipe(new(new Ingredient(ElectricalEnhancement.TechTypeID, 1), new Ingredient(ElectronicEnhancement.TechTypeID, 1), new Ingredient(MechanicalEnhancement.TechTypeID, 1)));
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
