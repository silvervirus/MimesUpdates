using System;
using ToolsFlashLight.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace ToolsFlashLight.ManageGUI
{
	// Token: 0x02000014 RID: 20
	internal class ManageAllGUIElements
	{
		// Token: 0x0600005B RID: 91 RVA: 0x000032BB File Offset: 0x000014BB
		internal static void ManageAllGuiElements()
		{
			ManageFlashlightIcons.ManageFlashlight();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000032C4 File Offset: 0x000014C4
		internal static void SetImageColour(Color thisColor)
		{
			bool flag = ManageAllGUIElements.ToolLightOnUIGameObject != null && ManageAllGUIElements.ToolLightOffUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.ToolLightOnUIGameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					component.color = thisColor;
				}
				Image component2 = ManageAllGUIElements.ToolLightOffUIGameObject.GetComponent<Image>();
				bool flag3 = component2 != null;
				if (flag3)
				{
					component2.color = thisColor;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003334 File Offset: 0x00001534
		internal static void MoveImage(float moveBy, string thisDirection)
		{
			bool flag = ManageAllGUIElements.ToolLightOffUIGameObject != null && ManageAllGUIElements.ToolLightOnUIGameObject != null && ManageAllGUIElements.ChipNoToolUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.ChipNoToolUIGameObject.GetComponent<Image>();
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
							ModInfo.onOffLeftRightX += moveBy;
						}
						component2.localPosition = new Vector3(ModInfo.onOffLeftRightX, ModInfo.moveUpDownY, 0f);
					}
				}
				Image component3 = ManageAllGUIElements.ToolLightOffUIGameObject.GetComponent<Image>();
				bool flag6 = component3 != null;
				if (flag6)
				{
					RectTransform component4 = component3.GetComponent<RectTransform>();
					bool flag7 = component4 != null;
					if (flag7)
					{
						bool flag8 = thisDirection == "UpDown";
						if (flag8)
						{
							ModInfo.moveUpDownY += moveBy;
						}
						bool flag9 = thisDirection == "LeftRight";
						if (flag9)
						{
							ModInfo.onOffLeftRightX += moveBy;
						}
						component4.localPosition = new Vector3(ModInfo.onOffLeftRightX, ModInfo.moveUpDownY, 0f);
					}
				}
				Image component5 = ManageAllGUIElements.ToolLightOnUIGameObject.GetComponent<Image>();
				bool flag10 = component5 != null;
				if (flag10)
				{
					RectTransform component6 = component5.GetComponent<RectTransform>();
					bool flag11 = component6 != null;
					if (flag11)
					{
						bool flag12 = thisDirection == "UpDown";
						if (flag12)
						{
							ModInfo.moveUpDownY += moveBy;
						}
						bool flag13 = thisDirection == "LeftRight";
						if (flag13)
						{
							ModInfo.onOffLeftRightX += moveBy;
						}
						component6.localPosition = new Vector3(ModInfo.onOffLeftRightX, ModInfo.moveUpDownY, 0f);
					}
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000350C File Offset: 0x0000170C
		internal static void ResizeImage(float resizeBy, string thisDimension)
		{
			bool flag = ManageAllGUIElements.ToolLightOffUIGameObject != null && ManageAllGUIElements.ToolLightOnUIGameObject != null && ManageAllGUIElements.ChipNoToolUIGameObject != null;
			if (flag)
			{
				Image component = ManageAllGUIElements.ChipNoToolUIGameObject.GetComponent<Image>();
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
				Image component3 = ManageAllGUIElements.ToolLightOffUIGameObject.GetComponent<Image>();
				bool flag6 = component3 != null;
				if (flag6)
				{
					RectTransform component4 = component3.GetComponent<RectTransform>();
					bool flag7 = component4 != null;
					if (flag7)
					{
						bool flag8 = thisDimension == "sizeX";
						if (flag8)
						{
							ModInfo.sizeX += resizeBy;
						}
						bool flag9 = thisDimension == "sizeY";
						if (flag9)
						{
							ModInfo.sizeY += resizeBy;
						}
						component4.sizeDelta = new Vector2(ModInfo.sizeX, ModInfo.sizeY);
					}
				}
				Image component5 = ManageAllGUIElements.ToolLightOnUIGameObject.GetComponent<Image>();
				bool flag10 = component5 != null;
				if (flag10)
				{
					RectTransform component6 = component5.GetComponent<RectTransform>();
					bool flag11 = component6 != null;
					if (flag11)
					{
						bool flag12 = thisDimension == "sizeX";
						if (flag12)
						{
							ModInfo.sizeX += resizeBy;
						}
						bool flag13 = thisDimension == "sizeY";
						if (flag13)
						{
							ModInfo.sizeY += resizeBy;
						}
						component6.sizeDelta = new Vector2(ModInfo.sizeX, ModInfo.sizeY);
					}
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000036D8 File Offset: 0x000018D8
		internal static void TurnUIOff()
		{
			bool flag = ManageAllGUIElements.ChipNoToolUIGameObject != null;
			if (flag)
			{
				ManageAllGUIElements.ChipNoToolUIGameObject.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.ToolLightOffUIGameObject != null;
			if (flag2)
			{
				ManageAllGUIElements.ToolLightOffUIGameObject.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.ToolLightOnUIGameObject != null;
			if (flag3)
			{
				ManageAllGUIElements.ToolLightOnUIGameObject.SetActive(false);
			}
		}

		// Token: 0x0400000E RID: 14
		public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x0400000F RID: 15
		public static GameObject ChipNoToolUIGameObject = GameObject.Find("ChipNoToolUI");

		// Token: 0x04000010 RID: 16
		public static GameObject ToolLightOffUIGameObject = GameObject.Find("ToolLightOffUI");

		// Token: 0x04000011 RID: 17
		public static GameObject ToolLightOnUIGameObject = GameObject.Find("ToolLightOnUI");
	}
}
