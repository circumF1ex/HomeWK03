using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWK03_lib
{
    class StrNode
    {
        public string value;
        public StrNode next;
        public StrNode(string value)
        {
            this.value = value;
            next = null;
        }
        
    }
}
