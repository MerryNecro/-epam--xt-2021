using System;

namespace CastomStrings
{
    public class CastomString
    {
        private char[] charArray { get; set; }

        public CastomString()
        {
            charArray = new char[0];
        }

        public CastomString(char[] arr)
        {
            charArray = (char[])arr.Clone();
        }

        public CastomString(string str)
        {
            charArray = str.ToCharArray();
        }

        public char this[int i]
        {
            set => charArray[i] = value;
            get => charArray[i];
        }

        public int Length()
        {
            return charArray.Length;
        }

        public int IndexOf(char c)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(char c)
        {
            int result = -1;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == c)
                {
                    result = i;
                }
            }
            return result;
        }

        public CastomString Clone()
        {
            return new CastomString((char[])charArray.Clone());
        }

        public bool Contains(char symbol)
        {
            if (this.IndexOf(symbol)!=-1) { return true; }
            return false;
        }

        public int CompareTo(CastomString argument)
        {
            if (argument == null)
            {
                return 1;
            }
            return CompareTo(argument.ToString());
        }

        public int CompareTo(string argument)
        {   
            if (argument == null)
            {
                return 1;
            }

            return this.ToString().CompareTo(argument);
        }

        public override bool Equals(object argument)
        {
            if (argument is string)
            {
                if (this.CompareTo(argument as string) == 0) return true;
                return false;
            }

            if(argument is CastomString)
            {
                return Equals(argument as CastomString);
            }

            return false;
        }

        public bool Equals(CastomString argument)
        {
            if (this.CompareTo(argument) == 0) return true;
            return false;
        }

        public CastomString ToLower()
        {
            for(int i = 0; i<charArray.Length; i++)
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            return this;
        }

        public CastomString ToUpper()
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            return this;
        }

        public override string ToString()
        {
            return new string(charArray);
        }

        public char[] ToCharArray()
        {
            return (char[])charArray.Clone();
        }

        public static CastomString operator +(CastomString firstArgument, CastomString secondArgument)
        {

            char[] resultCharArray = new char[firstArgument.charArray.Length + secondArgument.charArray.Length];
            Array.Copy(firstArgument.charArray, 0, resultCharArray, 0, firstArgument.charArray.Length);
            Array.Copy(secondArgument.charArray, 0, resultCharArray, firstArgument.charArray.Length, secondArgument.charArray.Length);
            return new CastomString(resultCharArray);
        }

        public override int GetHashCode()
        {
            int result = 0;
            foreach (char a in charArray)
            {
                result += Convert.ToInt32(a);
            }
            return result;
        }
    }
}
