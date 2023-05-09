using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntanceVariablePrac32
{
    internal class product
    {
        public static string origin = "대한한국";
        public string name = "default";
        public int price = 0;

        public override string ToString()
        {
            return "이름:" + this.name + " / 가격:" + this.price;
        }
    }
}
