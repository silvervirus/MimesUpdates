using System;
using System.Text;
using HarmonyLib;
using UnityEngine.UI;

namespace OxygenCanisters.ManageGUI
{
	// Token: 0x02000009 RID: 9
	internal class DisplayPrompts
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000296C File Offset: 0x00000B6C
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
				
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text + value2);
            }
			else
			{
				stringBuilder.Append(thisHint);
				stringBuilder.Append(value2);
				string text2 = stringBuilder.ToString();
				
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value + text2);


            }
		}
	}
}
