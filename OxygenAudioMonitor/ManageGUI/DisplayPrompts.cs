using System;
using System.Text;
using HarmonyLib;
using UnityEngine.UI;

namespace OxygenAudioMonitor.ManageGUI
{
	// Token: 0x02000006 RID: 6
	internal class DisplayPrompts
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000027C8 File Offset: 0x000009C8
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
