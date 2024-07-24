using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace BetterHUDInfo.ManageGUI
{
	
	internal static class PrepareGUITxt 
	{
		
		public static GameObject PrepareTxtElement(GameObject thisGameObject, float fontModifier, bool setTxtColor, bool moduleIn, Color thisTxtColor, bool applyShadow, Vector3 thisPosition, Vector2 thisSize)
		{
			thisGameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			Text text = thisGameObject.GetComponent<Text>();
			bool flag = text == null;
			if (flag)
			{
				text = thisGameObject.gameObject.AddComponent<Text>();
			}
			if (applyShadow)
			{
				Shadow shadow = thisGameObject.GetComponent<Shadow>();
				bool flag2 = shadow == null;
				if (flag2)
				{
					shadow = thisGameObject.gameObject.AddComponent<Shadow>();
				}
				shadow.effectColor = Color.black;
				shadow.effectDistance = new Vector2(2f, -2f);
			}
			text.font = Player.main.textStyle.font;
			float num = Config.FontSizeSliderValue;
			bool flag3 = fontModifier != 1f;
			if (flag3)
			{
				num = Config.FontSizeSliderValue + ModInfo.FontPlus;
			}
			text.fontSize = Mathf.RoundToInt(num / fontModifier);
			bool flag4 = thisGameObject == ManageAllGUIElements.HUD_ControlTextObject;
			if (flag4)
			{
				text.alignment = TextAnchor.UpperLeft;
			}
			else
			{
				text.alignment = TextAnchor.MiddleCenter;
			}
			if (setTxtColor)
			{
				text.color = Color.grey;
			}
			else
			{
				text.color = Color.white;
			}
			RectTransform component = text.GetComponent<RectTransform>();
			component.localPosition = thisPosition;
			component.sizeDelta = thisSize;
			component.SetAsLastSibling();
            ModInfo.staticGameObject = thisGameObject;
            return thisGameObject;
		}
	}
}
