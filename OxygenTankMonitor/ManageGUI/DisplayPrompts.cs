using System;
using System.Text;
using HarmonyLib;
using UnityEngine.UI;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x0200000A RID: 10
	internal class DisplayPrompts
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002904 File Offset: 0x00000B04
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
				
				HandReticle.main.SetTextRaw(HandReticle.TextType.Use,value2+text);

            }
			else
			{
				stringBuilder.Append(thisHint);
				stringBuilder.Append(value2);
				string text2 = stringBuilder.ToString();
				
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value+text2);
            }
		}
	}
}
