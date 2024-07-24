using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x0200002D RID: 45
	internal class PowerState
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000740C File Offset: 0x0000560C
		public static string ProcessPower(float thisPower)
		{
			string text = ModInfo.colorWhite;
			bool flag = thisPower < 0f;
			if (flag)
			{
				thisPower = 0f;
			}
			bool flag2 = thisPower * 100f <= 33f;
			if (flag2)
			{
				text = ModInfo.colorRed;
			}
			else
			{
				bool flag3 = thisPower * 100f > 33f && thisPower * 100f <= 66f;
				if (flag3)
				{
					text = ModInfo.colorYellow;
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<size=" + (ModInfo.FontPlus + Config.FontSizeSliderValue).ToString() + ">");
			stringBuilder.Append(text);
			stringBuilder.Append(Mathf.CeilToInt(thisPower * 100f).ToString());
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append("</size>");
			stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
			stringBuilder.Append(ModInfo.colorYellow + "%" + ModInfo.colorEnd);
			stringBuilder.Append("</size>");
			return stringBuilder.ToString();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007540 File Offset: 0x00005740
		public static string ItemPowerState()
		{
			string text = "-";
			string colorWhite = ModInfo.colorWhite;
			Targeting.AddToIgnoreList(Player.main.gameObject);
			GameObject gameObject;
			float num;
            Targeting.GetTarget(10f, out gameObject, out num);
            StringBuilder stringBuilder = new StringBuilder();
			bool flag = gameObject != null;
			string text2;
			if (flag)
			{
				Base componentInParent = gameObject.GetComponentInParent<Base>();
				SubRoot componentInParent2 = gameObject.GetComponentInParent<SubRoot>();
				Vehicle componentInParent3 = gameObject.GetComponentInParent<Vehicle>();
				bool flag2 = componentInParent != null && ModInfo.ObjectLock;
				if (flag2)
				{
					bool flag3 = componentInParent2.powerRelay.GetMaxPower() != 0f;
					float num2;
					if (flag3)
					{
						num2 = componentInParent2.powerRelay.GetPower() / componentInParent2.powerRelay.GetMaxPower();
					}
					else
					{
						num2 = 0f;
					}
					text = PowerState.ProcessPower(num2);
				}
				else
				{
					bool flag4 = componentInParent2 != null && ModInfo.ObjectLock;
					if (flag4)
					{
						bool flag5 = componentInParent2.powerRelay.GetMaxPower() != 0f;
						float num3;
						if (flag5)
						{
							num3 = componentInParent2.powerRelay.GetPower() / componentInParent2.powerRelay.GetMaxPower();
						}
						else
						{
							num3 = 0f;
						}
						text = PowerState.ProcessPower(num3);
					}
					else
					{
						bool flag6 = componentInParent3 != null && ModInfo.ObjectLock;
						if (flag6)
						{
							EnergyMixin component = componentInParent3.GetComponent<EnergyMixin>();
							float energyScalar = component.GetEnergyScalar();
							text = PowerState.ProcessPower(energyScalar);
						}
						else
						{
							text = "-";
						}
					}
				}
				gameObject = null;
				stringBuilder.Append(text);
				text2 = stringBuilder.ToString();
			}
			else
			{
				text2 = text;
			}
			return text2;
		}
        public class TargetClassWrapper
        {
            public static bool GetTarget(float maxDistance, out GameObject result, out float distance)
            {
                // Your additional logic here
                Debug.Log("Wrapper called for GetTarget");

                // Call the original method
                bool returnValue = Targeting.GetTarget(maxDistance, out result, out distance);

                // Optionally modify the result
                return returnValue;
            }
        }
    }
}
