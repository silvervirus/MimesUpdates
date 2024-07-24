using System;
using System.IO;
using System.Linq;
using HarmonyLib;
using ImmersiveOutcropBreak.Modules;
using Nautilus.Utility;
using UnityEngine;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace ImmersiveOutcropBreak.Patches
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Awake")]
	internal class Player_Awake_Patch
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002CA8 File Offset: 0x00000EA8
		[HarmonyPostfix]
		public static void Postfix(Player __instance)
		{
			int num = 0;
			for (int i = 0; i < __instance.equipmentModels.Length; i++)
			{
				bool flag = __instance.equipmentModels[i].slot == "Gloves";
				if (flag)
				{
					num = i;
					break;
				}
			}
			Player.EquipmentModel equipmentModel = __instance.equipmentModels[num].equipment.First((Player.EquipmentModel x) => x.techType == TechType.ReinforcedGloves);
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(equipmentModel.model, equipmentModel.model.transform.position, equipmentModel.model.transform.rotation, equipmentModel.model.transform.parent);
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(equipmentModel.model, equipmentModel.model.transform.position, equipmentModel.model.transform.rotation, equipmentModel.model.transform.parent);
			GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(equipmentModel.model, equipmentModel.model.transform.position, equipmentModel.model.transform.rotation, equipmentModel.model.transform.parent);
			Texture2D texture2D = ImageUtils.LoadTextureFromFile(Path.Combine(MainPatcher.AssetsFolder, "BasicGlovesTexture.png"), TextureFormat.BC7);
			Texture2D texture2D2 = ImageUtils.LoadTextureFromFile(Path.Combine(MainPatcher.AssetsFolder, "StandardGlovesTexture.png"), TextureFormat.BC7);
			Texture2D texture2D3 = ImageUtils.LoadTextureFromFile(Path.Combine(MainPatcher.AssetsFolder, "AdvancedGlovesTexture.png"), TextureFormat.BC7);
			Renderer component = gameObject.GetComponent<Renderer>();
			component.material.mainTexture = texture2D;
			Renderer component2 = gameObject2.GetComponent<Renderer>();
			component2.material.mainTexture = texture2D2;
			Renderer component3 = gameObject3.GetComponent<Renderer>();
			component3.material.mainTexture = texture2D3;
			Player.EquipmentModel equipmentModel2 = new Player.EquipmentModel
			{
				techType = BasicShaleGloves.TechTypeID,
				model = gameObject
			};
			Player.EquipmentModel equipmentModel3 = new Player.EquipmentModel
			{
				techType = StandardShaleGloves.TechTypeID,
				model = gameObject2
			};
			Player.EquipmentModel equipmentModel4 = new Player.EquipmentModel
			{
				techType = AdvancedShaleGloves.TechTypeID,
				model = gameObject3
			};
			Array.Resize<Player.EquipmentModel>(ref __instance.equipmentModels[num].equipment, __instance.equipmentModels[num].equipment.Length + 1);
			__instance.equipmentModels[num].equipment[__instance.equipmentModels[num].equipment.Length - 1] = equipmentModel2;
			Array.Resize<Player.EquipmentModel>(ref __instance.equipmentModels[num].equipment, __instance.equipmentModels[num].equipment.Length + 1);
			__instance.equipmentModels[num].equipment[__instance.equipmentModels[num].equipment.Length - 1] = equipmentModel3;
			Array.Resize<Player.EquipmentModel>(ref __instance.equipmentModels[num].equipment, __instance.equipmentModels[num].equipment.Length + 1);
			__instance.equipmentModels[num].equipment[__instance.equipmentModels[num].equipment.Length - 1] = equipmentModel4;
		}
	}
}
