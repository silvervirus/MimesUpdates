using System;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000025 RID: 37
	internal class PrepareGUISprite
	{
		// Token: 0x0600005D RID: 93 RVA: 0x0000689C File Offset: 0x00004A9C
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
