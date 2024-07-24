using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x02000022 RID: 34
	internal class ManageGearsIcons
	{
		// Token: 0x0600009F RID: 159 RVA: 0x000081C0 File Offset: 0x000063C0
		internal static void ManageGears()
		{
			bool flag = SeamothInfo.mechanicalModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag)
			{
				bool flag2 = Config.SeamothGearValue == 6f;
				if (flag2)
				{
					bool flag3 = ManageAllGUIElements.CogsGrayUIGameObject != null;
					if (flag3)
					{
						ManageAllGUIElements.CogsGrayUIGameObject.SetActive(false);
					}
					bool flag4 = ManageAllGUIElements.CogsBlueUIGameObject != null;
					if (flag4)
					{
						ManageAllGUIElements.CogsBlueUIGameObject.SetActive(false);
					}
					bool flag5 = ManageAllGUIElements.CogsYellowUIGameObject != null;
					if (flag5)
					{
						ManageAllGUIElements.CogsYellowUIGameObject.SetActive(false);
					}
					bool flag6 = ManageAllGUIElements.CogsRedUIGameObject == null;
					if (flag6)
					{
						ManageAllGUIElements.CogsRedUIGameObject = PrepareGUIObjects.PrepareGUIObject("CogsRedUI", GearInfo.cogs_Position);
					}
					bool flag7 = ManageAllGUIElements.CogsRedUIGameObject != null;
					if (flag7)
					{
						ManageAllGUIElements.CogsRedUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CogsRedUIGameObject, "cogs_red_100x100", GearInfo.cogs_Position, GearInfo.cogs_Size);
					}
					bool flag8 = ManageAllGUIElements.CogsRedUIGameObject != null;
					if (flag8)
					{
						ManageAllGUIElements.CogsRedUIGameObject.SetActive(true);
					}
				}
				bool flag9 = Config.SeamothGearValue == 5f;
				if (flag9)
				{
					bool flag10 = ManageAllGUIElements.CogsGrayUIGameObject != null;
					if (flag10)
					{
						ManageAllGUIElements.CogsGrayUIGameObject.SetActive(false);
					}
					bool flag11 = ManageAllGUIElements.CogsBlueUIGameObject != null;
					if (flag11)
					{
						ManageAllGUIElements.CogsBlueUIGameObject.SetActive(false);
					}
					bool flag12 = ManageAllGUIElements.CogsRedUIGameObject != null;
					if (flag12)
					{
						ManageAllGUIElements.CogsRedUIGameObject.SetActive(false);
					}
					bool flag13 = ManageAllGUIElements.CogsYellowUIGameObject == null;
					if (flag13)
					{
						ManageAllGUIElements.CogsYellowUIGameObject = PrepareGUIObjects.PrepareGUIObject("CogsYellowUI", GearInfo.cogs_Position);
					}
					bool flag14 = ManageAllGUIElements.CogsYellowUIGameObject != null;
					if (flag14)
					{
						ManageAllGUIElements.CogsYellowUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CogsYellowUIGameObject, "cogs_yellow_100x100", GearInfo.cogs_Position, GearInfo.cogs_Size);
					}
					bool flag15 = ManageAllGUIElements.CogsYellowUIGameObject != null;
					if (flag15)
					{
						ManageAllGUIElements.CogsYellowUIGameObject.SetActive(true);
					}
				}
				bool flag16 = Config.SeamothGearValue < 5f;
				if (flag16)
				{
					bool flag17 = ManageAllGUIElements.CogsGrayUIGameObject != null;
					if (flag17)
					{
						ManageAllGUIElements.CogsGrayUIGameObject.SetActive(false);
					}
					bool flag18 = ManageAllGUIElements.CogsYellowUIGameObject != null;
					if (flag18)
					{
						ManageAllGUIElements.CogsYellowUIGameObject.SetActive(false);
					}
					bool flag19 = ManageAllGUIElements.CogsRedUIGameObject != null;
					if (flag19)
					{
						ManageAllGUIElements.CogsRedUIGameObject.SetActive(false);
					}
					bool flag20 = ManageAllGUIElements.CogsBlueUIGameObject == null;
					if (flag20)
					{
						ManageAllGUIElements.CogsBlueUIGameObject = PrepareGUIObjects.PrepareGUIObject("CogsBlueUI", GearInfo.cogs_Position);
					}
					bool flag21 = ManageAllGUIElements.CogsBlueUIGameObject != null;
					if (flag21)
					{
						ManageAllGUIElements.CogsBlueUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CogsBlueUIGameObject, "cogs_blue_100x100", GearInfo.cogs_Position, GearInfo.cogs_Size);
					}
					bool flag22 = ManageAllGUIElements.CogsBlueUIGameObject != null;
					if (flag22)
					{
						ManageAllGUIElements.CogsBlueUIGameObject.SetActive(true);
					}
				}
			}
			else
			{
				bool flag23 = ManageAllGUIElements.CogsBlueUIGameObject != null;
				if (flag23)
				{
					ManageAllGUIElements.CogsBlueUIGameObject.SetActive(false);
				}
				bool flag24 = ManageAllGUIElements.CogsYellowUIGameObject != null;
				if (flag24)
				{
					ManageAllGUIElements.CogsYellowUIGameObject.SetActive(false);
				}
				bool flag25 = ManageAllGUIElements.CogsRedUIGameObject != null;
				if (flag25)
				{
					ManageAllGUIElements.CogsRedUIGameObject.SetActive(false);
				}
				bool flag26 = ManageAllGUIElements.CogsGrayUIGameObject == null;
				if (flag26)
				{
					ManageAllGUIElements.CogsGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("CogsGrayUI", GearInfo.cogs_Position);
				}
				bool flag27 = ManageAllGUIElements.CogsGrayUIGameObject != null;
				if (flag27)
				{
					ManageAllGUIElements.CogsGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CogsGrayUIGameObject, "cogs_gray_100x100", GearInfo.cogs_Position, GearInfo.cogs_Size);
				}
				bool flag28 = ManageAllGUIElements.CogsGrayUIGameObject != null;
				if (flag28)
				{
					ManageAllGUIElements.CogsGrayUIGameObject.SetActive(true);
				}
			}
		}
	}
}
