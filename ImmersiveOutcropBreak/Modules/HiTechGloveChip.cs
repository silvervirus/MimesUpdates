using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ImmersiveOutcropBreak.Modules
{
	// Token: 0x0200000E RID: 14
	internal class HiTechGloveChip : CustomPrefab
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003516 File Offset: 0x00001716
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000351D File Offset: 0x0000171D
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public HiTechGloveChip()
			: base("HiTechGloveChip", "HiTech glove chip", "HiTech glove chip links up with gloves via Wi-Fi. When used with advanced shale gloves, it enables powerful acoustic blasts breaking the outcrop instantly. It also projects hi tech information about inventory and pickupable items to the HUD.")
		{
			
				HiTechGloveChip.TechTypeID = base.Info.TechType;
                this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
                this.SetUnlock(MidTechGloveChip.TechTypeID);
                this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
                this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("HiTechGloveChip"));
                this.SetRecipe(new(new Ingredient(MidTechGloveChip.TechTypeID, 1), new Ingredient(TechType.ComputerChip, 1)));
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
