using System;
using OxygenTankMonitor.Helpers;
using OxygenTankMonitor.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x0200000D RID: 13
	internal class ManageAllGUIElements
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00003994 File Offset: 0x00001B94
		internal static void ManageAllGuiElements()
		{
			bool flag = CheckConditions.TankOrComboChipEquipped();
			if (flag)
			{
				ManageTankIcons.ManageTanks();
			}
			else
			{
				ManageAllGUIElements.TurnUIOff("Tanks");
			}
			bool flag2 = CheckConditions.AnyChipEquipped();
			if (flag2)
			{
				ManageModeIcons.ManageMode();
			}
			else
			{
				ManageAllGUIElements.TurnUIOff("Main");
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000039DC File Offset: 0x00001BDC
		internal static void SetImageColour(Color thisColor, GameObject TestUIGameObject)
		{
			bool flag = TestUIGameObject != null;
			if (flag)
			{
				Image component = TestUIGameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					component.color = thisColor;
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003A14 File Offset: 0x00001C14
		internal static void MoveImage(float moveBy, string thisDirection, GameObject TestUIGameObject)
		{
			bool flag = TestUIGameObject != null;
			if (flag)
			{
				Image component = TestUIGameObject.GetComponent<Image>();
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
							ModInfo.BGmoveUpDownY += moveBy;
						}
						bool flag5 = thisDirection == "LeftRight";
						if (flag5)
						{
							ModInfo.BGmoveLeftRightX += moveBy;
						}
						component2.localPosition = new Vector3(ModInfo.BGmoveLeftRightX, ModInfo.BGmoveUpDownY, 0f);
					}
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003AB4 File Offset: 0x00001CB4
		internal static void ResizeImage(float resizeBy, string thisDimension, GameObject TestUIGameObject)
		{
			bool flag = TestUIGameObject != null;
			if (flag)
			{
				Image component = TestUIGameObject.GetComponent<Image>();
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
							ModInfo.BGsizeX += resizeBy;
						}
						bool flag5 = thisDimension == "sizeY";
						if (flag5)
						{
							ModInfo.BGsizeY += resizeBy;
						}
						component2.sizeDelta = new Vector2(ModInfo.BGsizeX, ModInfo.BGsizeY);
					}
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003B4C File Offset: 0x00001D4C
		internal static void TurnUIOff(string thisUI)
		{
			bool flag = thisUI == "Main";
			if (flag)
			{
				bool flag2 = ManageModeIcons.UI_MainIconsOK();
				if (flag2)
				{
					ManageModeIcons.TurnMainUIoff();
				}
			}
			bool flag3 = thisUI == "Tanks";
			if (flag3)
			{
				bool flag4 = ManageTankIcons.UI_BG_ObjsOK();
				if (flag4)
				{
					ManageTankIcons.TurnBGUIoff();
				}
				bool flag5 = ManageTankIcons.UI_Tank_ObjsOK();
				if (flag5)
				{
					ManageTankIcons.TurnTankUIoff();
				}
				bool flag6 = ManageTankIcons.UI_Bar_ObjsOK();
				if (flag6)
				{
					ManageTankIcons.TurnBarUIoff();
				}
				bool flag7 = ManageTankIcons.UI_TxtObjectsOK();
				if (flag7)
				{
					ManageTankIcons.TurnTxtUIoff();
				}
			}
		}

		// Token: 0x0400000A RID: 10
		public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x0400000B RID: 11
		public static GameObject BGleftUIGameObject = GameObject.Find("BGleftUI");

		// Token: 0x0400000C RID: 12
		public static GameObject BGrightUIGameObject = GameObject.Find("BGrightUI");

		// Token: 0x0400000D RID: 13
		public static GameObject BGc01UIGameObject = GameObject.Find("BGc01UI");

		// Token: 0x0400000E RID: 14
		public static GameObject BGc02UIGameObject = GameObject.Find("BGc02UI");

		// Token: 0x0400000F RID: 15
		public static GameObject BGc03UIGameObject = GameObject.Find("BGc03UI");

		// Token: 0x04000010 RID: 16
		public static GameObject BGc04UIGameObject = GameObject.Find("BGc04UI");

		// Token: 0x04000011 RID: 17
		public static GameObject BGsingleUIGameObject = GameObject.Find("BGsingleUI");

		// Token: 0x04000012 RID: 18
		public static GameObject SnorkelOffIconUIGameObject = GameObject.Find("SnorkelOffIconUI");

		// Token: 0x04000013 RID: 19
		public static GameObject SnorkelOnIconUIGameObject = GameObject.Find("SnorkelOnIconUI");

		// Token: 0x04000014 RID: 20
		public static GameObject SnorkelUnableIconUIGameObject = GameObject.Find("SnorkelUnableIconUI");

		// Token: 0x04000015 RID: 21
		public static GameObject TankIconMainUIGameObject = GameObject.Find("TankIconMainUI");

		// Token: 0x04000016 RID: 22
		public static GameObject ScubaMainfoldIconUIGameObject = GameObject.Find("ScubaMainfoldIconUI");

		// Token: 0x04000017 RID: 23
		public static GameObject TankIconMoni00UIGameObject = GameObject.Find("TankIconMoni00UI");

		// Token: 0x04000018 RID: 24
		public static GameObject TankIconMoni01UIGameObject = GameObject.Find("TankIconMoni01UI");

		// Token: 0x04000019 RID: 25
		public static GameObject TankIconMoni02UIGameObject = GameObject.Find("TankIconMoni02UI");

		// Token: 0x0400001A RID: 26
		public static GameObject TankIconMoni03UIGameObject = GameObject.Find("TankIconMoni03UI");

		// Token: 0x0400001B RID: 27
		public static GameObject TankIconMoni04UIGameObject = GameObject.Find("TankIconMoni04UI");

		// Token: 0x0400001C RID: 28
		public static GameObject TankIconMoni05UIGameObject = GameObject.Find("TankIconMoni05UI");

		// Token: 0x0400001D RID: 29
		public static GameObject TankBarMoni00UIGameObject = GameObject.Find("TankBarMoni00UI");

		// Token: 0x0400001E RID: 30
		public static GameObject TankBarMoni01UIGameObject = GameObject.Find("TankBarMoni01UI");

		// Token: 0x0400001F RID: 31
		public static GameObject TankBarMoni02UIGameObject = GameObject.Find("TankBarMoni02UI");

		// Token: 0x04000020 RID: 32
		public static GameObject TankBarMoni03UIGameObject = GameObject.Find("TankBarMoni03UI");

		// Token: 0x04000021 RID: 33
		public static GameObject TankBarMoni04UIGameObject = GameObject.Find("TankBarMoni04UI");

		// Token: 0x04000022 RID: 34
		public static GameObject TankBarMoni05UIGameObject = GameObject.Find("TankBarMoni05UI");

		// Token: 0x04000023 RID: 35
		public static GameObject TankTextObj00 = GameObject.Find("TankTextUI00");

		// Token: 0x04000024 RID: 36
		public static GameObject TankTextObj01 = GameObject.Find("TankTextUI01");

		// Token: 0x04000025 RID: 37
		public static GameObject TankTextObj02 = GameObject.Find("TankTextUI02");

		// Token: 0x04000026 RID: 38
		public static GameObject TankTextObj03 = GameObject.Find("TankTextUI03");

		// Token: 0x04000027 RID: 39
		public static GameObject TankTextObj04 = GameObject.Find("TankTextUI04");

		// Token: 0x04000028 RID: 40
		public static GameObject TankTextObj05 = GameObject.Find("TankTextUI05");
	}
}
