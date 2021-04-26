using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperString
{
    public static class StringExtensionMethods
    {
        public static StringLanguage CheckingLanguage(this string inputString)
        {
            if (inputString == string.Empty)
            {
                return StringLanguage.None;
            }

            StringLanguage currentType = CheckingChar(inputString[0]);

            if (currentType == StringLanguage.Mixed)
            {
                return StringLanguage.Mixed;
            }

            if (inputString.All(item => CheckingChar(item) == currentType))
            {
                return currentType;
            }
            else
            {
                return StringLanguage.Mixed;
            }
        }

        private static StringLanguage CheckingChar(char ch)
        {
            if((ch>='А'&&ch<='я')||ch=='ё'|| ch == 'Ё')
            {
                return StringLanguage.Russian;
            }

            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                return StringLanguage.English;
            }

            if (ch >= '0' && ch <= '9')
            {
                return StringLanguage.Number;
            }

            return StringLanguage.Mixed;
        }

    }
    public enum StringLanguage
    {
        None = 0,
        Russian,
        English,
        Number,
        Mixed
    }
}
