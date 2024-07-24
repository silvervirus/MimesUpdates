using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace SeamothEnhancementSystem.Modules
{
	// Token: 0x02000015 RID: 21
	public class MechanicalEnhancement : CustomPrefab
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004EF9 File Offset: 0x000030F9
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00004F00 File Offset: 0x00003100
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public MechanicalEnhancement()
			: base("MechanicalEnhancement", "Mechanical module", "Part of Vehicle Enhancement System supplying Advanced Gearbox and Speedometer")
		{
		    MechanicalEnhancement.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.VehicleUpgrades, TechCategory.VehicleUpgrades);
            this.SetUnlock(TechType.BaseUpgradeConsole);
            this.SetEquipment(EquipmentType.SeamothModule).QuickSlotType = QuickSlotType.Passive;
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MechanicalEnhancement"));
            this.SetRecipe(new(new Ingredient(TechType.TitaniumIngot, 1), new Ingredient(TechType.Diamond, 1), new Ingredient(TechType.Lubricant, 1)));
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
