using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlGenerics
{
    public class ValuesContainer<TVal1, TVal2>
    {
        public TVal1? Value1 { get; set; }

        public TVal2? Value2 { get; set; }
    }
}
