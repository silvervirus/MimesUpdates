using System;
using System.Text;
using HarmonyLib;

namespace ImmersiveOutcropBreak.ManageGUI
{
	// Token: 0x02000014 RID: 20
	internal class DisplayPrompts
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000400C File Offset: 0x0000220C
		public static void DisplayHint(string thisHint)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			stringBuilder.Append(thisHint);
			stringBuilder.Append(value2);
			string text = stringBuilder.ToString();
			HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value + text);
		}
	}
}
