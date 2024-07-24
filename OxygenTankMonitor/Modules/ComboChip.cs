using System;
using System.Diagnostics.CodeAnalysis;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Crafting;
using UnityEngine;
using static CraftData;

namespace OxygenTankMonitor.Modules
{
	// Token: 0x02000007 RID: 7
	internal class ComboChip :CustomPrefab
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002600 File Offset: 0x00000800
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002607 File Offset: 0x00000807
		public static TechType TechTypeID { get; protected set; }

#pragma warning disable CS0436 // Type conflicts with imported type
        [SetsRequiredMembers]
#pragma warning restore CS0436 // Type conflicts with imported type
        public ComboChip()
			: base("ComboChip", "Oxygen Combo Chip", "Oxygen Combo Chip enables snorkel mode as well as projects Oxygen tank count and status information onto HUD.")
		{
			
			
				ComboChip.TechTypeID = this.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.Workbench);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.SeamothUpgrades, this.Info.TechType, new string[] { "SeamothUpgrade" });
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Upgrades", "SeamothUpgrades" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("ComboChip"));
            this.SetRecipe(new(new Ingredient(OxygenTankMonitorChip.TechTypeID, 1), new Ingredient(SnorkelModeChip.TechTypeID, 1)));
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
        // Token: 0x06000016 RID: 22 RVA: 0x00002698 File Offset: 0x00000898
       

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000026E5 File Offset: 0x000008E5
		public  string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
