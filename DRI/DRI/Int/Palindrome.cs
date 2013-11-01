using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int
{
    public class Palindrome
    {
        public bool IsPalindromWithSpaceAgnostic(string s) {
            int i = 0; 
            int j = s.Length - 1;

            do{
                while(i<s.Length && s[i]==' ') i++;
                while(j>=0 && s[j]==' ') j--;

                if (i >= j) return true;
                if(s[i++]!=s[j--]) return false; 
                           
            } while(true); 
            
        }
    }
}
