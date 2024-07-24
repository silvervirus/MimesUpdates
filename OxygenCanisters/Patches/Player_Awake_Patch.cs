using System;
using HarmonyLib;
using OxygenCanisters.InGame;
using OxygenCanisters.Modules;
using Nautilus.Handlers;

namespace OxygenCanisters.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(Player))]
	[HarmonyPatch("Awake")]
	internal class Player_Awake_Patch
	{
        
        [HarmonyPrefix]
		internal static void Prefix(Player __instance)
		{
            EnumHandler.TryGetValue("OxygenCanister", out TechType OxygenCanister);
            __instance.gameObject.EnsureComponent<QuickUseDetector>();
			CraftDataHandler.SetEatingSound(OxygenCanister, "event:/sub/base/exit_hatch");
		}
	}
}
