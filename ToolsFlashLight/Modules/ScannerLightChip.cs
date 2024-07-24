using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ToolsFlashLight.Modules
{
	// Token: 0x02000010 RID: 16
	internal class ScannerLightChip : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public ScannerLightChip()
			: base("ScannerLightChip", "Scanner light chip", "Scanner light chip enables to control built-in LED flashlight module in Scanner Tool.")
		{
			
			ScannerLightChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.Compass);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("ScannerLightChip"));
            this.SetRecipe(new(new Ingredient(TechType.StalkerTooth, 1), new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.CopperWire, 1)));
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
