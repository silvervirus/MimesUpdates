using System;
using System.Threading.Tasks;
using ImmersiveOutcropBreak.Helpers;
using ImmersiveOutcropBreak.Info;

namespace ImmersiveOutcropBreak.InGame
{
	// Token: 0x02000015 RID: 21
	internal class BreakOutcrop
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00004084 File Offset: 0x00002284
		public static async void BreakOutcropDelay(BreakableResource __instance, int thisDelay, bool playSound)
		{
			await System.Threading.Tasks.Task.Delay(thisDelay);
			if (playSound)
			{
				FMODAsset asset = GetStuff.GetFmodAsset("event:/tools/gravcannon/fire");
				Utils.PlayFMODAsset(asset, Player.main.transform.position, 20f);
				asset = null;
			}
			ModInfo.PickupFreshItem = true;
			__instance.HitResource();
			BreakOutcrop.StopPickup(ModInfo.PostBreakAutoPickupDelay);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000040D0 File Offset: 0x000022D0
		public static async void StopPickup(int thisDelay)
		{
			await System.Threading.Tasks.Task.Delay(thisDelay);
			ModInfo.PickupFreshItem = false;
		}
	}
}
