using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewYork_CIty_School_Data_With_Crime_Rate_History.Models
{
    public class TrapaniSnowLeopard
    {
        public ArakGroundhog? Enum;
        public long? Integer;

        public static implicit operator TrapaniSnowLeopard(ArakGroundhog Enum) => new TrapaniSnowLeopard { Enum = Enum };
        public static implicit operator TrapaniSnowLeopard(long Integer) => new TrapaniSnowLeopard { Integer = Integer };
    
}
}
