using System;
using UnityEngine;

namespace ToolsFlashLight.ManageGUI
{
	// Token: 0x02000016 RID: 22
	internal class PrepareGUIObjects
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00003A40 File Offset: 0x00001C40
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
