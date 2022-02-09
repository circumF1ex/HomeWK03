using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWK03_lib
{
    public class StrList
    {
        internal StrNode Head;
        public int Size = 0;
        public void Add(string value)
        {
            ++Size;
            StrNode new_Node = new StrNode(value);
            if (this.Head == null)
            {
                this.Head = new_Node;
                return;
            }
            StrNode lastNode = GetLastNode();
            lastNode.next = new_Node;
        }
        internal StrNode GetLastNode()
        {
            StrNode temp = this.Head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void RemoveAt(int index)
        {
            --Size;
            StrNode temp = this.Head;
            StrNode prev = null;
            
            if (index > Size)
            {
                return;
            }

            for (int i = 0; i < index; i++)
            {
                if (temp == null)
                {
                    return;
                }
                prev = temp;
                temp = temp.next;
            }   
            prev.next = temp.next;
        }
        public string PrintAll()
        {
            string str = " ";
            if (this.Head == null)
            {
                str = "List is empty";
                return str; ;
            }

            StrNode temp = this.Head;
            while (temp != null)
            {
                str += Convert.ToString(temp.value) + " ";  
                temp = temp.next;
            }
            return str;
        }
        public StrList()
        {

        }
    }
}
