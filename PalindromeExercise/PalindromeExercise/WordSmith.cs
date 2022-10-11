using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string strName)
        {
            char[] cArray = strName.ToLower().ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            if (strName.ToLower() == reverse)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
