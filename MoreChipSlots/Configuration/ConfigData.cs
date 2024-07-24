using Nautilus.Json;
using Nautilus.Utility;
using System;
using UnityEngine;

namespace MoreChipSlots.Configuration
{
    // Token: 0x02000008 RID: 8
    internal class ConfigData:ConfigFile
    {
        // Token: 0x06000011 RID: 17 RVA: 0x000027B4 File Offset: 0x000009B4
        public static void Load()
        {

            ConfigData.FourSlotNumberChoiceIndex = false;
            ConfigData.SixSlotNumberChoiceIndex = false;
            ConfigData.EightSlotNumberChoiceIndex = false;
        }

        // Token: 0x04000015 RID: 21
       
        public static bool FourSlotNumberChoiceIndex;
        public static bool SixSlotNumberChoiceIndex;
        public static bool EightSlotNumberChoiceIndex;
    }
}
