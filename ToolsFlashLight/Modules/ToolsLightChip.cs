using System;
using Nautilus.Assets;
using Nautilus.Crafting;
using ToolsFlashLight.Patches;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;

namespace ToolsFlashLight.Modules
{
	// Token: 0x02000011 RID: 17
	internal class ToolsLightChip : CustomPrefab
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002E3E File Offset: 0x0000103E
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002E45 File Offset: 0x00001045
		public static TechType TechTypeID { get; protected set; }

        [SetsRequiredMembers]
        public ToolsLightChip()
			: base("ToolsLightChip", "Tools light chip", "Tools light chip enables to control built-in LED flashlight module in Habitat Builder, Laser Cutter, and Repair and Scanner Tools.")
		{
			
			ToolsLightChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.Compass);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("ToolsLightChip"));
            this.SetRecipe(new(new Ingredient(BuilderLightChip.TechTypeID, 1), new Ingredient(CutterLightChip.TechTypeID, 1), new Ingredient(ScannerLightChip.TechTypeID, 1), new Ingredient(WelderLightChip.TechTypeID, 1)));
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
