using System;
using UnityEngine;

namespace OxygenAudioMonitor.Helpers
{
	// Token: 0x0200000E RID: 14
	internal class GetSound
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000307C File Offset: 0x0000127C
		public static FMODAsset GetFmodAsset(string audioPath)
		{
			FMODAsset fmodasset = ScriptableObject.CreateInstance<FMODAsset>();
			fmodasset.path = audioPath;
			return fmodasset;
		}
	}
}
