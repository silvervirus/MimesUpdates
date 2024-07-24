using System;
using System.Collections.Generic;
using ImmersiveOutcropBreak.Modules;

namespace ImmersiveOutcropBreak.Helpers
{
	// Token: 0x0200001B RID: 27
	internal class CheckConditions
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00004420 File Offset: 0x00002620
		public static bool ToolIsReady()
		{
			PlayerTool heldTool = Inventory.main.GetHeldTool();
			bool flag = heldTool != null;
			return flag && heldTool.hasBashAnimation;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004454 File Offset: 0x00002654
		public static bool PlayerGlovesEquipped()
		{
			return Inventory.main.equipment.GetItemInSlot("Gloves") != null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004480 File Offset: 0x00002680
		public static bool PlayerBasicGlovesEquipped()
		{
			return Inventory.main.equipment.GetTechTypeInSlot("Gloves") == BasicShaleGloves.TechTypeID;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000044B0 File Offset: 0x000026B0
		public static bool PlayerStandardGlovesEquipped()
		{
			return Inventory.main.equipment.GetTechTypeInSlot("Gloves") == StandardShaleGloves.TechTypeID;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000044E0 File Offset: 0x000026E0
		public static bool PlayerAdvancedGlovesEquipped()
		{
			return Inventory.main.equipment.GetTechTypeInSlot("Gloves") == AdvancedShaleGloves.TechTypeID;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004510 File Offset: 0x00002710
		public static bool LoTechGloveChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(LoTechGloveChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004550 File Offset: 0x00002750
		public static bool MidTechGloveChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(MidTechGloveChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004590 File Offset: 0x00002790
		public static bool HiTechGloveChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(HiTechGloveChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000045D0 File Offset: 0x000027D0
		public static bool AnyGloveChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				bool flag3 = main.equipment.GetCount(LoTechGloveChip.TechTypeID) > 0;
				bool flag4 = main.equipment.GetCount(MidTechGloveChip.TechTypeID) > 0;
				bool flag5 = main.equipment.GetCount(HiTechGloveChip.TechTypeID) > 0;
				flag = flag3 || flag4 || flag5;
			}
			return flag;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004644 File Offset: 0x00002844
		public static bool AnyOutcropGlovesOn()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				bool flag3 = CheckConditions.PlayerBasicGlovesEquipped();
				bool flag4 = CheckConditions.PlayerStandardGlovesEquipped();
				bool flag5 = CheckConditions.PlayerAdvancedGlovesEquipped();
				flag = flag3 || flag4 || flag5;
			}
			return flag;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004688 File Offset: 0x00002888
		public static int GetInventoryInfo(string infoRequired)
		{
			bool flag = !Player.main.HasInventoryRoom(1, 1) && infoRequired == "Space";
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				Inventory component = Player.main.GetComponent<Inventory>();
				int sizeX = component.container.sizeX;
				int sizeY = component.container.sizeY;
				int num2 = sizeY * sizeX;
				List<TechType> itemTypes = component.container.GetItemTypes();
				int num3 = 0;
				foreach (TechType techType in itemTypes)
				{
					Vector2int itemSize = CraftData.GetItemSize(techType);
					int count = component.container.GetItems(techType).Count;
					num3 += itemSize.x * itemSize.y * count;
				}
				bool flag2 = infoRequired == "Size";
				if (flag2)
				{
					num = num2;
				}
				else
				{
					num = num2 - num3;
				}
			}
			return num;
		}
	}
}
