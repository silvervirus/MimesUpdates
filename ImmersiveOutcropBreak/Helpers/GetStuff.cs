using System;
using UnityEngine;

namespace ImmersiveOutcropBreak.Helpers
{
	// Token: 0x0200001C RID: 28
	internal class GetStuff
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00004798 File Offset: 0x00002998
		public static FMODAsset GetFmodAsset(string audioPath)
		{
			FMODAsset fmodasset = ScriptableObject.CreateInstance<FMODAsset>();
			fmodasset.path = audioPath;
			return fmodasset;
		}

        // Token: 0x0600008D RID: 141 RVA: 0x000047B8 File Offset: 0x000029B8
        public IEnumerator GetGameObjectAsync(IOut<GameObject> gameObject)
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.PropulsionCannon);
            yield return task;
            GameObject prefab = task.GetResult();
            GameObject obj = GameObject.Instantiate(prefab);
            prefab.SetActive(false);

            obj.SetActive(true);
            gameObject.Set(obj);
        }
    }
}
