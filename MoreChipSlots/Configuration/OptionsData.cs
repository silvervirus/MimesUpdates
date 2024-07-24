using System;
using System.Collections.Generic;
using System.Linq;
using Nautilus.Handlers;
using Nautilus.Options;
using Nautilus.Options.Attributes;
using Nautilus.Utility;
using UnityEngine;

namespace MoreChipSlots.Configuration
{
	// Token: 0x02000009 RID: 9
	public class Options : ModOptions
	{
        
        public Options(): base("More Chip Slots")
		{

            var fourchip = ModToggleOption.Create("4Chip", "Enable 4 ChipSlots", ConfigData.FourSlotNumberChoiceIndex);
                fourchip.OnChanged += Options_4ChipToggleValueChanged;
            AddItem(fourchip);
            var sixchip = ModToggleOption.Create("6Chip", "Enable 6 ChipSlots", ConfigData.SixSlotNumberChoiceIndex);
                sixchip.OnChanged += Options_6ChipToggleValueChanged;
            AddItem(sixchip);
            var eightchip = ModToggleOption.Create("8Chip", "Enable 8 ChipSlots", ConfigData.EightSlotNumberChoiceIndex);
                eightchip.OnChanged += Options_8ChipToggleValueChanged;
            AddItem(eightchip);

        }
        public  void BuildModOptions()
        {
           
        }
        public void Options_4ChipToggleValueChanged(object sender, ToggleChangedEventArgs e)
        {
            bool flag = e.Id != "4Chip";
            if (!flag)
            {
                ConfigData.FourSlotNumberChoiceIndex = e.Value;
                PlayerPrefsExtra.SetBool("4Chip", e.Value);
            }
            
        }
        public void Options_6ChipToggleValueChanged(object sender, ToggleChangedEventArgs e)
        {
            bool flag = e.Id != "6Chip";
            if (!flag)
            {
                ConfigData.SixSlotNumberChoiceIndex = e.Value;
                PlayerPrefsExtra.SetBool("6Chip", e.Value);
            }
           

        }
        public void Options_8ChipToggleValueChanged(object sender, ToggleChangedEventArgs e)
        {
            bool flag = e.Id != "8Chip";
            if (!flag)
            {
                ConfigData.EightSlotNumberChoiceIndex = e.Value;
                PlayerPrefsExtra.SetBool("8Chip", e.Value);
                
            }
          
        }
       
		

		
		
	}
}
