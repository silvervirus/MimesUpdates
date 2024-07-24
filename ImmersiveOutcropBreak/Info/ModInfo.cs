using System;
using ImmersiveOutcropBreak.Configuration;
using UnityEngine;

namespace ImmersiveOutcropBreak.Info
{
	// Token: 0x0200001A RID: 26
	internal class ModInfo
	{
		// Token: 0x04000019 RID: 25
		internal static bool FirstRunDone = false;

		// Token: 0x0400001A RID: 26
		internal static bool ShowPulses = true;

		// Token: 0x0400001B RID: 27
		internal static int NumberOfPulses;

		// Token: 0x0400001C RID: 28
		internal static bool PulseOnNow = Config.PulseToggleValue;

		// Token: 0x0400001D RID: 29
		internal static bool AutoBreakNow = Config.OutcropAutoBreakOnToggleValue;

		// Token: 0x0400001E RID: 30
		internal static bool AutoPickupOn = Config.OutcropAutoPickupToggleValue;

		// Token: 0x0400001F RID: 31
		internal static bool AutoBreakGUIon = Config.AutoBreakGUIToggleValue;

		// Token: 0x04000020 RID: 32
		internal static bool AutoPickupGUIon = Config.AutoPickupGUIToggleValue;

		// Token: 0x04000021 RID: 33
		internal static float Pulse_H = 0f;

		// Token: 0x04000022 RID: 34
		internal static float Pulse_V = 12f;

		// Token: 0x04000023 RID: 35
		internal static Vector3 Pulse_Position = new Vector3(ModInfo.Pulse_H, ModInfo.Pulse_V, 0f);

		// Token: 0x04000024 RID: 36
		internal static Vector2 Pulse_Size = new Vector2(45f, 20f);

		// Token: 0x04000025 RID: 37
		internal static float Pickup_H = 55f;

		// Token: 0x04000026 RID: 38
		internal static float Pickup_V = -30f;

		// Token: 0x04000027 RID: 39
		internal static Vector3 Pickup_Position = new Vector3(ModInfo.Pickup_H, ModInfo.Pickup_V, 0f);

		// Token: 0x04000028 RID: 40
		internal static Vector2 Pickup_Size = new Vector2(40f, 40f);

		// Token: 0x04000029 RID: 41
		internal static float Break_H = -55f;

		// Token: 0x0400002A RID: 42
		internal static float Break_V = -30f;

		// Token: 0x0400002B RID: 43
		internal static Vector3 Break_Position = new Vector3(ModInfo.Break_H, ModInfo.Break_V, 0f);

		// Token: 0x0400002C RID: 44
		internal static Vector2 Break_Size = new Vector2(40f, 40f);

		// Token: 0x0400002D RID: 45
		internal static bool PickupFreshItem = false;

		// Token: 0x0400002E RID: 46
		internal static int PostBreakAutoPickupDelay = 2000;

		// Token: 0x0400002F RID: 47
		internal static bool ShowInventoryNow = true;

		// Token: 0x04000030 RID: 48
		internal static GUIHand thisOutcrop;

		// Token: 0x04000031 RID: 49
		internal static string colorWhite = "<color=white>";

		// Token: 0x04000032 RID: 50
		internal static string colorLightGray = "<color=#bfbfbf>";

		// Token: 0x04000033 RID: 51
		internal static string colorDarkGray = "<color=#808080>";

		// Token: 0x04000034 RID: 52
		internal static string colorYellow = "<color=yellow>";

		// Token: 0x04000035 RID: 53
		internal static string colorBlue = "<color=green>";

		// Token: 0x04000036 RID: 54
		internal static string colorRed = "<color=red>";

		// Token: 0x04000037 RID: 55
		internal static string colorEnd = "</color>";
	}
}
