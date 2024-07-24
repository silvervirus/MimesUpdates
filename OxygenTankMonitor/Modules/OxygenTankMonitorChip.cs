using System;
using System.Diagnostics.CodeAnalysis;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;

namespace OxygenTankMonitor.Modules
{
	// Token: 0x02000008 RID: 8
	internal class OxygenTankMonitorChip : CustomPrefab
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002703 File Offset: 0x00000903
		public static TechType TechTypeID { get; protected set; }

#pragma warning disable CS0436 // Type conflicts with imported type
        [SetsRequiredMembers]
#pragma warning restore CS0436 // Type conflicts with imported type
        public OxygenTankMonitorChip()
			: base("OxygenTankMonitorChip", "Oxygen Tank Monitor Chip", "Oxygen Tank Monitor Chip projects Oxygen tank count and their status information onto HUD.")
		{
			
				OxygenTankMonitorChip.TechTypeID = base.Info.TechType;
				this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
				this.SetUnlock(TechType.AdvancedWiringKit);
			    this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
			    this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("OxygenTankMonitorChip"));
			    this.SetRecipe(new(new Ingredient(TechType.Tank, 1), new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.AdvancedWiringKit, 1)));
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
