using System;
using System.IO;
using Nautilus.Utility;
using UnityEngine;
using UnityEngine.UI;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace ToolsFlashLight.ManageGUI
{
	// Token: 0x02000017 RID: 23
	internal class PrepareGUISprite
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003A87 File Offset: 0x00001C87
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00003A8E File Offset: 0x00001C8E
		public static string AssetsFolder { get; private set; }

		// Token: 0x06000068 RID: 104 RVA: 0x00003A98 File Offset: 0x00001C98
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
			return thisGameObject;
		}
	}
}
