using System;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenCanisters.Info
{
	// Token: 0x02000012 RID: 18
	internal class ModInfo
	{
		// Token: 0x0400000E RID: 14
		internal static bool ExtraTabs = false;

		// Token: 0x0400000F RID: 15
		internal static bool OxygenAudioMonitor = false;

		// Token: 0x04000010 RID: 16
		internal static int numberOfCanisters = 0;

		// Token: 0x04000011 RID: 17
		internal static bool isOKtoPlayBase = true;

		// Token: 0x04000012 RID: 18
		internal static bool isOKtoPlayTankFifty = true;

		// Token: 0x04000013 RID: 19
		internal static bool isOKtoPlayTankThirty = true;

		// Token: 0x04000014 RID: 20
		internal static bool isOKtoPlayTankTwenty = true;

		// Token: 0x04000015 RID: 21
		internal static bool isOKtoPlayTankTen = true;

		// Token: 0x04000016 RID: 22
		internal static bool runConsumption = false;

		// Token: 0x04000017 RID: 23
		internal static Text countDisplayText;

		// Token: 0x04000018 RID: 24
		internal static GameObject gameObject;

		// Token: 0x04000019 RID: 25
		internal static float consumeOxyTrigger = 30f;

		// Token: 0x0400001A RID: 26
		internal static bool adjustIcon = false;

		// Token: 0x0400001B RID: 27
		internal static bool adjustText = false;

		// Token: 0x0400001C RID: 28
		internal static bool colorChangeTrigger = false;

		// Token: 0x0400001D RID: 29
		internal static float moveLeftRightX = -770f;

		// Token: 0x0400001E RID: 30
		internal static float moveUpDownY = -295f;

		// Token: 0x0400001F RID: 31
		internal static float sizeX = 38f;

		// Token: 0x04000020 RID: 32
		internal static float sizeY = 38f;

		// Token: 0x04000021 RID: 33
		internal static Vector3 canister_Position = new Vector3(ModInfo.moveLeftRightX, ModInfo.moveUpDownY, 0f);

		// Token: 0x04000022 RID: 34
		internal static Vector2 canister_Size = new Vector2(ModInfo.sizeX, ModInfo.sizeY);

		// Token: 0x04000023 RID: 35
		internal static float canisterX = -769f;

		// Token: 0x04000024 RID: 36
		internal static float canisterY = -319f;

		// Token: 0x04000025 RID: 37
		internal static float canisterSizeX = 100f;

		// Token: 0x04000026 RID: 38
		internal static float canisterSizeY = 100f;

		// Token: 0x04000027 RID: 39
		internal static float fontSize = 15f;

		// Token: 0x04000028 RID: 40
		internal static Vector3 count_txt_Position = new Vector3(ModInfo.canisterX, ModInfo.canisterY, 0f);

		// Token: 0x04000029 RID: 41
		internal static Vector2 count_txt_Size = new Vector2(ModInfo.canisterSizeX, ModInfo.canisterSizeY);

		// Token: 0x0400002A RID: 42
		internal static string colorWhite = "<color=white>";

		// Token: 0x0400002B RID: 43
		internal static string colorLightGray = "<color=#bfbfbf>";

		// Token: 0x0400002C RID: 44
		internal static string colorDarkGray = "<color=#808080>";

		// Token: 0x0400002D RID: 45
		internal static string colorYellow = "<color=yellow>";

		// Token: 0x0400002E RID: 46
		internal static string colorBlue = "<color=aqua>";

		// Token: 0x0400002F RID: 47
		internal static string colorRed = "<color=red>";

		// Token: 0x04000030 RID: 48
		internal static string colorEnd = "</color>";
	}
}
