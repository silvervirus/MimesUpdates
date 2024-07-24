using System;
using UnityEngine;

namespace OxygenTankMonitor.InfoObjects
{
	// Token: 0x02000015 RID: 21
	internal class ModInfo
	{
		// Token: 0x0400002A RID: 42
		internal static bool ExtraTabs = false;

		// Token: 0x0400002B RID: 43
		internal static bool OxygenAudioMonitor = false;

		// Token: 0x0400002C RID: 44
		internal static bool OxygenCanisters = false;

		// Token: 0x0400002D RID: 45
		internal static bool ScubaManifold = false;

		// Token: 0x0400002E RID: 46
		internal static bool ToolsFlashLight = false;

		// Token: 0x0400002F RID: 47
		internal static bool SnorkelMode = false;

		// Token: 0x04000030 RID: 48
		internal static float timer = 0f;

		// Token: 0x04000031 RID: 49
		internal static float resetTimer = 0.5f;

		// Token: 0x04000032 RID: 50
		internal static float snorkelDepthDown = 2.5f;

		// Token: 0x04000033 RID: 51
		internal static float snorkelDepthUp = 0.5f;

		// Token: 0x04000034 RID: 52
		internal static float consumeOxyTrigger = 30f;

		// Token: 0x04000035 RID: 53
		internal static bool adjustIcon = false;

		// Token: 0x04000036 RID: 54
		internal static bool adjustText = false;

		// Token: 0x04000037 RID: 55
		internal static bool colorChangeTrigger = false;

		// Token: 0x04000038 RID: 56
		internal static float BGmoveLeftRightX = -864f;

		// Token: 0x04000039 RID: 57
		internal static float BGmoveUpDownY = -185f;

		// Token: 0x0400003A RID: 58
		internal static float BGsizeX = 80f;

		// Token: 0x0400003B RID: 59
		internal static float BGsizeY = 80f;

		// Token: 0x0400003C RID: 60
		internal static Vector3 BG_Position = new Vector3(ModInfo.BGmoveLeftRightX, ModInfo.BGmoveUpDownY, 0f);

		// Token: 0x0400003D RID: 61
		internal static Vector2 BG_Size = new Vector2(ModInfo.BGsizeX, ModInfo.BGsizeY);

		// Token: 0x0400003E RID: 62
		internal static float icon_TankMoniX = ModInfo.BGmoveLeftRightX + 14f;

		// Token: 0x0400003F RID: 63
		internal static float icon_TankMoniY = ModInfo.BGmoveUpDownY + 1f;

		// Token: 0x04000040 RID: 64
		internal static Vector3 icon_TankMoniPos = new Vector3(ModInfo.icon_TankMoniX, ModInfo.icon_TankMoniY, 0f);

		// Token: 0x04000041 RID: 65
		internal static Vector2 icon_TankMoniSize = new Vector2(ModInfo.BGsizeX - 30f, ModInfo.BGsizeY - 35f);

		// Token: 0x04000042 RID: 66
		internal static float icon_TankBarX = ModInfo.BGmoveLeftRightX + 15f;

		// Token: 0x04000043 RID: 67
		internal static float icon_TankBarY = ModInfo.BGmoveUpDownY - 16f;

		// Token: 0x04000044 RID: 68
		internal static Vector3 icon_TankBarPos = new Vector3(ModInfo.icon_TankBarX, ModInfo.icon_TankBarY, 0f);

		// Token: 0x04000045 RID: 69
		internal static Vector2 icon_TankBarSize = new Vector2(ModInfo.BGsizeX - 73f, ModInfo.BGsizeY - 53f);

		// Token: 0x04000046 RID: 70
		internal static float iconMainX = -670f;

		// Token: 0x04000047 RID: 71
		internal static float iconMainY = -220f;

		// Token: 0x04000048 RID: 72
		internal static float iconMainSizeX = 60f;

		// Token: 0x04000049 RID: 73
		internal static float iconMainSizeY = 60f;

		// Token: 0x0400004A RID: 74
		internal static Vector3 icon_ScubaPos = new Vector3(ModInfo.iconMainX, ModInfo.iconMainY, 0f);

		// Token: 0x0400004B RID: 75
		internal static Vector2 icon_ScubaSize = new Vector2(ModInfo.iconMainSizeX, ModInfo.iconMainSizeY);

		// Token: 0x0400004C RID: 76
		internal static Vector3 icon_TankPos = new Vector3(ModInfo.iconMainX, ModInfo.iconMainY, 0f);

		// Token: 0x0400004D RID: 77
		internal static Vector2 icon_TankSize = new Vector2(ModInfo.iconMainSizeX, ModInfo.iconMainSizeY - 2f);

		// Token: 0x0400004E RID: 78
		internal static Vector3 icon_MFoldPos = new Vector3(ModInfo.iconMainX, ModInfo.iconMainY, 0f);

		// Token: 0x0400004F RID: 79
		internal static Vector2 icon_MFoldSize = new Vector2(ModInfo.iconMainSizeX - 8f, ModInfo.iconMainSizeY);

		// Token: 0x04000050 RID: 80
		internal static float fontSize = 15f;

		// Token: 0x04000051 RID: 81
		internal static float shiftRight = 71f;

		// Token: 0x04000052 RID: 82
		internal static float correctTxt = 10f;

		// Token: 0x04000053 RID: 83
		internal static float TxtLeftRightX = ModInfo.BGmoveLeftRightX - ModInfo.correctTxt;

		// Token: 0x04000054 RID: 84
		internal static string colorWhite = "<color=white>";

		// Token: 0x04000055 RID: 85
		internal static string colorLightGray = "<color=#bfbfbf>";

		// Token: 0x04000056 RID: 86
		internal static string colorDarkGray = "<color=#808080>";

		// Token: 0x04000057 RID: 87
		internal static string colorYellow = "<color=yellow>";

		// Token: 0x04000058 RID: 88
		internal static string colorBlue = "<color=aqua>";

		// Token: 0x04000059 RID: 89
		internal static string colorRed = "<color=red>";

		// Token: 0x0400005A RID: 90
		internal static string colorEnd = "</color>";
	}
}
