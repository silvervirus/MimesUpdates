using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ImmersiveOutcropBreak.Modules
{
	// Token: 0x0200000B RID: 11
	internal class AdvancedShaleGloves : CustomPrefab
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000320D File Offset: 0x0000140D
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00003214 File Offset: 0x00001414
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public AdvancedShaleGloves()
			: base("AdvancedShaleGloves", "Advanced outcrop gloves", "Advanced outcrop gloves designed for speedy outcrop breaking. When used with hitech glove ghip, they have auto material pickup capability. Wi-Fi capable via Glove Chip.")
		{
			
				AdvancedShaleGloves.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(StandardShaleGloves.TechTypeID);
            CraftDataHandler.SetItemSize(this.Info.TechType, 2, 2);
            this.SetEquipment(EquipmentType.Gloves).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("AdvancedShaleGloves"));
            this.SetRecipe(new(new Ingredient(StandardShaleGloves.TechTypeID, 1), new Ingredient(TechType.Gold, 1), new Ingredient(TechType.TitaniumIngot, 1)));
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
