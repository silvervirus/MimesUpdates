using System;
using UnityEngine;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x02000011 RID: 17
	internal class PrepareGUIObjects
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000055D8 File Offset: 0x000037D8
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
