using System;
using System.Collections;
using UnityEngine;

namespace ToolsFlashLight.Helpers
{
	// Token: 0x02000021 RID: 33
	internal class GetSounds
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00004690 File Offset: 0x00002890
		public static FMODAsset GetFmodAsset(string audioPath)
		{
			FMODAsset fmodasset = ScriptableObject.CreateInstance<FMODAsset>();
			fmodasset.path = audioPath;
			return fmodasset;
		}

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
