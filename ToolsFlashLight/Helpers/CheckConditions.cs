using System;
using ToolsFlashLight.InfoObjects;
using ToolsFlashLight.Modules;

namespace ToolsFlashLight.Helpers
{
	// Token: 0x0200001F RID: 31
	internal class CheckConditions
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00004254 File Offset: 0x00002454
		public static bool BuilderCombo()
		{
			return ModInfo.BuilderToolIsUsed && CheckConditions.BuilderLightChipEquipped();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004278 File Offset: 0x00002478
		public static bool BuilderComboLightOn()
		{
			return ModInfo.BuilderToolIsUsed && ModInfo.BuilderLightOn;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000429C File Offset: 0x0000249C
		public static bool CutterCombo()
		{
			return ModInfo.CutterToolIsUsed && CheckConditions.CutterLightChipEquipped();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000042C0 File Offset: 0x000024C0
		public static bool CutterComboLightOn()
		{
			return ModInfo.CutterToolIsUsed && ModInfo.CutterLightOn;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000042E4 File Offset: 0x000024E4
		public static bool ScannerCombo()
		{
			return ModInfo.ScannerToolIsUsed && CheckConditions.ScannerLightChipEquipped();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004308 File Offset: 0x00002508
		public static bool ScannerComboLightOn()
		{
			return ModInfo.ScannerToolIsUsed && ModInfo.ScannerLightOn;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000432C File Offset: 0x0000252C
		public static bool WelderCombo()
		{
			return ModInfo.WelderToolIsUsed && CheckConditions.WelderLightChipEquipped();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004350 File Offset: 0x00002550
		public static bool WelderComboLightOn()
		{
			return ModInfo.WelderToolIsUsed && ModInfo.WelderLightOn;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004374 File Offset: 0x00002574
		public static bool ToolChipAndAnyTool()
		{
			return ModInfo.AnyLEDToolIsUsed && CheckConditions.ToolsLightChipEquipped();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004398 File Offset: 0x00002598
		public static bool BuilderLightChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(BuilderLightChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000043D8 File Offset: 0x000025D8
		public static bool CutterLightChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(CutterLightChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004418 File Offset: 0x00002618
		public static bool ScannerLightChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(ScannerLightChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004458 File Offset: 0x00002658
		public static bool WelderLightChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(WelderLightChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004498 File Offset: 0x00002698
		public static bool ToolsLightChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(ToolsLightChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000044D8 File Offset: 0x000026D8
		public static bool AnyLightChipEquipped()
		{
			int num = 0;
			bool flag = Player.main != null;
			if (flag)
			{
				num += Inventory.main.equipment.GetCount(BuilderLightChip.TechTypeID);
				num += Inventory.main.equipment.GetCount(CutterLightChip.TechTypeID);
				num += Inventory.main.equipment.GetCount(ScannerLightChip.TechTypeID);
				num += Inventory.main.equipment.GetCount(WelderLightChip.TechTypeID);
				num += Inventory.main.equipment.GetCount(ToolsLightChip.TechTypeID);
			}
			return num > 0;
		}
	}
}
