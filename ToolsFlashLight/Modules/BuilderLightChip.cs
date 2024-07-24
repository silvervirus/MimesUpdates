using System;
using System.Collections;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Crafting;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using static CraftData;

namespace ToolsFlashLight.Modules
{
	// Token: 0x0200000E RID: 14
	internal class BuilderLightChip : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public BuilderLightChip()
			: base("BuilderLightChip", "Builder light chip", "Builder light chip enables to control built-in LED flashlight module in Habitat Builder.")
		{
			
			BuilderLightChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.AdvancedWiringKit);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("BuilderLightChip"));
            this.SetRecipe(new(new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.AdvancedWiringKit, 1)));
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
