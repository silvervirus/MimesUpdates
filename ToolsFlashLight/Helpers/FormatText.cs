using System;
using System.Text;
using ToolsFlashLight.Configuration;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.Helpers
{
	// Token: 0x02000020 RID: 32
	internal class FormatText
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00004580 File Offset: 0x00002780
		public static string LightToggleKeyHint(Light thisLight)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(" Light mode is ");
			bool isActiveAndEnabled = thisLight.isActiveAndEnabled;
			if (isActiveAndEnabled)
			{
				stringBuilder.Append(ModInfo.colorBlue);
				stringBuilder.Append("on ");
				stringBuilder.Append(ModInfo.colorEnd);
			}
			else
			{
				stringBuilder.Append("off ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", ConfigData.LightOnOffKeybindValue.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004604 File Offset: 0x00002804
		public static string LightAdjustKeyHint()
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool showLightHintToggleValue = ConfigData.ShowLightHintToggleValue;
			if (showLightHintToggleValue)
			{
				stringBuilder.Append(" power ");
			}
			else
			{
				stringBuilder.Append(" Light power ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", ConfigData.LightIntensUpKeybindValue.ToString());
			stringBuilder.Append('/');
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", ConfigData.LightIntensDownKeybindValue.ToString());
			return stringBuilder.ToString();
		}
	}
}
