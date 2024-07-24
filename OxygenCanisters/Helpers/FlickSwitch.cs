using System;
using OxygenCanisters.Info;

namespace OxygenCanisters.Helpers
{
	// Token: 0x02000014 RID: 20
	internal class FlickSwitch
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000036FC File Offset: 0x000018FC
		public static void FlickSoundSwitch(string thisSound, int thisTiming)
		{
			if (thisTiming != 25)
			{
				if (thisTiming != 30)
				{
					if (thisTiming != 50)
					{
						ModInfo.isOKtoPlayTankTen = false;
					}
					else
					{
						ModInfo.isOKtoPlayTankFifty = false;
					}
				}
				else
				{
					ModInfo.isOKtoPlayTankThirty = false;
				}
			}
			else
			{
				ModInfo.isOKtoPlayTankTwenty = false;
			}
			FMODAsset fmodAsset = GetStuff.GetFmodAsset(thisSound);
			Utils.PlayFMODAsset(fmodAsset, Player.main.transform.position, 20f);
		}
	}
}
