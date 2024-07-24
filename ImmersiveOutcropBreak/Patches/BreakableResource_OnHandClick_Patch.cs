using System;
using HarmonyLib;
using ImmersiveOutcropBreak.Helpers;
using ImmersiveOutcropBreak.Info;
using ImmersiveOutcropBreak.InGame;

namespace ImmersiveOutcropBreak.Patches
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(BreakableResource))]
	[HarmonyPatch("OnHandClick")]
	internal class BreakableResource_OnHandClick_Patch
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002230 File Offset: 0x00000430
		[HarmonyPrefix]
		public static bool Prefix(BreakableResource __instance)
		{
			bool flag = CheckConditions.PlayerGlovesEquipped() || CheckConditions.ToolIsReady();
			bool flag12;
			if (flag)
			{
				bool flag2 = CheckConditions.PlayerAdvancedGlovesEquipped();
				if (flag2)
				{
					bool flag3 = CheckConditions.HiTechGloveChipEquipped() && ModInfo.AutoPickupOn && !ModInfo.PickupFreshItem;
					if (flag3)
					{
						ModInfo.PickupFreshItem = true;
						BreakOutcrop.StopPickup(ModInfo.PostBreakAutoPickupDelay);
						bool flag4 = !ModInfo.PulseOnNow;
						if (flag4)
						{
							bool flag5 = __instance.hitsToBreak > 2;
							if (flag5)
							{
								__instance.hitsToBreak -= 2;
							}
							else
							{
								bool flag6 = __instance.hitsToBreak > 1;
								if (flag6)
								{
									__instance.hitsToBreak--;
								}
							}
						}
					}
					else
					{
						bool flag7 = __instance.hitsToBreak > 2;
						if (flag7)
						{
							__instance.hitsToBreak -= 2;
						}
						else
						{
							bool flag8 = __instance.hitsToBreak > 1;
							if (flag8)
							{
								__instance.hitsToBreak--;
							}
						}
					}
				}
				bool flag9 = CheckConditions.PlayerStandardGlovesEquipped();
				if (flag9)
				{
					bool flag10 = __instance.hitsToBreak > 2;
					if (flag10)
					{
						__instance.hitsToBreak--;
					}
					else
					{
						bool flag11 = __instance.hitsToBreak > 1;
						if (flag11)
						{
							__instance.hitsToBreak--;
						}
					}
				}
				flag12 = true;
			}
			else
			{
				flag12 = false;
			}
			return flag12;
		}
	}
}
