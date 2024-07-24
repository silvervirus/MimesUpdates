using System;
using System.Threading.Tasks;
using OxygenAudioMonitor.Helpers;
using OxygenAudioMonitor.InfoObjects;
using UnityEngine;

namespace OxygenAudioMonitor.ManageGUI
{
	// Token: 0x02000008 RID: 8
	internal class ManageOxygenIcons
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002AB0 File Offset: 0x00000CB0
		internal static void ManageOxygen()
		{
			bool flag = ManageAllGUIElements.EarphonesUIGameObject == null;
			if (flag)
			{
				ManageAllGUIElements.EarphonesUIGameObject = PrepareGUIObjects.PrepareGUIObject("EarphonesUI", ModInfo.earphones_Position);
				bool flag2 = ManageAllGUIElements.EarphonesUIGameObject != null;
				if (flag2)
				{
					ManageAllGUIElements.EarphonesUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EarphonesUIGameObject, "earphones_full.png", ModInfo.earphones_Position, ModInfo.earphones_Size);
				}
				bool flag3 = ManageAllGUIElements.EarphonesUIGameObject != null;
				if (flag3)
				{
					ManageAllGUIElements.EarphonesUIGameObject.SetActive(false);
				}
			}
			bool flag4 = ManageAllGUIElements.EarphonesGlowUIGameObject == null;
			if (flag4)
			{
				ManageAllGUIElements.EarphonesGlowUIGameObject = PrepareGUIObjects.PrepareGUIObject("EarphonesGlowUI", ModInfo.earphones_Position);
				bool flag5 = ManageAllGUIElements.EarphonesGlowUIGameObject != null;
				if (flag5)
				{
					ManageAllGUIElements.EarphonesGlowUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EarphonesGlowUIGameObject, "earphones_glow.png", ModInfo.earphones_Position, ModInfo.earphones_Size);
				}
				bool flag6 = ManageAllGUIElements.EarphonesGlowUIGameObject != null;
				if (flag6)
				{
					ManageAllGUIElements.EarphonesGlowUIGameObject.SetActive(false);
				}
			}
			bool flag7 = ManageAllGUIElements.EarphonesHollowUIGameObject == null;
			if (flag7)
			{
				ManageAllGUIElements.EarphonesHollowUIGameObject = PrepareGUIObjects.PrepareGUIObject("EarphonesHollowUI", ModInfo.earphones_Position);
				bool flag8 = ManageAllGUIElements.EarphonesHollowUIGameObject != null;
				if (flag8)
				{
					ManageAllGUIElements.EarphonesHollowUIGameObject = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.EarphonesHollowUIGameObject, "earphones_hollow.png", ModInfo.earphones_Position, ModInfo.earphones_Size);
				}
				bool flag9 = ManageAllGUIElements.EarphonesHollowUIGameObject != null;
				if (flag9)
				{
					ManageAllGUIElements.EarphonesHollowUIGameObject.SetActive(false);
				}
			}
			bool flag10 = ManageAllGUIElements.EarphonesUIGameObject != null && ManageAllGUIElements.EarphonesGlowUIGameObject != null;
			if (flag10)
			{
				bool flag11 = CheckConditions.AudioChipEquipped();
				if (flag11)
				{
					bool colorChangeTrigger = ModInfo.colorChangeTrigger;
					if (colorChangeTrigger)
					{
						ManageAllGUIElements.EarphonesUIGameObject.SetActive(false);
						ManageAllGUIElements.EarphonesGlowUIGameObject.SetActive(true);
						ManageAllGUIElements.EarphonesHollowUIGameObject.SetActive(true);
						ManageOxygenIcons.ColorToDefault(2500);
					}
					else
					{
						bool flag12 = !CheckConditions.PlayerTankEquipped();
						if (flag12)
						{
							ManageAllGUIElements.EarphonesUIGameObject.SetActive(false);
							ManageAllGUIElements.EarphonesGlowUIGameObject.SetActive(false);
							ManageAllGUIElements.EarphonesHollowUIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.white);
						}
						else
						{
							bool adjustIcon = ModInfo.adjustIcon;
							if (adjustIcon)
							{
								ManageAllGUIElements.EarphonesUIGameObject.SetActive(true);
								ManageAllGUIElements.EarphonesGlowUIGameObject.SetActive(false);
								ManageAllGUIElements.EarphonesHollowUIGameObject.SetActive(false);
								ManageAllGUIElements.SetImageColour(Color.yellow);
							}
							else
							{
								ManageAllGUIElements.EarphonesUIGameObject.SetActive(true);
								ManageAllGUIElements.EarphonesGlowUIGameObject.SetActive(false);
								ManageAllGUIElements.EarphonesHollowUIGameObject.SetActive(false);
								ManageAllGUIElements.SetImageColour(Color.white);
							}
						}
					}
				}
				else
				{
					ManageAllGUIElements.TurnUIOff();
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002D40 File Offset: 0x00000F40
		internal static async void ColorToDefault(int thisDelay)
		{
			await System.Threading.Tasks.Task.Delay(thisDelay);
			ModInfo.colorChangeTrigger = false;
		}
	}
}
