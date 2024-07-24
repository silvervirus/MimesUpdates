using System;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000023 RID: 35
	internal class MoveGUI
	{
		// Token: 0x06000059 RID: 89 RVA: 0x000067E8 File Offset: 0x000049E8
		public static void MoveGUIElement(GameObject thisGameObject, float this_H, float this_V)
		{
			Image component = thisGameObject.GetComponent<Image>();
			Text component2 = thisGameObject.GetComponent<Text>();
			bool flag = component != null;
			if (flag)
			{
				RectTransform rectTransform = component.GetComponent<RectTransform>();
				rectTransform.anchoredPosition = new Vector2(this_H, this_V);
			}
			bool flag2 = component2 != null;
			if (flag2)
			{
				RectTransform rectTransform = component2.GetComponent<RectTransform>();
				rectTransform.anchoredPosition = new Vector2(this_H, this_V);
			}
		}
	}
}
