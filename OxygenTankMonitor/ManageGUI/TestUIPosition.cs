using System;
using Nautilus.Utility;
using OxygenTankMonitor.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x02000014 RID: 20
	internal class TestUIPosition
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00005890 File Offset: 0x00003A90
		internal static void TestUIPos(GameObject TestUIGameObject, float position, bool adjustMain)
		{
			Image component = TestUIGameObject.GetComponent<Image>();
			ManageAllGUIElements.SetImageColour(Color.yellow, TestUIGameObject);
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag)
			{
				ManageAllGUIElements.MoveImage(1f, "UpDown", TestUIGameObject);
			}
			bool flag2 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag2)
			{
				ManageAllGUIElements.MoveImage(-1f, "UpDown", TestUIGameObject);
			}
			bool flag3 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
			if (flag3)
			{
				ManageAllGUIElements.MoveImage(-1f, "LeftRight", TestUIGameObject);
			}
			bool flag4 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
			if (flag4)
			{
				ManageAllGUIElements.MoveImage(1f, "LeftRight", TestUIGameObject);
			}
			bool flag5 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag5)
			{
				ManageAllGUIElements.ResizeImage(1f, "sizeY", TestUIGameObject);
			}
			bool flag6 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag6)
			{
				ManageAllGUIElements.ResizeImage(-1f, "sizeY", TestUIGameObject);
			}
			bool flag7 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
			if (flag7)
			{
				ManageAllGUIElements.ResizeImage(-1f, "sizeX", TestUIGameObject);
			}
			bool flag8 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
			if (flag8)
			{
				ManageAllGUIElements.ResizeImage(1f, "sizeX", TestUIGameObject);
			}
			if (adjustMain)
			{
				DisplayPrompts.DisplayHint("UpDown: " + ModInfo.iconMainY.ToString(), true);
				DisplayPrompts.DisplayHint(", LeftRight: " + ModInfo.iconMainX.ToString(), true);
				DisplayPrompts.DisplayHint(", Y: " + ModInfo.iconMainSizeY.ToString(), false);
				DisplayPrompts.DisplayHint("Size X: " + ModInfo.iconMainSizeX.ToString(), false);
			}
			else
			{
				DisplayPrompts.DisplayHint("UpDown: " + ModInfo.BGmoveUpDownY.ToString(), true);
				DisplayPrompts.DisplayHint(", LeftRight: " + ModInfo.BGmoveLeftRightX.ToString(), true);
				DisplayPrompts.DisplayHint(", Y: " + ModInfo.BGsizeY.ToString(), false);
				DisplayPrompts.DisplayHint("Size X: " + ModInfo.BGsizeX.ToString(), false);
				ManageTankIcons.PlaceBG(component, position);
			}
		}
	}
}
