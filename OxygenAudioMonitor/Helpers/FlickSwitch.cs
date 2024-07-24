using System;
using OxygenAudioMonitor.InfoObjects;

namespace OxygenAudioMonitor.Helpers
{
	// Token: 0x0200000D RID: 13
	internal class FlickSwitch
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003018 File Offset: 0x00001218
		public static void FlickSoundSwitch(string thisSound, int thisTiming)
		{
			if (thisTiming != 25)
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
				ModInfo.isOKtoPlayTankTwenty = false;
			}
			FMODAsset fmodAsset = GetSound.GetFmodAsset(thisSound);
			Utils.PlayFMODAsset(fmodAsset, Player.main.transform.position, 20f);
		}
	}
}
