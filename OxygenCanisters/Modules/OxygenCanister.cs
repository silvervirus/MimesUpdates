using System;
using System.IO;
using Nautilus.Assets;
using Nautilus.Crafting;
using Nautilus.Handlers;
using Nautilus.Utility;
using UnityEngine;

namespace OxygenCanisters.Modules
{
	// Token: 0x02000006 RID: 6
	internal class OxygenCanister : CustomPrefab
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002394 File Offset: 0x00000594
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000239B File Offset: 0x0000059B
		public static TechType TechTypeID { get; protected set; }

		
		public OxygenCanister()
			: base("OxygenCanister", "Oxygen canister", "O₂: +35\nOxygen from the Brain Coral packaged in a disposable canister.")
		{
			
				OxygenCanister.TechTypeID = base.TechType;
				SurvivalHandler.GiveOxygenOnConsume(OxygenCanister.TechTypeID, 35f, true);
			
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000023F5 File Offset: 0x000005F5
		public override TechGroup GroupForPDA
		{
			get
			{
				return TechGroup.Miscellaneous;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000023F9 File Offset: 0x000005F9
		public override TechCategory CategoryForPDA
		{
			get
			{
				return TechCategory.Misc;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000023FD File Offset: 0x000005FD
		public override TechType RequiredForUnlock
		{
			get
			{
				return TechType.PurpleBrainCoralPiece;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002404 File Offset: 0x00000604
		public override GameObject GetGameObject()
		{
			GameObject prefabForTechType = CraftData.GetPrefabForTechType(TechType.BigFilteredWater, true);
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(prefabForTechType);
			Texture2D texture2D = ImageUtils.LoadTextureFromFile(Path.Combine(MainPatcher.AssetsFolder, "OxygenCanisterTexture.png"), TextureFormat.BC7);
			Renderer componentInChildren = gameObject.GetComponentInChildren<Renderer>(true);
			bool flag = componentInChildren != null;
			if (flag)
			{
				componentInChildren.material.mainTexture = texture2D;
			}
			gameObject.EnsureComponent<Eatable>();
			gameObject.EnsureComponent<ImOxygenCanister>();
			return gameObject;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002474 File Offset: 0x00000674
		protected override TechData GetBlueprintRecipe()
		{
			return new TechData
			{
				craftAmount = 1,
				Ingredients = 
				{
					new Ingredient(TechType.PurpleBrainCoralPiece, 2),
					new Ingredient(TechType.Titanium, 1),
					new Ingredient(TechType.Silicone, 1)
				}
			};
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000024D2 File Offset: 0x000006D2
		public override string AssetsFolder { get; } = MainPatcher.AssetsFolder;
	}
}
