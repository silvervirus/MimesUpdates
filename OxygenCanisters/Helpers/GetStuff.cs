using System;
using UnityEngine;

namespace OxygenCanisters.Helpers
{
	// Token: 0x02000016 RID: 22
	internal class GetStuff
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003880 File Offset: 0x00001A80
		public static FMODAsset GetFmodAsset(string audioPath)
		{
			FMODAsset fmodasset = ScriptableObject.CreateInstance<FMODAsset>();
			fmodasset.path = audioPath;
			return fmodasset;
		}
	}
}
