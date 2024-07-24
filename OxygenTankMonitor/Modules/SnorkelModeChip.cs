using System;
using System.Diagnostics.CodeAnalysis;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;

namespace OxygenTankMonitor.Modules
{
	// Token: 0x02000009 RID: 9
	internal class SnorkelModeChip : CustomPrefab
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002809 File Offset: 0x00000A09
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002810 File Offset: 0x00000A10
		public static TechType TechTypeID { get; protected set; }

#pragma warning disable CS0436 // Type conflicts with imported type
        [SetsRequiredMembers]
#pragma warning restore CS0436 // Type conflicts with imported type
        public SnorkelModeChip()
			: base("SnorkelModeChip", "Snorkel Mode Chip", "Snorkel Mode Chip enables snorkel mode, which allows breathing via snorkel and ensures constant swimming depth with free look at an ocean floor below.")
		{
			
				SnorkelModeChip.TechTypeID = base.Info.TechType; 
				this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
				this.SetUnlock(TechType.CreepvineSeedCluster);
				this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
				this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("SnorkelModeChip"));
				this.SetRecipe(new(new Ingredient(TechType.Pipe, 1), new Ingredient(TechType.Silicone, 1)));
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
        
		public  string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
