using System;
using System.IO;
using Nautilus.Utility;
using UnityEngine;
using UnityEngine.UI;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace OxygenAudioMonitor.ManageGUI
{
	// Token: 0x0200000A RID: 10
	internal class PrepareGUISprite
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002DCF File Offset: 0x00000FCF
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002DD6 File Offset: 0x00000FD6
		public static string AssetsFolder { get; private set; }

		// Token: 0x06000025 RID: 37 RVA: 0x00002DE0 File Offset: 0x00000FE0
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
			bool flag3 = thisGameObject == ManageAllGUIElements.EarphonesUIGameObject;
			if (flag3)
			{
				component.SetAsLastSibling();
			}
			return thisGameObject;
		}
	}
}
