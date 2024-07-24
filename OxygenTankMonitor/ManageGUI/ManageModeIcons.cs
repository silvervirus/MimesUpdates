using System;
using OxygenTankMonitor.Helpers;
using OxygenTankMonitor.InfoObjects;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x0200000E RID: 14
	internal class ManageModeIcons
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003DB8 File Offset: 0x00001FB8
		internal static void ManageMode()
		{
			MakeModeGUIObjects.MakeModeObjects();
			bool flag = ManageModeIcons.UI_MainIconsOK();
			if (flag)
			{
				bool flag2 = CheckConditions.ComboChipEquipped();
				if (flag2)
				{
					ManageModeIcons.ProcessCombo();
				}
				else
				{
					bool flag3 = CheckConditions.TankChipEquipped() && CheckConditions.SnorkelChipEquipped();
					if (flag3)
					{
						ManageModeIcons.ProcessCombo();
					}
					else
					{
						bool flag4 = CheckConditions.TankChipEquipped();
						if (flag4)
						{
							bool flag5 = CheckConditions.TankEquipped();
							if (flag5)
							{
								ManageModeIcons.ShowTank();
							}
							else
							{
								bool flag6 = CheckConditions.ScubaManifoldEquipped();
								if (flag6)
								{
									ManageModeIcons.ShowMainfold();
								}
								else
								{
									ManageModeIcons.TurnMainUIoff();
								}
							}
						}
						else
						{
							bool flag7 = CheckConditions.SnorkelChipEquipped();
							if (flag7)
							{
								bool flag8 = CheckConditions.TankSlotFull();
								if (flag8)
								{
									ManageModeIcons.ShowSnorkelUnable();
								}
								else
								{
									bool snorkelMode = ModInfo.SnorkelMode;
									if (snorkelMode)
									{
										ManageModeIcons.ShowSnorkelOn();
									}
									else
									{
										ManageModeIcons.ShowSnorkelOff();
									}
								}
							}
							else
							{
								ManageModeIcons.TurnMainUIoff();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003E88 File Offset: 0x00002088
		internal static bool UI_MainIconsOK()
		{
			bool flag = ManageAllGUIElements.SnorkelOnIconUIGameObject != null;
			bool flag2 = ManageAllGUIElements.SnorkelOffIconUIGameObject != null;
			bool flag3 = ManageAllGUIElements.SnorkelUnableIconUIGameObject != null;
			bool flag4 = ManageAllGUIElements.TankIconMainUIGameObject != null;
			bool flag5 = ManageAllGUIElements.ScubaMainfoldIconUIGameObject != null;
			return flag && flag2 && flag3 && flag4 && flag5;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003EE4 File Offset: 0x000020E4
		internal static void ProcessCombo()
		{
			bool flag = CheckConditions.TankEquipped();
			if (flag)
			{
				ManageModeIcons.ShowTank();
			}
			else
			{
				bool flag2 = CheckConditions.ScubaManifoldEquipped();
				if (flag2)
				{
					ManageModeIcons.ShowMainfold();
				}
				else
				{
					bool snorkelMode = ModInfo.SnorkelMode;
					if (snorkelMode)
					{
						ManageModeIcons.ShowSnorkelOn();
					}
					else
					{
						ManageModeIcons.ShowSnorkelOff();
					}
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003F2D File Offset: 0x0000212D
		internal static void ShowSnorkelOff()
		{
			ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(true);
			ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMainUIGameObject.SetActive(false);
			ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(false);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003F6C File Offset: 0x0000216C
		internal static void ShowSnorkelOn()
		{
			ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(true);
			ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMainUIGameObject.SetActive(false);
			ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(false);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003FAB File Offset: 0x000021AB
		internal static void ShowSnorkelUnable()
		{
			ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(true);
			ManageAllGUIElements.TankIconMainUIGameObject.SetActive(false);
			ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(false);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003FEA File Offset: 0x000021EA
		internal static void ShowTank()
		{
			ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMainUIGameObject.SetActive(true);
			ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(false);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004029 File Offset: 0x00002229
		internal static void ShowMainfold()
		{
			ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMainUIGameObject.SetActive(false);
			ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(true);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004068 File Offset: 0x00002268
		internal static void TurnMainUIoff()
		{
			ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(false);
			ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMainUIGameObject.SetActive(false);
			ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(false);
		}
	}
}
