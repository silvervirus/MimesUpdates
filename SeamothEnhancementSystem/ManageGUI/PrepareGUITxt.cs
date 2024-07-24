using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace SeamothEnhancementSystem.ManageGUI
{
	// Token: 0x0200002F RID: 47
	internal static class PrepareGUITxt
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00009AF4 File Offset: 0x00007CF4
		public static GameObject PrepareTxtElement(GameObject thisGameObject, float fontModifier, bool setTxtColor, bool moduleIn, Color thisTxtColor, Vector3 thisPosition, Vector2 thisSize)
		{
			thisGameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			Text text = thisGameObject.GetComponent<Text>();
			bool flag = text == null;
			if (flag)
			{
				text = thisGameObject.gameObject.AddComponent<Text>();
			}
			text.font = Player.main.textStyle.font;
            text.fontSize = Mathf.RoundToInt(Config.VehicleFontSizeSliderValue / fontModifier);
			text.alignment = TextAnchor.MiddleCenter;
            if (setTxtColor)
			{
				bool flag2 = !moduleIn && SeamothInfo.seamothLinkModuleIn;
				if (flag2)
				{
					text.color = Color.grey;
				}
				else
				{
					bool flag3 = thisGameObject == GameObject.Find("GearTextUI");
					if (flag3)
					{
						bool flag4 = Config.SeamothGearValue == 6f;
						if (flag4)
						{
							text.color = Color.red;
						}
						else
						{
							bool flag5 = Config.SeamothGearValue == 5f;
							if (flag5)
							{
								text.color = Color.yellow;
							}
							else
							{
								text.color = Color.white;
							}
						}
					}
					else
					{
						text.color = thisTxtColor;
					}
				}
			}
			else
			{
				text.color = Color.white;
			}
			RectTransform component = text.GetComponent<RectTransform>();
			component.localPosition = thisPosition;
			component.sizeDelta = thisSize;
			component.SetAsLastSibling();
			GearInfo.gameObject = thisGameObject;
			return thisGameObject;
		}
	}
}
