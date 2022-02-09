using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWK03_lib
{
    class IntNode
    {
        public int value; 
        public IntNode next;
        public IntNode(int value)
        {
            this.value = value;
            next = null;
        }    
    }
}
