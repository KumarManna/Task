using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class SubString
    { 
        protected List<char> Sub(string k)
        {
            //string k = "Apple,Banana,Cherry,Mango,This is test.";
            //string k = Console.ReadLine();
            char[] c = k.ToCharArray();
            List<char> ch = new List<char>();
            //char[] seperators = { '.', ';', ',', '!', '&' };

            foreach (char m in c)
            {
                if (m == ' ' || m == '.' || m == ',' || m == ';')
                {
                    ch.Add('\n');
                }
              
                else
                    ch.Add(m);

            }/*
            foreach(char x in ch)
            {

                Console.Write(x.ToString());
            }*/
            return ch;
        }
    }
}
