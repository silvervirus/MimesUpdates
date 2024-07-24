using System;
using OxygenCanisters.Info;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x0200000A RID: 10
	internal class ManageAllGUIElements
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002A14 File Offset: 0x00000C14
		internal static void ManageAllGuiElements()
		{
			ManageOxyIcons.ManageOxygenIcons();
			ManageCanisterCountTxt.ManageCanisterCountText();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A24 File Offset: 0x00000C24
		internal static void SetImageColour(Color thisColor)
		{
			bool flag = ManageAllGUIElements.CanisterFullUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.CanisterFullUIGameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					component.color = thisColor;
				}
			}
			bool flag3 = ManageAllGUIElements.CanisterLinesUIGameObject != null;
			if (flag3)
			{
				Image component2 = ManageAllGUIElements.CanisterLinesUIGameObject.GetComponent<Image>();
				bool flag4 = component2 != null;
				if (flag4)
				{
					component2.color = thisColor;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A9C File Offset: 0x00000C9C
		internal static void MoveImage(float moveBy, string thisDirection)
		{
			bool flag = ManageAllGUIElements.CanisterFullUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.CanisterFullUIGameObject.GetComponent<Image>();
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
			bool flag6 = ManageAllGUIElements.CanisterLinesUIGameObject != null;
			if (flag6)
			{
				Image component3 = ManageAllGUIElements.CanisterLinesUIGameObject.GetComponent<Image>();
				bool flag7 = component3 != null;
				if (flag7)
				{
					RectTransform component4 = component3.GetComponent<RectTransform>();
					bool flag8 = component4 != null;
					if (flag8)
					{
						bool flag9 = thisDirection == "UpDown";
						if (flag9)
						{
							ModInfo.moveUpDownY += moveBy;
						}
						bool flag10 = thisDirection == "LeftRight";
						if (flag10)
						{
							ModInfo.moveLeftRightX += moveBy;
						}
						component4.localPosition = new Vector3(ModInfo.moveLeftRightX, ModInfo.moveUpDownY, 0f);
					}
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002BE4 File Offset: 0x00000DE4
		internal static void MoveTxt(float moveBy, string thisDirection)
		{
			bool flag = thisDirection == "UpDown";
			if (flag)
			{
				ModInfo.canisterY += moveBy;
			}
			bool flag2 = thisDirection == "LeftRight";
			if (flag2)
			{
				ModInfo.canisterX += moveBy;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002C28 File Offset: 0x00000E28
		internal static void ResizeImage(float resizeBy, string thisDimension)
		{
			bool flag = ManageAllGUIElements.CanisterFullUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.CanisterFullUIGameObject.GetComponent<Image>();
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
			bool flag6 = ManageAllGUIElements.CanisterLinesUIGameObject != null;
			if (flag6)
			{
				Image component3 = ManageAllGUIElements.CanisterLinesUIGameObject.GetComponent<Image>();
				bool flag7 = component3 != null;
				if (flag7)
				{
					RectTransform component4 = component3.GetComponent<RectTransform>();
					bool flag8 = component4 != null;
					if (flag8)
					{
						bool flag9 = thisDimension == "sizeX";
						if (flag9)
						{
							ModInfo.sizeX += resizeBy;
						}
						bool flag10 = thisDimension == "sizeY";
						if (flag10)
						{
							ModInfo.sizeY += resizeBy;
						}
						component4.sizeDelta = new Vector2(ModInfo.sizeX, ModInfo.sizeY);
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002D66 File Offset: 0x00000F66
		internal static void ResizeTxt(float resizeBy)
		{
			ModInfo.fontSize += resizeBy;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002D78 File Offset: 0x00000F78
		internal static void TurnUIOff()
		{
			bool flag = ManageAllGUIElements.CanisterFullUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.CanisterFullUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.CanisterLinesUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.CanisterLinesUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.CanisterCountTextObject != null;
			if (flag3)
			{
				ManageAllGUIElements.CanisterCountTextObject.SetActive(false);
			}
		}

		// Token: 0x04000008 RID: 8
		public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x04000009 RID: 9
		public static GameObject CanisterFullUIGameObject = GameObject.Find("OxygenCanisterFullUI");

		// Token: 0x0400000A RID: 10
		public static GameObject CanisterLinesUIGameObject = GameObject.Find("OxygenCanisterLinesUI");

		// Token: 0x0400000B RID: 11
		public static GameObject CanisterCountTextObject = GameObject.Find("CanisterCountTextUI");
	}
}
