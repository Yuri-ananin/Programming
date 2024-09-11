using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public enum DesiredDeliveryTime
    {
        [Description("9:00 - 11:00")]
        NineToEleven,
        [Description("11:00 - 13:00")]
        ElevenToThirteen,
        [Description("13:00 - 15:00")]
        ThirteenToFifteen,
        [Description("15:00 - 17:00")]
        FifteenToSeventeen,
        [Description("17:00 - 19:00")]
        SeventeenToNineteen,
        [Description("19:00 - 21:00")]
        NineteenToTwentyOne
    }
}
