using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Basics
{
    class StringPro
    {
        public static void StringIndex(string s) {
            //char a=s[0];
            for (int i = 0; i < s.Length; i++) {
                Console.WriteLine(s[i]);
            }
        }

        public static void StringTest() {
            string s = "123456789";
            Console.WriteLine(s);
            StringIndex(s);
        }
    }
}
