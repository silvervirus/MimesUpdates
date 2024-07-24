using System;
using UnityEngine;

namespace ToolsFlashLight.InfoObjects
{
	// Token: 0x0200001E RID: 30
	internal class ModInfo
	{
		// Token: 0x04000013 RID: 19
		internal static float lightRange = 60f;

		// Token: 0x04000014 RID: 20
		internal static float lightRangeTop = 120f;

		// Token: 0x04000015 RID: 21
		internal static float lightIntensity = 0.8f;

		// Token: 0x04000016 RID: 22
		internal static float lightIntensityTop = 1.2f;

		// Token: 0x04000017 RID: 23
		internal static float lightSpotAngle = 60f;

		// Token: 0x04000018 RID: 24
		internal static float lightSpotAngleFar = 40f;

		// Token: 0x04000019 RID: 25
		internal static float lightInnerSpotAngle = 40f;

		// Token: 0x0400001A RID: 26
		internal static float lightInnerSpotAngleFar = 20f;

		// Token: 0x0400001B RID: 27
		internal static float rangeDelta = 1.5f;

		// Token: 0x0400001C RID: 28
		internal static float intensDelta = 0.01f;

		// Token: 0x0400001D RID: 29
		internal static float spotAngleDelta = 0.5f;

		// Token: 0x0400001E RID: 30
		internal static float innerSpotAngleDelta = 0.5f;

		// Token: 0x0400001F RID: 31
		internal static bool GlobalLightIsOn = false;

		// Token: 0x04000020 RID: 32
		internal static bool ExtraTabs = false;

		// Token: 0x04000021 RID: 33
		internal static bool lightIsBeingChanged = false;

		// Token: 0x04000022 RID: 34
		internal static float lightPowerConsumption = 0.1f;

		// Token: 0x04000023 RID: 35
		internal static bool BuilderToolIsUsed = false;

		// Token: 0x04000024 RID: 36
		internal static bool CutterToolIsUsed = false;

		// Token: 0x04000025 RID: 37
		internal static bool ScannerToolIsUsed = false;

		// Token: 0x04000026 RID: 38
		internal static bool WelderToolIsUsed = false;

		// Token: 0x04000027 RID: 39
		internal static bool AnyLEDToolIsUsed = false;

		// Token: 0x04000028 RID: 40
		internal static bool BuilderLightOn = false;

		// Token: 0x04000029 RID: 41
		internal static bool CutterLightOn = false;

		// Token: 0x0400002A RID: 42
		internal static bool ScannerLightOn = false;

		// Token: 0x0400002B RID: 43
		internal static bool WelderLightOn = false;

		// Token: 0x0400002C RID: 44
		internal static bool colorChangeTrigger = false;

		// Token: 0x0400002D RID: 45
		internal static bool adjustIcon = false;

		// Token: 0x0400002E RID: 46
		internal static float moveUpDownY = -58f;

		// Token: 0x0400002F RID: 47
		internal static float onOffLeftRightX = 4f;

		// Token: 0x04000030 RID: 48
		internal static float sizeX = 74f;

		// Token: 0x04000031 RID: 49
		internal static float sizeY = 64f;

		// Token: 0x04000032 RID: 50
		internal static Vector3 flashlightOnOff_Position = new Vector3(ModInfo.onOffLeftRightX, ModInfo.moveUpDownY, 0f);

		// Token: 0x04000033 RID: 51
		internal static Vector2 flashlight_Size = new Vector2(ModInfo.sizeX, ModInfo.sizeY);

		// Token: 0x04000034 RID: 52
		internal static string colorWhite = "<color=white>";

		// Token: 0x04000035 RID: 53
		internal static string colorLightGray = "<color=#bfbfbf>";

		// Token: 0x04000036 RID: 54
		internal static string colorDarkGray = "<color=#808080>";

		// Token: 0x04000037 RID: 55
		internal static string colorYellow = "<color=yellow>";

		// Token: 0x04000038 RID: 56
		internal static string colorBlue = "<color=aqua>";

		// Token: 0x04000039 RID: 57
		internal static string colorRed = "<color=red>";

		// Token: 0x0400003A RID: 58
		internal static string colorEnd = "</color>";

		// Token: 0x0400003B RID: 59
		internal static bool lightTesting = false;

		// Token: 0x0400003C RID: 60
		internal static int rotate_x = 0;

		// Token: 0x0400003D RID: 61
		internal static int rotate_y = 0;

		// Token: 0x0400003E RID: 62
		internal static int rotate_z = 0;

		// Token: 0x0400003F RID: 63
		internal static float move_x = 0f;

		// Token: 0x04000040 RID: 64
		internal static float move_y = 0f;

		// Token: 0x04000041 RID: 65
		internal static float move_z = 0f;
	}
}
