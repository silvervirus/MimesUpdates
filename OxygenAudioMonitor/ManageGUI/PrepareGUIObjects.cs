using System;
using UnityEngine;

namespace OxygenAudioMonitor.ManageGUI
{
	// Token: 0x02000009 RID: 9
	internal class PrepareGUIObjects
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002D88 File Offset: 0x00000F88
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
