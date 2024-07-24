using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ImmersiveOutcropBreak.Modules
{
	
	internal class LoTechGloveChip : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public LoTechGloveChip()
			: base("LoTechGloveChip", "LoTech glove chip", "LoTech Glove Chip links up with gloves via Wi-Fi. With shale gloves worn and outcrop targeted, it enables gloves to send an acoustic blast, weakening the outcrop. It also projects basic information about inventory to the HUD.")
		{
			
				LoTechGloveChip.TechTypeID = base.Info.TechType;
               
                this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
                this.SetUnlock(TechType.AdvancedWiringKit);
                this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
                this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("LoTechGloveChip"));
                this.SetRecipe(new(new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.CopperWire, 1)));
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
        
		public string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
