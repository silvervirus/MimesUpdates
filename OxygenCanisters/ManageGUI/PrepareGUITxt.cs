using System;
using OxygenCanisters.Helpers;
using OxygenCanisters.Info;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x0200000F RID: 15
	internal static class PrepareGUITxt
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000031A0 File Offset: 0x000013A0
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
				bool flag2 = CheckConditions.CanisterChipEquipped();
				if (flag2)
				{
					bool flag3 = Player.main.GetOxygenAvailable().IsBetween(0f, ModInfo.consumeOxyTrigger);
					if (flag3)
					{
						switch (CheckConditions.OxygenCanisterInInventory())
						{
						case 0:
							text.color = Color.red;
							break;
						case 1:
							text.color = Color.red;
							break;
						case 2:
							text.color = Color.yellow;
							break;
						case 3:
							text.color = Color.cyan;
							break;
						default:
							text.color = Color.white;
							break;
						}
					}
					else
					{
						text.color = Color.white;
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
			ModInfo.gameObject = thisGameObject;
			return thisGameObject;
		}
	}
}
