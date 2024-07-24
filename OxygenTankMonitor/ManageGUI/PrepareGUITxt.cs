using System;
using OxygenTankMonitor.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x02000013 RID: 19
	internal static class PrepareGUITxt
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00005760 File Offset: 0x00003960
		public static GameObject PrepareTxtElement(GameObject thisGameObject, float fontSize, bool setTxtColor, Color thisTxtColor, Vector3 thisPosition, Vector2 objectSize)
		{
			thisGameObject.transform.SetParent(ManageAllGUIElements.gameObject.transform, false);
			Text text = thisGameObject.GetComponent<Text>();
			bool flag = text == null;
			if (flag)
			{
				text = thisGameObject.gameObject.AddComponent<Text>();
			}
			text.font = Player.main.textStyle.font;
			text.fontSize = Mathf.RoundToInt(fontSize);
			text.alignment = TextAnchor.MiddleCenter;
			if (setTxtColor)
			{
				bool flag2 = CheckConditions.TankChipEquipped() || CheckConditions.ComboChipEquipped();
				if (flag2)
				{
					switch (TankList.GetTankList().Count)
					{
					case 1:
						text.color = Color.white;
						break;
					case 2:
						text.color = Color.cyan;
						break;
					case 3:
						text.color = Color.yellow;
						break;
					default:
						text.color = Color.white;
						break;
					}
				}
				else
				{
					text.color = thisTxtColor;
				}
			}
			else
			{
				text.color = Color.white;
			}
			RectTransform component = text.GetComponent<RectTransform>();
			component.localPosition = thisPosition;
			component.sizeDelta = objectSize;
			component.SetAsLastSibling();
			return thisGameObject;
		}
	}
}
