using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWK03_lib
{
    public class Randomizers
    {
        Random random = new Random();
        public void IntRnd(IntList list, int CountOfNodes)
        {
            try
            {
                for (int i = 0; i < CountOfNodes; i++)
                {
                    list.Add(random.Next(10, 99));
                }
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка!");
            }
        }
        public void StrRnd(StrList list, int CountOfNodes, int LenOfString)
        {
            try
            {              
                for (int i = 0; i < CountOfNodes; i++)
                {
                    list.Add(RandomString(LenOfString));
                }
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка!");
            }
        }
        internal string RandomString(int len)
        {
            string str = string.Empty;
            for (int i = 0; i < len; i++)
            {
                str += (char)random.Next(65, 122);
            }
            return str;
            
        }
        public Randomizers() { }

    }
}
