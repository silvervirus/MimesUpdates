using BepInEx.Configuration;
using Nautilus.Handlers;
using Nautilus.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreChipSlots.Configuration
{
    public class MoreChipsConfig
    {
        public static ConfigEntry<bool> FourSlotNumberChoiceIndex;
        public static ConfigEntry<bool> SixSlotNumberChoiceIndex;
        public static ConfigEntry<bool> EightSlotNumberChoiceIndex;


        public static void LoadConfig(ConfigFile config)
        {
            // Recipe config regsitration

            FourSlotNumberChoiceIndex = config.Bind("4chip",
                "4 ChipSlots",
                false,
                "Toggle only one options at once Adds 2 extra chip slots"
                );

            SixSlotNumberChoiceIndex = config.Bind("6chip",
                 "6 ChipSlots",
                 false,
                 "Toggle only one options at once Adds 4 extra chip slots"
                 );


            EightSlotNumberChoiceIndex = config.Bind("8chip",
                  "8 ChipSlots",
                  false,
                  "Toggle only one options at once Adds 6 extra chip slots"
                  );





            OptionsPanelHandler.RegisterModOptions(new MoreChipSlotsModOptions());
        }


        public class MoreChipSlotsModOptions : ModOptions
        {
            public MoreChipSlotsModOptions() : base("MoreChipSlots")
            {

                AddItem(FourSlotNumberChoiceIndex.ToModToggleOption());
                AddItem(SixSlotNumberChoiceIndex.ToModToggleOption());
                AddItem(EightSlotNumberChoiceIndex.ToModToggleOption());

            }
        }
    }
}
   
    
