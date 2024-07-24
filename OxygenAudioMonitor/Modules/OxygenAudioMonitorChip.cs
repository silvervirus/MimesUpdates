using System;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Crafting;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using static CraftData;

namespace OxygenAudioMonitor.Modules
{
	// Token: 0x02000004 RID: 4
	internal class OxygenAudioMonitorChip : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public OxygenAudioMonitorChip()
			: base("OxygenAudioMonitorChip", "Oxygen Audio Monitor Chip", "Oxygen Audio Monitor Chip uses Stalker sounds coded in their tooth DNA, which it converts to warning messages for O₂ levels at 50, 25, 10%, and 30s of O₂ left.")
		{
			
			OxygenAudioMonitorChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.AdvancedWiringKit);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("OxygenAudioMonitorChip"));
            this.SetRecipe(new(new Ingredient(TechType.StalkerTooth ,1), new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.CopperWire, 1)));
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
