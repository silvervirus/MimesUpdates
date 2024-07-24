using System;
using HarmonyLib;
using ImmersiveOutcropBreak.Helpers;
using ImmersiveOutcropBreak.Info;

namespace ImmersiveOutcropBreak.Patches
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(Pickupable))]
	[HarmonyPatch("OnHandHover")]
	internal class Pickupable_OnHandHover_Patch
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002B28 File Offset: 0x00000D28
		[HarmonyPostfix]
		public static void Postfix(Pickupable __instance)
		{
			bool flag = CheckConditions.PlayerGlovesEquipped() && CheckConditions.AnyGloveChipEquipped() && !Player.main.IsPiloting();
			if (flag)
			{
				TechType techType = __instance.GetTechType();
				bool isPickupable = __instance.isPickupable;
				bool flag2 = isPickupable;
				if (flag2)
				{
					string text = string.Empty;
					HandReticle main = HandReticle.main;
					bool flag3 = !Player.main.HasInventoryRoom(__instance);
					if (flag3)
					{
						text = Language.main.Get(techType);
						bool flag4 = CheckConditions.HiTechGloveChipEquipped();
						if (flag4)
						{
							main.SetTextRaw(HandReticle.TextType.Hand,text+FormatText.InventoryHiTechFullHover());
						}
						else
						{
							bool flag5 = CheckConditions.MidTechGloveChipEquipped();
							if (flag5)
							{
								main.SetTextRaw(HandReticle.TextType.Hand,text + FormatText.InventoryMidTechFullHover());
							}
							else
							{
								main.SetTextRaw( HandReticle.TextType.Hand,text+ FormatText.InventoryLoTechFullHover());
							}
						}
						HandReticle.main.SetIcon(HandReticle.IconType.Default, 1f);
					}
					else
					{
						text = (__instance.usePackUpIcon ? LanguageCache.GetPackUpText(techType) : LanguageCache.GetPickupText(techType));
						bool flag6 = CheckConditions.HiTechGloveChipEquipped();
						if (flag6)
						{
							main.SetText( HandReticle.TextType.Hand,text+ FormatText.InventoryHiTechSpace(), false, GameInput.Button.LeftHand);
						}
						else
						{
							bool flag7 = CheckConditions.MidTechGloveChipEquipped();
							if (flag7)
							{
								main.SetTextRaw(HandReticle.TextType.Hand, text + FormatText.InventoryMidTechSpace());
							}
							else
							{
								main.SetTextRaw(HandReticle.TextType.Hand, text + FormatText.InventoryLoTechSpace());
							}
						}
					}
					bool flag8 = CheckConditions.PlayerAdvancedGlovesEquipped() && CheckConditions.HiTechGloveChipEquipped() && ModInfo.AutoPickupOn && ModInfo.PickupFreshItem;
					if (flag8)
					{
						Player.main.GetComponent<Inventory>().Pickup(__instance, false);
					}
				}
			}
		}
	}
}
