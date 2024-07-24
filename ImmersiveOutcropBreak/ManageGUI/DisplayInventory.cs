using System;
using HarmonyLib;
using ImmersiveOutcropBreak.Helpers;

namespace ImmersiveOutcropBreak.ManageGUI
{
	// Token: 0x02000013 RID: 19
	internal class DisplayInventory
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00003F04 File Offset: 0x00002104
		public static void DisplayInventoryInfo()
		{
			string value = Traverse.Create(HandReticle.main).Field("interactText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("interactText2").GetValue<string>();
			HandReticle main = HandReticle.main;
			bool flag = CheckConditions.GetInventoryInfo("Space") == 0;
			if (flag)
			{
				bool flag2 = CheckConditions.HiTechGloveChipEquipped();
				if (flag2)
				{
					main.SetTextRaw(HandReticle.TextType.Hand,""+ FormatText.InventoryHiTechFull());
				}
				else
				{
					bool flag3 = CheckConditions.MidTechGloveChipEquipped();
					if (flag3)
					{
						main.SetTextRaw(HandReticle.TextType.Hand, "" + FormatText.InventoryMidTechFull());
					}
					else
					{
						main.SetTextRaw(HandReticle.TextType.Hand,""+ FormatText.InventoryLoTechFull());
					}
				}
			}
			else
			{
				bool flag4 = CheckConditions.HiTechGloveChipEquipped();
				if (flag4)
				{
					main.SetTextRaw(HandReticle.TextType.Hand,value2 + FormatText.InventoryHiTechSpace());
                    main.SetTextRaw(HandReticle.TextType.Hand, value + FormatText.InventoryHiTechSpace());
                }
                

                else
				{
					bool flag5 = CheckConditions.MidTechGloveChipEquipped();
					if (flag5)
					{
                        main.SetTextRaw(HandReticle.TextType.Hand, value2 + FormatText.InventoryHiTechSpace());
                        main.SetTextRaw(HandReticle.TextType.Hand, value + FormatText.InventoryHiTechSpace());
                    }
					else
					{
                        main.SetTextRaw(HandReticle.TextType.Hand, value2 + FormatText.InventoryHiTechSpace());
                        main.SetTextRaw(HandReticle.TextType.Hand, value + FormatText.InventoryHiTechSpace());
                    }
				}
			}
		}
	}
}
