using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWK03_lib
{
    public class IntList
    {
        internal IntNode Head;
        public int Size = 0;
        public void Add(int value)
        {
            ++Size;
            IntNode new_INode = new IntNode(value);
            if (this.Head == null)
            {
                this.Head = new_INode;
                return;
            }
            IntNode lastNode = GetLastNode();
            lastNode.next = new_INode;
        }
        internal IntNode GetLastNode()
        {
            IntNode temp = this.Head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void RemoveAt(int index)
        {
            --Size;
            IntNode temp = this.Head;
            IntNode prev = null;
            
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

            IntNode temp = this.Head;
            while (temp != null)
            {
                str += Convert.ToString(temp.value) + " ";  
                temp = temp.next;
            }
            return str;
        }
        public IntList()
        {

        }
    }
}
