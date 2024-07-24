using System;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;
using static CraftData;

namespace ImmersiveOutcropBreak.Modules
{
	// Token: 0x02000009 RID: 9
	internal class StandardShaleGloves : CustomPrefab
	{
		
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public StandardShaleGloves()
			: base("StandardShaleGloves", "Standard outcrop gloves", "Standard outcrop gloves designed for faster outcrop breaking. They break outcrops with two hits. Wi-Fi capable via Glove Chip.")
		{
			
			StandardShaleGloves.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.Workbench);
			CraftDataHandler.SetItemSize(this.Info.TechType,2,2);
            this.SetEquipment(EquipmentType.Gloves).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("StandardShaleGloves"));
            this.SetRecipe(new(new Ingredient(BasicShaleGloves.TechTypeID, 1), new Ingredient(TechType.Silver ,1), new Ingredient(TechType.TitaniumIngot, 1)));
            this.SetGameObject(GetGameObjectAsync);
            this.Register();
        }

        public IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.Tank);
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
