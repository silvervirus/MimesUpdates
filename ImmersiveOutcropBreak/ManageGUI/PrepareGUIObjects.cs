using System;
using UnityEngine;

namespace ImmersiveOutcropBreak.ManageGUI
{
	// Token: 0x02000011 RID: 17
	internal class PrepareGUIObjects
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00003E24 File Offset: 0x00002024
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
