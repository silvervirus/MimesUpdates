using System;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000024 RID: 36
	internal class PrepareGUIObjects
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00006854 File Offset: 0x00004A54
		public static GameObject PrepareGUIObject(string thisGameObjectName, Vector3 thisVector3)
		{
			GameObject gameObject = new GameObject(thisGameObjectName);
			gameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			gameObject.transform.position = thisVector3;
			return gameObject;
		}
	}
}
