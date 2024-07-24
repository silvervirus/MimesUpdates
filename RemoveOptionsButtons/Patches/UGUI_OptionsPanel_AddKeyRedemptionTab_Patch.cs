using System;
using HarmonyLib;
using RemoveOptionsButtons.Configuration;

namespace RemoveOptionsButtons.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(uGUI_OptionsPanel))]
	[HarmonyPatch("AddKeyRedemptionTab")]
	internal class UGUI_OptionsPanel_AddKeyRedemptionTab_Patch
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000208C File Offset: 0x0000028C
		[HarmonyPrefix]
		public static bool Prefix()
		{
			return !ConfigData.RemoveRedeemaKeyButtonValue;
		}
	}
}
