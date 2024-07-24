using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200001A RID: 26
	internal class ManageBackgroundImg
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00006088 File Offset: 0x00004288
		internal static void ManageBackground()
		{
			bool flag = SeamothInfo.electricalModuleIn || SeamothInfo.electronicModuleIn || SeamothInfo.mechanicalModuleIn;
			if (flag)
			{
				bool flag2 = ManageAllGUIElements.BackgroundUIGameObject == null;
				if (flag2)
				{
					ManageAllGUIElements.BackgroundUIGameObject = PrepareGUIObjects.PrepareGUIObject("BackgroundUI", GearInfo.gear_txt_Position);
				}
				bool flag3 = ManageAllGUIElements.BackgroundUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.BackgroundUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackgroundUIGameObject, "background_343x104", GearInfo.background_Position, GearInfo.background_Size);
				}
				bool flag4 = ManageAllGUIElements.BackgroundUIGameObject != null;
				if (flag4)
				{
					ManageAllGUIElements.BackgroundUIGameObject.SetActive(true);
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006120 File Offset: 0x00004320
		internal static void ManageSafetyBackground()
		{
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
			{
				bool flag = ManageAllGUIElements.BackgroundSafetyUIGameObject == null;
				if (flag)
				{
					ManageAllGUIElements.BackgroundSafetyUIGameObject = PrepareGUIObjects.PrepareGUIObject("BackgroundSafetyUI", GearInfo.gear_txt_Position);
				}
				bool flag2 = ManageAllGUIElements.BackgroundSafetyUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.BackgroundSafetyUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BackgroundSafetyUIGameObject, "safetybackground_444x446", GearInfo.background_Safety_Position, GearInfo.background_Safety_Size);
				}
				bool flag3 = ManageAllGUIElements.BackgroundSafetyUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.BackgroundSafetyUIGameObject.SetActive(true);
				}
			}
			else
			{
				bool flag4 = ManageAllGUIElements.BackgroundSafetyUIGameObject != null;
				if (flag4)
				{
					ManageAllGUIElements.BackgroundSafetyUIGameObject.SetActive(false);
				}
			}
		}
	}
}
