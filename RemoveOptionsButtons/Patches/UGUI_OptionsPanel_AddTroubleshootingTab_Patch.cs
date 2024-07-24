using System;
using HarmonyLib;
using RemoveOptionsButtons.Configuration;

namespace RemoveOptionsButtons.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(uGUI_OptionsPanel))]
	[HarmonyPatch("AddTroubleshootingTab")]
	internal class UGUI_OptionsPanel_AddTroubleshootingTab_Patch
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000020B0 File Offset: 0x000002B0
		[HarmonyPrefix]
		public static bool Prefix()
		{
			return !ConfigData.RemoveTroubleshootingButtonValue;
		}
	}
}
