using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ImmersiveOutcropBreak.Modules
{
	// Token: 0x0200000A RID: 10
	internal class BasicShaleGloves : CustomPrefab
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000310D File Offset: 0x0000130D
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003114 File Offset: 0x00001314
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public BasicShaleGloves()
			: base("BasicShaleGloves", "Basic outcrop gloves", "Basic outcrop gloves of simple design, used for breaking outcrops. Wi-Fi capable via Glove Chip.")
		{
			
				BasicShaleGloves.TechTypeID = base.Info.TechType;
                this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
                this.SetUnlock(TechType.FiberMesh);
                CraftDataHandler.SetItemSize(this.Info.TechType, 2, 2);
                this.SetEquipment(EquipmentType.Gloves).QuickSlotType = QuickSlotType.Passive;
                this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("BasicShaleGloves"));
                this.SetRecipe(new(new Ingredient(TechType.FiberMesh, 1), new Ingredient(TechType.Titanium, 1)));
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
