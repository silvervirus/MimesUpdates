using System;
using MoreModifiedItems.BasicEquipment;
using OxygenTankMonitor.InfoObjects;
using OxygenTankMonitor.Modules;

namespace OxygenTankMonitor.Helpers
{
	// Token: 0x02000016 RID: 22
	internal class CheckConditions
	{
		
        public static bool TankChipEquipped()
		{
			return CheckConditions.CheckChipPresence(OxygenTankMonitorChip.TechTypeID);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public static bool SnorkelChipEquipped()
		{
			return CheckConditions.CheckChipPresence(SnorkelModeChip.TechTypeID);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005E10 File Offset: 0x00004010
		public static bool ComboChipEquipped()
		{
			return CheckConditions.CheckChipPresence(ComboChip.TechTypeID);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005E2C File Offset: 0x0000402C
		public static bool SnorkOrComboChipEquipped()
		{
			return CheckConditions.SnorkelChipEquipped() || CheckConditions.ComboChipEquipped();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005E50 File Offset: 0x00004050
		public static bool TankOrComboChipEquipped()
		{
			return CheckConditions.TankChipEquipped() || CheckConditions.ComboChipEquipped();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005E74 File Offset: 0x00004074
		public static bool AnyChipEquipped()
		{
			return CheckConditions.TankChipEquipped() || CheckConditions.SnorkelChipEquipped() || CheckConditions.ComboChipEquipped();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005E9C File Offset: 0x0000409C
		public static bool CheckChipPresence(TechType thisTechType)
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				bool flag3 = main != null;
				if (flag3)
				{
					flag = main.equipment.GetCount(thisTechType) > 0;
				}
			}
			return flag;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005EE8 File Offset: 0x000040E8
		public static bool TankEquipped()
		{
			bool flag = !ModInfo.ScubaManifold;
			bool flag2;
			if (flag)
			{
				flag2 = Inventory.main.equipment.GetItemInSlot("Tank") != null;
			}
			else
			{
				bool flag3 = CheckConditions.TankOrScubaManifold() == "Tank";
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005F3C File Offset: 0x0000413C
		public static bool ScubaManifoldEquipped()
		{
			bool flag = !ModInfo.ScubaManifold;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = CheckConditions.TankOrScubaManifold() == "ScubaManifold";
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005F78 File Offset: 0x00004178
		public static string TankOrScubaManifold()
		{
			InventoryItem itemInSlot = Inventory.main.equipment.GetItemInSlot("Tank");
			bool flag = itemInSlot != null;
			string text;
			if (flag)
			{
				bool scubaManifold = ModInfo.ScubaManifold;
				if (scubaManifold)
				{
					bool flag2 = itemInSlot.item.GetTechType() == ScubaManifold.Instance.Info.TechType;
					if (flag2)
					{
						text = "ScubaManifold";
					}
					else
					{
						text = "Tank";
					}
				}
				else
				{
					text = "Tank";
				}
			}
			else
			{
				text = "None";
			}
			return text;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005FEC File Offset: 0x000041EC
		public static bool TankSlotFull()
		{
			return Inventory.main.equipment.GetItemInSlot("Tank") != null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006018 File Offset: 0x00004218
		public static bool PlayerSwimming()
		{
			return Player.main.motorMode == Player.MotorMode.Dive || Player.main.motorMode == Player.MotorMode.Seaglide;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006048 File Offset: 0x00004248
		public static bool InSnorkelDepth()
		{
			return Player.main.GetDepth() < ModInfo.snorkelDepthDown;
		}
	}
}
