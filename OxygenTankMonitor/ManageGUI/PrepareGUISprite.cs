using System;
using System.IO;
using Nautilus.Utility;
using UnityEngine;
using UnityEngine.UI;
using ImageUtils = Nautilus.Utility.ImageUtils;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x02000012 RID: 18
	internal class PrepareGUISprite
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000561F File Offset: 0x0000381F
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00005626 File Offset: 0x00003826
		public static string AssetsFolder { get; private set; }

		// Token: 0x06000061 RID: 97 RVA: 0x00005630 File Offset: 0x00003830
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
			bool flag3 = thisGameObject == ManageAllGUIElements.TankBarMoni00UIGameObject || thisGameObject == ManageAllGUIElements.TankBarMoni01UIGameObject || thisGameObject == ManageAllGUIElements.TankBarMoni02UIGameObject || thisGameObject == ManageAllGUIElements.TankBarMoni03UIGameObject || thisGameObject == ManageAllGUIElements.TankBarMoni04UIGameObject || thisGameObject == ManageAllGUIElements.TankBarMoni05UIGameObject;
			if (flag3)
			{
				component.pivot = new Vector2(0.5f, 0f);
			}
			return thisGameObject;
		}
	}
}
