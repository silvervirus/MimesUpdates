using System;
using OxygenTankMonitor.InfoObjects;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x0200000B RID: 11
	internal class MakeModeGUIObjects
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000029AC File Offset: 0x00000BAC
		internal static void MakeModeObjects()
		{
			bool flag = ManageAllGUIElements.SnorkelOffIconUIGameObject == null;
			if (flag)
			{
				ManageAllGUIElements.SnorkelOffIconUIGameObject = PrepareGUIObjects.PrepareGUIObject("SnorkelOffIconUI", ModInfo.icon_TankPos);
				bool flag2 = ManageAllGUIElements.SnorkelOffIconUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.SnorkelOffIconUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.SnorkelOffIconUIGameObject, "SnorkelOffIcon.png", ModInfo.icon_ScubaPos, ModInfo.icon_ScubaSize);
				}
				bool flag3 = ManageAllGUIElements.SnorkelOffIconUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.SnorkelOffIconUIGameObject.SetActive(false);
				}
			}
			bool flag4 = ManageAllGUIElements.SnorkelOnIconUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.SnorkelOnIconUIGameObject = PrepareGUIObjects.PrepareGUIObject("SnorkelOnIconUI", ModInfo.icon_TankPos);
				bool flag5 = ManageAllGUIElements.SnorkelOnIconUIGameObject != null;
				if (flag5)
				{
					ManageAllGUIElements.SnorkelOnIconUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.SnorkelOnIconUIGameObject, "SnorkelOnIcon.png", ModInfo.icon_ScubaPos, ModInfo.icon_ScubaSize);
				}
				bool flag6 = ManageAllGUIElements.SnorkelOnIconUIGameObject != null;
				if (flag6)
				{
					ManageAllGUIElements.SnorkelOnIconUIGameObject.SetActive(false);
				}
			}
			bool flag7 = ManageAllGUIElements.SnorkelUnableIconUIGameObject == null;
			if (flag7)
			{
				ManageAllGUIElements.SnorkelUnableIconUIGameObject = PrepareGUIObjects.PrepareGUIObject("SnorkelUnableIconUI", ModInfo.icon_TankPos);
				bool flag8 = ManageAllGUIElements.SnorkelUnableIconUIGameObject != null;
				if (flag8)
				{
					ManageAllGUIElements.SnorkelUnableIconUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.SnorkelUnableIconUIGameObject, "SnorkelUnableIcon.png", ModInfo.icon_ScubaPos, ModInfo.icon_ScubaSize);
				}
				bool flag9 = ManageAllGUIElements.SnorkelUnableIconUIGameObject != null;
				if (flag9)
				{
					ManageAllGUIElements.SnorkelUnableIconUIGameObject.SetActive(false);
				}
			}
			bool flag10 = ManageAllGUIElements.TankIconMainUIGameObject == null;
			if (flag10)
			{
				ManageAllGUIElements.TankIconMainUIGameObject = PrepareGUIObjects.PrepareGUIObject("TankIconMainUI", ModInfo.icon_TankPos);
				bool flag11 = ManageAllGUIElements.TankIconMainUIGameObject != null;
				if (flag11)
				{
					ManageAllGUIElements.TankIconMainUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.TankIconMainUIGameObject, "TankIconMain.png", ModInfo.icon_TankPos, ModInfo.icon_TankSize);
				}
				bool flag12 = ManageAllGUIElements.TankIconMainUIGameObject != null;
				if (flag12)
				{
					ManageAllGUIElements.TankIconMainUIGameObject.SetActive(false);
				}
			}
			bool flag13 = ManageAllGUIElements.ScubaMainfoldIconUIGameObject == null;
			if (flag13)
			{
				ManageAllGUIElements.ScubaMainfoldIconUIGameObject = PrepareGUIObjects.PrepareGUIObject("ScubaMainfoldIconUI", ModInfo.icon_MFoldPos);
				bool flag14 = ManageAllGUIElements.ScubaMainfoldIconUIGameObject != null;
				if (flag14)
				{
					ManageAllGUIElements.ScubaMainfoldIconUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ScubaMainfoldIconUIGameObject, "ScubaManifoldIcon.png", ModInfo.icon_MFoldPos, ModInfo.icon_MFoldSize);
				}
				bool flag15 = ManageAllGUIElements.ScubaMainfoldIconUIGameObject != null;
				if (flag15)
				{
					ManageAllGUIElements.ScubaMainfoldIconUIGameObject.SetActive(false);
				}
			}
		}
	}
}
