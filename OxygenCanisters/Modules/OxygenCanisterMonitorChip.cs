using System;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Crafting;
using UnityEngine;
using static CraftData;
using System.Diagnostics.CodeAnalysis;

namespace OxygenCanisters.Modules
{
	// Token: 0x02000007 RID: 7
	internal class OxygenCanisterMonitorChip : CustomPrefab
	{
       
        public static TechType TechTypeID { get; protected set; }
       
        [SetsRequiredMembers]
        public OxygenCanisterMonitorChip()
			: base("OxygenCanisterMonitorChip", "Oxygen Canister Monitor Chip", "Oxygen Canister Monitor Chip projects Oxygen canister count and other canister information onto HUD.")
		{
            Console.Write("Checking for installed Mods");
            EnumHandler.TryGetValue("OxygenCanister", out TechType OxygenCanister);
            OxygenCanisterMonitorChip.TechTypeID = base.Info.TechType;
            this.SetPdaGroupCategory(TechGroup.Personal, TechCategory.Equipment);
            this.SetUnlock(TechType.AdvancedWiringKit);
            this.SetEquipment(EquipmentType.Chip).QuickSlotType = QuickSlotType.Passive;
            this.Info.WithIcon(RamuneLib.Utils.ImageUtils.GetSprite("OxygenCanisterMonitorChip"));
            this.SetRecipe(new(new Ingredient(OxygenCanister, 1), new Ingredient(TechType.ComputerChip, 1), new Ingredient(TechType.CopperWire, 1)));
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
        
		public string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
