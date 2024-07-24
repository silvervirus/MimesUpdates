using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ImmersiveOutcropBreak.Modules
{
	// Token: 0x0200000C RID: 12
	internal class MidTechGloveChip : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public MidTechGloveChip()
			: base("MidTechGloveChip", "MidTech glove chip", "MidTech glove chip links up with gloves via Wi-Fi. With shale gloves worn and outcrop targeted, it enables gloves to send acoustic blasts significantly weakening the outcrop. It also projects more advanced tech information about inventory and pickupable items to the HUD.")
		{
			
				MidTechGloveChip.TechTypeID = base.Info.TechType;
                this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
                this.SetUnlock(TechType.AdvancedWiringKit);
                this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
                this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("MidTechGloveChip"));
                this.SetRecipe(new(new Ingredient(LoTechGloveChip.TechTypeID, 1), new Ingredient(TechType.WiringKit, 1)));
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
