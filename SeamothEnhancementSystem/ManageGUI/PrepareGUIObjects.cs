using System;
using UnityEngine;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200002D RID: 45
	internal class PrepareGUIObjects
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00009A24 File Offset: 0x00007C24
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
