using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTDD_10Pines
{
    internal class RomanNumberTextRepresentation
    {
        public RomanNumberTextRepresentation()
        {
        }

        internal IEnumerable<char> Of(int aNumber)
        {
            StringBuilder aStringBuilder = new StringBuilder();
            
            if (aNumber >= 1 && aNumber <= 3)
            {
                for (int i = 1; i <= aNumber; i++)
                {
                    aStringBuilder.Append("I");
                }

            }

            if (aNumber == 4)
                aStringBuilder.Append("IV");

            if (aNumber >= 5 && aNumber <= 8)
            {
                aStringBuilder.Append("V");
                for (int i = 1; i <= (aNumber - 5); i++)
                {
                    aStringBuilder.Append("I");
                }

            }

            if (aNumber == 9)
                aStringBuilder.Append("IX");

            if (aNumber == 10)
                aStringBuilder.Append("X");

            if (aNumber == 11)
                aStringBuilder.Append("XI");

            if (aNumber == 12)
                aStringBuilder.Append("XII");

            return aStringBuilder.ToString();
        }
    }
}