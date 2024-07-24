using System;
using System.IO;
using Nautilus.Utility;
using UnityEngine;
using UnityEngine.UI;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x0200000E RID: 14
	internal class PrepareGUISprite
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000030C7 File Offset: 0x000012C7
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000030CE File Offset: 0x000012CE
		public static string AssetsFolder { get; private set; }

		// Token: 0x06000037 RID: 55 RVA: 0x000030D8 File Offset: 0x000012D8
		public static GameObject PrepareGuiElement(GameObject thisGameObject, string thisSpriteFile, Vector3 thisPosition, Vector2 thisSize)
		{
			Sprite sprite = thisGameObject.GetComponent<Sprite>();
			bool flag = sprite == null;
			if (flag)
			{
				Texture2D texture2D = ImageUtils.LoadTextureFromFile(Path.Combine(MainPatcher.AssetsFolder, thisSpriteFile), TextureFormat.BC7);
				sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0f, 0f));
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
			component.SetAsLastSibling();
			return thisGameObject;
		}
	}
}
