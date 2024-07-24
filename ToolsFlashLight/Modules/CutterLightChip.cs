using System;
using System.Diagnostics.CodeAnalysis;
using Nautilus.Assets;
using Nautilus.Crafting;
using UnityEngine;

namespace ToolsFlashLight.Modules
{
	// Token: 0x0200000F RID: 15
	internal class CutterLightChip : CustomPrefab
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002C4E File Offset: 0x00000E4E
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002C55 File Offset: 0x00000E55
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public CutterLightChip()
			: base("CutterLightChip", "Cutter light chip", "Cutter light chip enables to control built-in LED flashlight module in Laser Cutter.")
		{
			
			CutterLightChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.Compass);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("CutterLightChip"));
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

        public string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
