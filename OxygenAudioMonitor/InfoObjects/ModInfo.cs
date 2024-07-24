using System;
using UnityEngine;

namespace OxygenAudioMonitor.InfoObjects
{
	// Token: 0x0200000B RID: 11
	internal class ModInfo
	{
		// Token: 0x0400000B RID: 11
		internal static bool ExtraTabs = false;

		// Token: 0x0400000C RID: 12
		internal static bool isOKtoPlayTankFifty = true;

		// Token: 0x0400000D RID: 13
		internal static bool isOKtoPlayTankTwenty = true;

		// Token: 0x0400000E RID: 14
		internal static bool isOKtoPlayTankTen = true;

		// Token: 0x0400000F RID: 15
		internal static bool colorChangeTrigger = false;

		// Token: 0x04000010 RID: 16
		internal static bool adjustIcon = false;

		// Token: 0x04000011 RID: 17
		internal static float moveUpDownY = -260f;

		// Token: 0x04000012 RID: 18
		internal static float moveLeftRightX = -642f;

		// Token: 0x04000013 RID: 19
		internal static float sizeX = 60f;

		// Token: 0x04000014 RID: 20
		internal static float sizeY = 60f;

		// Token: 0x04000015 RID: 21
		internal static Vector3 earphones_Position = new Vector3(ModInfo.moveLeftRightX, ModInfo.moveUpDownY, 0f);

		// Token: 0x04000016 RID: 22
		internal static Vector2 earphones_PositionV = new Vector2(ModInfo.moveLeftRightX, ModInfo.moveUpDownY);

		// Token: 0x04000017 RID: 23
		internal static Vector2 earphones_Size = new Vector2(ModInfo.sizeX, ModInfo.sizeY);

		// Token: 0x04000018 RID: 24
		internal static string colorWhite = "<color=white>";

		// Token: 0x04000019 RID: 25
		internal static string colorLightGray = "<color=#bfbfbf>";

		// Token: 0x0400001A RID: 26
		internal static string colorDarkGray = "<color=#808080>";

		// Token: 0x0400001B RID: 27
		internal static string colorYellow = "<color=yellow>";

		// Token: 0x0400001C RID: 28
		internal static string colorBlue = "<color=aqua>";

		// Token: 0x0400001D RID: 29
		internal static string colorRed = "<color=red>";

		// Token: 0x0400001E RID: 30
		internal static string colorEnd = "</color>";
	}
}
