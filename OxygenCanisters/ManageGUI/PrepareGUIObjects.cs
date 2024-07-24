using System;
using UnityEngine;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x0200000D RID: 13
	internal class PrepareGUIObjects
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003080 File Offset: 0x00001280
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
