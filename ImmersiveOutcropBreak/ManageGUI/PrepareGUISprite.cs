using System;
using UnityEngine;
using UnityEngine.UI;

namespace ImmersiveOutcropBreak.ManageGUI
{
	// Token: 0x02000012 RID: 18
	internal class PrepareGUISprite
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003E6C File Offset: 0x0000206C
		public static GameObject PrepareGuiElement(GameObject thisGameObject, string thisSpriteName, Vector3 thisPosition, Vector2 thisSize, bool bringToFront)
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
			if (bringToFront)
			{
				component.SetAsLastSibling();
			}
			else
			{
				component.SetAsFirstSibling();
			}
			return thisGameObject;
		}
	}
}
