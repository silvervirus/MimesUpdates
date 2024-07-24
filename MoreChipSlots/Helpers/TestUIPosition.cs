using System;
using System.Text;
using HarmonyLib;
using MoreChipSlots.InfoObjects;
using Nautilus.Utility;
using UnityEngine;
using UnityEngine.UI;

namespace MoreChipSlots.Helpers
{
	// Token: 0x02000007 RID: 7
	internal class TestUIPosition
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000259C File Offset: 0x0000079C
		internal static void TestUIPos(GameObject TestUIGameObject)
		{
			float num = 1f;
			bool keyHeld = KeyCodeUtils.GetKeyHeld(KeyCode.RightControl);
			if (keyHeld)
			{
				num = 10f;
			}
			bool flag = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.UpArrow);
			if (flag)
			{
				TestUIPosition.MoveImage(num, "UpDown", TestUIGameObject);
			}
			bool flag2 = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.DownArrow);
			if (flag2)
			{
				TestUIPosition.MoveImage(-num, "UpDown", TestUIGameObject);
			}
			bool flag3 = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.LeftArrow);
			if (flag3)
			{
				TestUIPosition.MoveImage(-num, "LeftRight", TestUIGameObject);
			}
			bool flag4 = KeyCodeUtils.GetKeyHeld(KeyCode.RightShift) && KeyCodeUtils.GetKeyDown(KeyCode.RightArrow);
			if (flag4)
			{
				TestUIPosition.MoveImage(num, "LeftRight", TestUIGameObject);
			}
			TestUIPosition.DisplayHint("UpDown: " + ModInfo.iconY.ToString(), true);
			TestUIPosition.DisplayHint(", LeftRight: " + ModInfo.iconX.ToString(), true);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026A8 File Offset: 0x000008A8
		internal static void MoveImage(float moveBy, string thisDirection, GameObject TestUIGameObject)
		{
			bool flag = thisDirection == "UpDown";
			if (flag)
			{
				ModInfo.iconY += moveBy;
			}
			bool flag2 = thisDirection == "LeftRight";
			if (flag2)
			{
				ModInfo.iconX += moveBy;
			}
			TestUIGameObject.transform.localPosition = new Vector3(ModInfo.iconX, ModInfo.iconY, 0f);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000270C File Offset: 0x0000090C
		public static void DisplayHint(string thisHint, bool largeHint)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			if (largeHint)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(thisHint);
				string text = stringBuilder.ToString();
				HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text );

            }
			else
			{
				stringBuilder.Append(thisHint);
				stringBuilder.Append(value2);
				string text2 = stringBuilder.ToString();
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text2 );
            }
		}
	}
}
