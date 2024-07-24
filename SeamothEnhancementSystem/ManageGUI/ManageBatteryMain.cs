using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200001C RID: 28
	internal class ManageBatteryMain
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00006438 File Offset: 0x00004638
		internal static void ManageBattery()
		{
			bool flag = SeamothInfo.electricalModuleIn && SeamothInfo.seamothLinkModuleIn;
			if (flag)
			{
				bool flag2 = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.BatterySlotGrayUIGameObject.SetActive(false);
				}
				bool flag3 = ManageAllGUIElements.BatterySlotUIGameObject == null;
				if (flag3)
				{
					ManageAllGUIElements.BatterySlotUIGameObject = PrepareGUIObjects.PrepareGUIObject("BatterySlotUI", GearInfo.battery_Position);
				}
				bool flag4 = ManageAllGUIElements.BatterySlotUIGameObject != null;
				if (flag4)
				{
					ManageAllGUIElements.BatterySlotUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BatterySlotUIGameObject, "battery_slot_100x100", GearInfo.battery_Position, GearInfo.battery_Size);
				}
				bool flag5 = ManageAllGUIElements.BatterySlotUIGameObject != null;
				if (flag5)
				{
					ManageAllGUIElements.BatterySlotUIGameObject.SetActive(true);
				}
				bool flag6 = SeamothInfo.BatteryInSlot == 1;
				if (flag6)
				{
					bool flag7 = ManageAllGUIElements.BatteryUnitUIGameObject == null;
					if (flag7)
					{
						ManageAllGUIElements.BatteryUnitUIGameObject = PrepareGUIObjects.PrepareGUIObject("BatteryUnitUI", GearInfo.battery_Position);
					}
					bool flag8 = ManageAllGUIElements.BatteryUnitUIGameObject != null;
					if (flag8)
					{
						ManageAllGUIElements.BatteryUnitUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BatteryUnitUIGameObject, "battery_unit_100x100", GearInfo.battery_Position, GearInfo.battery_Size);
					}
					bool flag9 = ManageAllGUIElements.BatteryUnitUIGameObject != null;
					if (flag9)
					{
						ManageAllGUIElements.BatteryUnitUIGameObject.SetActive(true);
					}
				}
				else
				{
					bool flag10 = ManageAllGUIElements.BatteryUnitUIGameObject != null;
					if (flag10)
					{
						ManageAllGUIElements.BatteryUnitUIGameObject.SetActive(false);
					}
				}
				bool flag11 = SeamothInfo.TotalBatteryCount == 0;
				if (flag11)
				{
					bool flag12 = ManageAllGUIElements.BatteryArrowsUIGameObject != null;
					if (flag12)
					{
						ManageAllGUIElements.BatteryArrowsUIGameObject.SetActive(false);
					}
					bool flag13 = ManageAllGUIElements.BatteryInUIGameObject != null;
					if (flag13)
					{
						ManageAllGUIElements.BatteryInUIGameObject.SetActive(false);
					}
					bool flag14 = ManageAllGUIElements.BatteryOutUIGameObject != null;
					if (flag14)
					{
						ManageAllGUIElements.BatteryOutUIGameObject.SetActive(false);
					}
				}
				else
				{
					bool flag15 = SeamothInfo.TotalBatteryCount == 1;
					if (flag15)
					{
						bool flag16 = SeamothInfo.BatteryInSlot == 1;
						if (flag16)
						{
							ManageBatteryHelpers.BatteryShowOut();
						}
						else
						{
							ManageBatteryHelpers.BatteryShowIn();
						}
					}
					else
					{
						bool flag17 = SeamothInfo.BatteryInSlot == 1;
						if (flag17)
						{
							ManageBatteryHelpers.BatteryShowArrows();
						}
						else
						{
							ManageBatteryHelpers.BatteryShowIn();
						}
					}
				}
			}
			else
			{
				bool flag18 = ManageAllGUIElements.BatterySlotUIGameObject != null;
				if (flag18)
				{
					ManageAllGUIElements.BatterySlotUIGameObject.SetActive(false);
				}
				bool flag19 = ManageAllGUIElements.BatterySlotGrayUIGameObject == null;
				if (flag19)
				{
					ManageAllGUIElements.BatterySlotGrayUIGameObject = PrepareGUIObjects.PrepareGUIObject("BatterySlotGrayUI", GearInfo.battery_Position);
				}
				bool flag20 = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
				if (flag20)
				{
					ManageAllGUIElements.BatterySlotGrayUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BatterySlotGrayUIGameObject, "battery_slot_gray_100x100", GearInfo.battery_Position, GearInfo.battery_Size);
				}
				bool flag21 = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
				if (flag21)
				{
					ManageAllGUIElements.BatterySlotGrayUIGameObject.SetActive(true);
				}
			}
		}
	}
}
