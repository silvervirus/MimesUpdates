using System;
using System.Text;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace ToolsFlashLight.ManageGUI
{
	// Token: 0x02000013 RID: 19
	internal class DisplayPrompts
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00003064 File Offset: 0x00001264
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
				
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text + value2  );
            }
			else
			{
				stringBuilder.Append(thisHint);
				stringBuilder.Append(value2);
				string text2 = stringBuilder.ToString();
				
                HandReticle.main.SetTextRaw(HandReticle.TextType.Use, value+text2 );

            }
        }

		// Token: 0x06000059 RID: 89 RVA: 0x00003104 File Offset: 0x00001304
		public static void DisplayLargeHint(string thisHint, Light thisLight)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = Traverse.Create(HandReticle.main).Field("useText1").GetValue<string>();
			string value2 = Traverse.Create(HandReticle.main).Field("useText2").GetValue<string>();
			stringBuilder.Append(value);
			stringBuilder.Append(thisHint);
			bool lightTesting = ModInfo.lightTesting;
			if (lightTesting)
			{
				stringBuilder.Append('\n');
				StringBuilder stringBuilder2 = stringBuilder;
				string[] array = new string[6];
				array[0] = "Rotate: ";
				int num = 1;
				Vector3 vector = thisLight.transform.localEulerAngles;
				array[num] = vector.x.ToString();
				array[2] = ", ";
				int num2 = 3;
				vector = thisLight.transform.localEulerAngles;
				array[num2] = vector.y.ToString();
				array[4] = ", ";
				int num3 = 5;
				vector = thisLight.transform.localEulerAngles;
				array[num3] = vector.z.ToString();
				stringBuilder2.Append(string.Concat(array));
				stringBuilder.Append(string.Concat(new string[]
				{
					"Rotate: ",
					ModInfo.rotate_x.ToString(),
					", ",
					ModInfo.rotate_y.ToString(),
					", ",
					ModInfo.rotate_z.ToString()
				}));
				stringBuilder.Append('\n');
				stringBuilder.Append(string.Concat(new string[]
				{
					"Move: ",
					ModInfo.move_x.ToString(),
					", ",
					ModInfo.move_y.ToString(),
					", ",
					ModInfo.move_z.ToString()
				}));
			}
			string text = stringBuilder.ToString();
            HandReticle.main.SetTextRaw(HandReticle.TextType.Use, text + value2);

        }
    }
}
