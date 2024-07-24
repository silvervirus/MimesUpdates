using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200001B RID: 27
	internal class ManageBatteryHelpers
	{
		// Token: 0x0600008F RID: 143 RVA: 0x000061C8 File Offset: 0x000043C8
		internal static void BatteryShowIn()
		{
			bool flag = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.BatterySlotGrayUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BatteryOutUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.BatteryOutUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.BatteryArrowsUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.BatteryArrowsUIGameObject.SetActive(false);
			}
			bool flag4 = ManageAllGUIElements.BatteryInUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.BatteryInUIGameObject = PrepareGUIObjects.PrepareGUIObject("BatteryInUI", GearInfo.battery_Position);
			}
			bool flag5 = ManageAllGUIElements.BatteryInUIGameObject != null;
			if (flag5)
			{
				ManageAllGUIElements.BatteryInUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BatteryInUIGameObject, "battery_in_100x100", GearInfo.battery_Position, GearInfo.battery_Size);
			}
			bool flag6 = ManageAllGUIElements.BatteryInUIGameObject != null;
			if (flag6)
			{
				ManageAllGUIElements.BatteryInUIGameObject.SetActive(true);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006298 File Offset: 0x00004498
		internal static void BatteryShowOut()
		{
			bool flag = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.BatterySlotGrayUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BatteryInUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.BatteryInUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.BatteryArrowsUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.BatteryArrowsUIGameObject.SetActive(false);
			}
			bool flag4 = ManageAllGUIElements.BatteryOutUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.BatteryOutUIGameObject = PrepareGUIObjects.PrepareGUIObject("BatteryOutUI", GearInfo.battery_Position);
			}
			bool flag5 = ManageAllGUIElements.BatteryOutUIGameObject != null;
			if (flag5)
			{
				ManageAllGUIElements.BatteryOutUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BatteryOutUIGameObject, "battery_out_100x100", GearInfo.battery_Position, GearInfo.battery_Size);
			}
			bool flag6 = ManageAllGUIElements.BatteryOutUIGameObject != null;
			if (flag6)
			{
				ManageAllGUIElements.BatteryOutUIGameObject.SetActive(true);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006368 File Offset: 0x00004568
		internal static void BatteryShowArrows()
		{
			bool flag = ManageAllGUIElements.BatterySlotGrayUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.BatterySlotGrayUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BatteryInUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.BatteryInUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.BatteryOutUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.BatteryOutUIGameObject.SetActive(false);
			}
			bool flag4 = ManageAllGUIElements.BatteryArrowsUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.BatteryArrowsUIGameObject = PrepareGUIObjects.PrepareGUIObject("BatteryArrowsUI", GearInfo.battery_Position);
			}
			bool flag5 = ManageAllGUIElements.BatteryArrowsUIGameObject != null;
			if (flag5)
			{
				ManageAllGUIElements.BatteryArrowsUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BatteryArrowsUIGameObject, "battery_arrows_100x100", GearInfo.battery_Position, GearInfo.battery_Size);
			}
			bool flag6 = ManageAllGUIElements.BatteryArrowsUIGameObject != null;
			if (flag6)
			{
				ManageAllGUIElements.BatteryArrowsUIGameObject.SetActive(true);
			}
		}
	}
}
