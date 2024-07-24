using System;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200002E RID: 46
	internal class PrepareGUISprite
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00009A64 File Offset: 0x00007C64
		public static GameObject PrepareGuiElement(GameObject thisGameObject, string thisSpriteName, Vector3 thisPosition, Vector2 thisSize)
		{
			Sprite sprite = thisGameObject.GetComponent<Sprite>();
			bool flag = sprite == null;
			if (flag)
			{
				sprite = MainPatcher.assetBundle.LoadAsset<Sprite>(thisSpriteName);
			}
			Image image = thisGameObject.GetComponent<Image>();
			bool flag2 = image == null;
			if (flag2)
			{
				thisGameObject.gameObject.AddComponent<Image>().sprite = sprite;
			}
			image = thisGameObject.GetComponent<Image>();
			RectTransform component = image.GetComponent<RectTransform>();
			component.localPosition = thisPosition;
			component.sizeDelta = thisSize;
			bool flag3 = thisGameObject == ManageAllGUIElements.BackgroundUIGameObject;
			if (flag3)
			{
				component.SetAsFirstSibling();
			}
			return thisGameObject;
		}
	}
}
