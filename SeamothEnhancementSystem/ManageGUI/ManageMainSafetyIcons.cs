using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000027 RID: 39
	internal class ManageMainSafetyIcons
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00009104 File Offset: 0x00007304
		internal static void ManageMainSafety()
		{
			bool safetyModuleIn = SeamothInfo.safetyModuleIn;
			if (safetyModuleIn)
			{
				bool flag = SeamothInfo.electronicModuleIn && SeamothInfo.seamothLinkModuleIn;
				if (flag)
				{
					bool flag2 = ManageAllGUIElements.MainSafetyGrayUIGameObject != null;
					if (flag2)
					{
						ManageAllGUIElements.MainSafetyGrayUIGameObject.SetActive(false);
					}
					bool flag3 = ManageAllGUIElements.MainSafetyUIGameObject == null;
					if (flag3)
					{
						ManageAllGUIElements.MainSafetyUIGameObject = PrepareGUIObjects.PrepareGUIObject("MainSafetyUI", GearInfo.main_Safety_Position);
					}
					bool flag4 = ManageAllGUIElements.MainSafetyUIGameObject != null;
					if (flag4)
					{
						ManageAllGUIElements.MainSafetyUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.MainSafetyUIGameObject, "safety_main_on_100x100", GearInfo.main_Safety_Position, GearInfo.main_Safety_Size);
					}
					bool flag5 = ManageAllGUIElements.MainSafetyUIGameObject != null;
					if (flag5)
					{
						ManageAllGUIElements.MainSafetyUIGameObject.SetActive(true);
					}
				}
				else
				{
					bool flag6 = ManageAllGUIElements.MainSafetyUIGameObject != null;
					if (flag6)
					{
						ManageAllGUIElements.MainSafetyUIGameObject.SetActive(false);
					}
					bool flag7 = ManageAllGUIElements.MainSafetyGrayUIGameObject == null;
					if (flag7)
					{
						ManageAllGUIElements.MainSafetyGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("MainSafetyGrayUI", GearInfo.main_Safety_Position);
					}
					bool flag8 = ManageAllGUIElements.MainSafetyGrayUIGameObject != null;
					if (flag8)
					{
						ManageAllGUIElements.MainSafetyGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.MainSafetyGrayUIGameObject, "safety_main_gray_100x100", GearInfo.main_Safety_Position, GearInfo.main_Safety_Size);
					}
					bool flag9 = ManageAllGUIElements.MainSafetyGrayUIGameObject != null;
					if (flag9)
					{
						ManageAllGUIElements.MainSafetyGrayUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag10 = ManageAllGUIElements.MainSafetyUIGameObject != null;
				if (flag10)
				{
					ManageAllGUIElements.MainSafetyUIGameObject.SetActive(false);
				}
				bool flag11 = ManageAllGUIElements.MainSafetyGrayUIGameObject != null;
				if (flag11)
				{
					ManageAllGUIElements.MainSafetyGrayUIGameObject.SetActive(false);
				}
			}
		}
	}
}
