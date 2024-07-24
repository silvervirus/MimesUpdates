using System;
using OxygenAudioMonitor.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenAudioMonitor.ManageGUI
{
	// Token: 0x02000007 RID: 7
	internal class ManageAllGUIElements
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002870 File Offset: 0x00000A70
		internal static void ManageAllGuiElements()
		{
			ManageOxygenIcons.ManageOxygen();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000287C File Offset: 0x00000A7C
		internal static void SetImageColour(Color thisColor)
		{
			bool flag = ManageAllGUIElements.EarphonesUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.EarphonesUIGameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					component.color = thisColor;
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028BC File Offset: 0x00000ABC
		internal static void MoveImage(float moveBy, string thisDirection)
		{
			bool flag = ManageAllGUIElements.EarphonesUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.EarphonesUIGameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					RectTransform component2 = component.GetComponent<RectTransform>();
					bool flag3 = component2 != null;
					if (flag3)
					{
						bool flag4 = thisDirection == "UpDown";
						if (flag4)
						{
							ModInfo.moveUpDownY += moveBy;
						}
						bool flag5 = thisDirection == "LeftRight";
						if (flag5)
						{
							ModInfo.moveLeftRightX += moveBy;
						}
						component2.localPosition = new Vector3(ModInfo.moveLeftRightX, ModInfo.moveUpDownY, 0f);
					}
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002964 File Offset: 0x00000B64
		internal static void ResizeImage(float resizeBy, string thisDimension)
		{
			bool flag = ManageAllGUIElements.EarphonesUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.EarphonesUIGameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					RectTransform component2 = component.GetComponent<RectTransform>();
					bool flag3 = component2 != null;
					if (flag3)
					{
						bool flag4 = thisDimension == "sizeX";
						if (flag4)
						{
							ModInfo.sizeX += resizeBy;
						}
						bool flag5 = thisDimension == "sizeY";
						if (flag5)
						{
							ModInfo.sizeY += resizeBy;
						}
						component2.sizeDelta = new Vector2(ModInfo.sizeX, ModInfo.sizeY);
					}
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A08 File Offset: 0x00000C08
		internal static void TurnUIOff()
		{
			bool flag = ManageAllGUIElements.EarphonesUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.EarphonesUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.EarphonesGlowUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.EarphonesGlowUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.EarphonesHollowUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.EarphonesHollowUIGameObject.SetActive(false);
			}
		}

		// Token: 0x04000006 RID: 6
		public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x04000007 RID: 7
		public static GameObject EarphonesUIGameObject = GameObject.Find("EarphonesUI");

		// Token: 0x04000008 RID: 8
		public static GameObject EarphonesGlowUIGameObject = GameObject.Find("EarphonesGlowUI");

		// Token: 0x04000009 RID: 9
		public static GameObject EarphonesHollowUIGameObject = GameObject.Find("EarphonesHollowUI");
	}
}
