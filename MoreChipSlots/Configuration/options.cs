using Nautilus.Handlers;
using Nautilus.Json;
using Nautilus.Options;
using Nautilus.Options.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static KnownTech;

namespace MoreChipSlots.Configuration
{
    public enum CustomChoice { One, Two, Three }
    [Menu("MoreChipSlots")]
    public class Config : ConfigFile
    {
        [Choice("Chipslotsamount", "Default", "4Slots", "8Slots")]
        public int Chipslotsamount;
        
        [Choice]
        public CustomChoice MyEnumBasedChoice;

    }
}