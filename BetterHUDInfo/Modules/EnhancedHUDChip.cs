using System;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;
using static CraftData;

namespace BetterHUDInfo.Modules
{
	// Token: 0x0200000B RID: 11
	internal class EnhancedHUDChip : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public EnhancedHUDChip()
			: base("EnhancedHUDChip", "Enhanced HUD Chip", "Provides enhanced HUD information: base strength, O2 level, biome, temperature, time, coordinates and other important metrics.")
		{

			EnhancedHUDChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.Compass);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;       
            Nautilus.Handlers.CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, this.Info.TechType, new string[] { "Personal", "Equipment" });
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("EnhancedHUDChip"));
            this.SetRecipe(new(new Ingredient(TechType.Glass, 1), new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.Battery, 1)));
            this.SetGameObject(GetGameObjectAsync);
            this.Register();
        }

            public IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
            {
                CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.Compass);
                yield return task;
                GameObject prefab = task.GetResult();
                GameObject obj = GameObject.Instantiate(prefab);
                prefab.SetActive(false);

                obj.SetActive(true);
                gameObject.Set(obj);
            }

		public string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
