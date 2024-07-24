using System;
using OxygenCanisters.Helpers;
using OxygenCanisters.Info;
using UnityEngine;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x0200000C RID: 12
	internal class ManageOxyIcons
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002EE0 File Offset: 0x000010E0
		internal static void ManageOxygenIcons()
		{
			bool flag = ManageAllGUIElements.CanisterFullUIGameObject == null;
			if (flag)
			{
				ManageAllGUIElements.CanisterFullUIGameObject = PrepareGUIObjects.PrepareGUIObject("OxygenCanisterUI", ModInfo.canister_Position);
				bool flag2 = ManageAllGUIElements.CanisterFullUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.CanisterFullUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CanisterFullUIGameObject, "OxygenCanisterIconFull.png", ModInfo.canister_Position, ModInfo.canister_Size);
				}
				bool flag3 = ManageAllGUIElements.CanisterFullUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.CanisterFullUIGameObject.SetActive(false);
				}
			}
			bool flag4 = ManageAllGUIElements.CanisterLinesUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.CanisterLinesUIGameObject = PrepareGUIObjects.PrepareGUIObject("OxygenCanisterUI", ModInfo.canister_Position);
				bool flag5 = ManageAllGUIElements.CanisterLinesUIGameObject != null;
				if (flag5)
				{
					ManageAllGUIElements.CanisterLinesUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.CanisterLinesUIGameObject, "OxygenCanisterIconLines.png", ModInfo.canister_Position, ModInfo.canister_Size);
				}
				bool flag6 = ManageAllGUIElements.CanisterLinesUIGameObject != null;
				if (flag6)
				{
					ManageAllGUIElements.CanisterLinesUIGameObject.SetActive(false);
				}
			}
			bool flag7 = ManageAllGUIElements.CanisterFullUIGameObject != null && ManageAllGUIElements.CanisterLinesUIGameObject != null;
			if (flag7)
			{
				bool adjustIcon = ModInfo.adjustIcon;
				if (adjustIcon)
				{
					ManageAllGUIElements.SetImageColour(Color.yellow);
				}
				else
				{
					ManageAllGUIElements.SetImageColour(Color.white);
				}
				bool flag8 = CheckConditions.OxygenCanisterInInventory() > 0 && Player.main.GetOxygenAvailable().IsBetween(0f, ModInfo.consumeOxyTrigger);
				if (flag8)
				{
					ManageAllGUIElements.CanisterFullUIGameObject.SetActive(true);
					ManageAllGUIElements.CanisterLinesUIGameObject.SetActive(false);
				}
				else
				{
					ManageAllGUIElements.CanisterFullUIGameObject.SetActive(false);
					ManageAllGUIElements.CanisterLinesUIGameObject.SetActive(true);
				}
			}
		}
	}
}
