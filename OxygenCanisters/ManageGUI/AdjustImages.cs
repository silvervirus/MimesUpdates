using System;
using OxygenCanisters.Info;
using Nautilus.Utility;
using UnityEngine;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x02000008 RID: 8
	internal class AdjustImages
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000260C File Offset: 0x0000080C
		public static void AdjustIcon()
		{
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag)
			{
				ManageAllGUIElements.MoveImage(1f, "UpDown");
			}
			bool flag2 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag2)
			{
				ManageAllGUIElements.MoveImage(-1f, "UpDown");
			}
			bool flag3 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
			if (flag3)
			{
				ManageAllGUIElements.MoveImage(-1f, "LeftRight");
			}
			bool flag4 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftShift) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
			if (flag4)
			{
				ManageAllGUIElements.MoveImage(1f, "LeftRight");
			}
			bool flag5 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag5)
			{
				ManageAllGUIElements.ResizeImage(1f, "sizeY");
			}
			bool flag6 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag6)
			{
				ManageAllGUIElements.ResizeImage(-1f, "sizeY");
			}
			bool flag7 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
			if (flag7)
			{
				ManageAllGUIElements.ResizeImage(-1f, "sizeX");
			}
			bool flag8 = KeyCodeUtils.GetKeyHeld(KeyCode.LeftControl) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
			if (flag8)
			{
				ManageAllGUIElements.ResizeImage(1f, "sizeX");
			}
			DisplayPrompts.DisplayHint("UpDown: " + ModInfo.moveUpDownY.ToString(), true);
			DisplayPrompts.DisplayHint(", LeftRight: " + ModInfo.moveLeftRightX.ToString(), true);
			DisplayPrompts.DisplayHint(", Y: " + ModInfo.sizeY.ToString() + " ", false);
			DisplayPrompts.DisplayHint("Size X: " + ModInfo.sizeX.ToString(), false);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000027FC File Offset: 0x000009FC
		public static void AdjustTxt()
		{
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag)
			{
				ManageAllGUIElements.MoveTxt(1f, "UpDown");
			}
			bool flag2 = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag2)
			{
				ManageAllGUIElements.MoveTxt(-1f, "UpDown");
			}
			bool flag3 = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
			if (flag3)
			{
				ManageAllGUIElements.MoveTxt(-1f, "LeftRight");
			}
			bool flag4 = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
			if (flag4)
			{
				ManageAllGUIElements.MoveTxt(1f, "LeftRight");
			}
			bool flag5 = KeyCodeUtils.GetKeyHeld(KeyCode.RightControl) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag5)
			{
				ManageAllGUIElements.ResizeTxt(1f);
			}
			bool flag6 = KeyCodeUtils.GetKeyHeld(KeyCode.RightControl) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag6)
			{
				ManageAllGUIElements.ResizeTxt(-1f);
			}
			DisplayPrompts.DisplayHint("Txt Y: " + ModInfo.canisterY.ToString(), true);
			DisplayPrompts.DisplayHint(", Txt X: " + ModInfo.canisterX.ToString(), true);
			DisplayPrompts.DisplayHint("Font: " + ModInfo.fontSize.ToString(), false);
		}
	}
}
