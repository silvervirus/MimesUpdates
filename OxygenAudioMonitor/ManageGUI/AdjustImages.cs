using System;
using OxygenAudioMonitor.InfoObjects;
using Nautilus.Utility;
using UnityEngine;

namespace OxygenAudioMonitor.ManageGUI
{
	// Token: 0x02000005 RID: 5
	internal class AdjustImages
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000025D4 File Offset: 0x000007D4
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
			DisplayPrompts.DisplayHint(", Y: " + ModInfo.sizeY.ToString(), false);
			DisplayPrompts.DisplayHint("Size X: " + ModInfo.sizeX.ToString(), false);
		}
	}
}
