using System;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;

namespace ToolsFlashLight.Patches
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(PlayerTool))]
	[HarmonyPatch("OnHolster")]
	internal class PlayerTool_OnHolster_Patch
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000231F File Offset: 0x0000051F
		[HarmonyPostfix]
		public static void Postfix(PlayerTool __instance)
		{
			ModInfo.BuilderToolIsUsed = false;
			ModInfo.CutterToolIsUsed = false;
			ModInfo.ScannerToolIsUsed = false;
			ModInfo.WelderToolIsUsed = false;
			ModInfo.AnyLEDToolIsUsed = false;
		}
	}
}
