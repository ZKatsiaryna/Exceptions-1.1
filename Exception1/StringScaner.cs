using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    public class StringScaner
    {
        public StringScaner()
        {
        }

        public char[] GetFirstSymbol(List<string> listStr)
        {
            char[] arrayFirstSymbols = new char[listStr.Count];

            for (int i = 0; i < listStr.Count; i++)
            {
                if (String.IsNullOrEmpty(listStr[i]))
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                else
                {
                    arrayFirstSymbols[i] = listStr[i].First();
                }
            }
            return arrayFirstSymbols;
        }
    }
}
