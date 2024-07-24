using System;
using ToolsFlashLight.Helpers;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.ManageGUI
{
	// Token: 0x02000015 RID: 21
	internal class ManageFlashlightIcons
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00003780 File Offset: 0x00001980
		internal static void ManageFlashlight()
		{
			bool flag = ManageAllGUIElements.ChipNoToolUIGameObject == null;
			if (flag)
			{
				ManageAllGUIElements.ChipNoToolUIGameObject = PrepareGUIObjects.PrepareGUIObject("ChipNoToolUI", ModInfo.flashlightOnOff_Position);
				bool flag2 = ManageAllGUIElements.ChipNoToolUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.ChipNoToolUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ChipNoToolUIGameObject, "ChipNoTool.png", ModInfo.flashlightOnOff_Position, ModInfo.flashlight_Size);
				}
				bool flag3 = ManageAllGUIElements.ChipNoToolUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.ChipNoToolUIGameObject.SetActive(false);
				}
			}
			bool flag4 = ManageAllGUIElements.ToolLightOffUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.ToolLightOffUIGameObject = PrepareGUIObjects.PrepareGUIObject("ToolLightOffUI", ModInfo.flashlightOnOff_Position);
				bool flag5 = ManageAllGUIElements.ToolLightOffUIGameObject != null;
				if (flag5)
				{
					ManageAllGUIElements.ToolLightOffUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ToolLightOffUIGameObject, "ToolLightOff.png", ModInfo.flashlightOnOff_Position, ModInfo.flashlight_Size);
				}
				bool flag6 = ManageAllGUIElements.ToolLightOffUIGameObject != null;
				if (flag6)
				{
					ManageAllGUIElements.ToolLightOffUIGameObject.SetActive(false);
				}
			}
			bool flag7 = ManageAllGUIElements.ToolLightOnUIGameObject == null;
			if (flag7)
			{
				ManageAllGUIElements.ToolLightOnUIGameObject = PrepareGUIObjects.PrepareGUIObject("ToolLightOnUI", ModInfo.flashlightOnOff_Position);
				bool flag8 = ManageAllGUIElements.ToolLightOnUIGameObject != null;
				if (flag8)
				{
					ManageAllGUIElements.ToolLightOnUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.ToolLightOnUIGameObject, "ToolLightOn.png", ModInfo.flashlightOnOff_Position, ModInfo.flashlight_Size);
				}
				bool flag9 = ManageAllGUIElements.ToolLightOnUIGameObject != null;
				if (flag9)
				{
					ManageAllGUIElements.ToolLightOnUIGameObject.SetActive(false);
				}
			}
			bool flag10 = ManageAllGUIElements.ToolLightOffUIGameObject != null && ManageAllGUIElements.ToolLightOnUIGameObject != null;
			if (flag10)
			{
				bool flag11 = CheckConditions.AnyLightChipEquipped() && !Player.main.GetPDA().isInUse && !IngameMenu.main.focused && HandReticle.main.CurrentIconType == HandReticle.IconType.Default;
				if (flag11)
				{
					bool flag12 = CheckConditions.BuilderComboLightOn() || CheckConditions.CutterComboLightOn() || CheckConditions.ScannerComboLightOn() || CheckConditions.WelderComboLightOn();
					if (flag12)
					{
						ManageAllGUIElements.ChipNoToolUIGameObject.SetActive(false);
						ManageAllGUIElements.ToolLightOffUIGameObject.SetActive(false);
						ManageAllGUIElements.ToolLightOnUIGameObject.SetActive(true);
					}
					else
					{
						bool flag13 = CheckConditions.ToolChipAndAnyTool() || CheckConditions.BuilderCombo() || CheckConditions.CutterCombo() || CheckConditions.ScannerCombo() || CheckConditions.WelderCombo();
						if (flag13)
						{
							ManageAllGUIElements.ChipNoToolUIGameObject.SetActive(false);
							ManageAllGUIElements.ToolLightOffUIGameObject.SetActive(true);
							ManageAllGUIElements.ToolLightOnUIGameObject.SetActive(false);
						}
						else
						{
							ManageAllGUIElements.ChipNoToolUIGameObject.SetActive(true);
							ManageAllGUIElements.ToolLightOffUIGameObject.SetActive(false);
							ManageAllGUIElements.ToolLightOnUIGameObject.SetActive(false);
						}
					}
					bool adjustIcon = ModInfo.adjustIcon;
					if (adjustIcon)
					{
						ManageAllGUIElements.SetImageColour(Color.yellow);
					}
					else
					{
						ManageAllGUIElements.SetImageColour(Color.white);
					}
				}
				else
				{
					ManageAllGUIElements.TurnUIOff();
				}
			}
		}
	}
}
