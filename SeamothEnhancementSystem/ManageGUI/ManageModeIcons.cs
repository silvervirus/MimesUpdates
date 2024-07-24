using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000029 RID: 41
	internal class ManageModeIcons
	{
		// Token: 0x060000AD RID: 173 RVA: 0x0000942C File Offset: 0x0000762C
		internal static void ManageMode()
		{
			bool flag = SeamothInfo.electronicModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag)
			{
				bool modeGreenOn = SeamothInfo.ModeGreenOn;
				if (modeGreenOn)
				{
					bool flag2 = ManageAllGUIElements.ModeGrayUIGameObject != null;
					if (flag2)
					{
						ManageAllGUIElements.ModeGrayUIGameObject.SetActive(false);
					}
					bool flag3 = ManageAllGUIElements.ModeTurboUIGameObject != null;
					if (flag3)
					{
						ManageAllGUIElements.ModeTurboUIGameObject.SetActive(false);
					}
					bool flag4 = ManageAllGUIElements.ModeGreenUIGameObject == null;
					if (flag4)
					{
						ManageAllGUIElements.ModeGreenUIGameObject = PrepareGUIObjects.PrepareGUIObject("ModeGreenUI", GearInfo.mode_Position);
					}
					bool flag5 = ManageAllGUIElements.ModeGreenUIGameObject != null;
					if (flag5)
					{
						ManageAllGUIElements.ModeGreenUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ModeGreenUIGameObject, "mode_green_100x100", GearInfo.mode_Position, GearInfo.mode_Size);
					}
					bool flag6 = ManageAllGUIElements.ModeGreenUIGameObject != null;
					if (flag6)
					{
						ManageAllGUIElements.ModeGreenUIGameObject.SetActive(true);
					}
				}
				else
				{
					bool flag7 = ManageAllGUIElements.ModeGrayUIGameObject != null;
					if (flag7)
					{
						ManageAllGUIElements.ModeGrayUIGameObject.SetActive(false);
					}
					bool flag8 = ManageAllGUIElements.ModeGreenUIGameObject != null;
					if (flag8)
					{
						ManageAllGUIElements.ModeGreenUIGameObject.SetActive(false);
					}
					bool flag9 = ManageAllGUIElements.ModeTurboUIGameObject == null;
					if (flag9)
					{
						ManageAllGUIElements.ModeTurboUIGameObject = PrepareGUIObjects.PrepareGUIObject("ModeTurboUI", GearInfo.mode_Position);
					}
					bool flag10 = ManageAllGUIElements.ModeTurboUIGameObject != null;
					if (flag10)
					{
						ManageAllGUIElements.ModeTurboUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ModeTurboUIGameObject, "mode_turbo_100x100", GearInfo.mode_Position, GearInfo.mode_Size);
					}
					bool flag11 = ManageAllGUIElements.ModeTurboUIGameObject != null;
					if (flag11)
					{
						ManageAllGUIElements.ModeTurboUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag12 = ManageAllGUIElements.ModeGreenUIGameObject != null;
				if (flag12)
				{
					ManageAllGUIElements.ModeGreenUIGameObject.SetActive(false);
				}
				bool flag13 = ManageAllGUIElements.ModeTurboUIGameObject != null;
				if (flag13)
				{
					ManageAllGUIElements.ModeTurboUIGameObject.SetActive(false);
				}
				bool flag14 = ManageAllGUIElements.ModeGrayUIGameObject == null;
				if (flag14)
				{
					ManageAllGUIElements.ModeGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("ModeGrayUI", GearInfo.mode_Position);
				}
				bool flag15 = ManageAllGUIElements.ModeGrayUIGameObject != null;
				if (flag15)
				{
					ManageAllGUIElements.ModeGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ModeGrayUIGameObject, "mode_gray_100x100", GearInfo.mode_Position, GearInfo.mode_Size);
				}
				bool flag16 = ManageAllGUIElements.ModeGrayUIGameObject != null;
				if (flag16)
				{
					ManageAllGUIElements.ModeGrayUIGameObject.SetActive(true);
				}
			}
		}
	}
}
