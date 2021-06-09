using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTDD_10Pines
{
    internal class RomanNumberTextRepresentation
    {
        internal IEnumerable<char> Of(int aNumber)
        {
            StringBuilder aStringBuilder = new StringBuilder();

            int units = aNumber % 10;

            if (aNumber >= 10 && aNumber <= 19)
            {
                aStringBuilder.Append("X");
            }

            if (aNumber >= 20 && aNumber <= 29)
            {
                aStringBuilder.Append("XX");
            }

            if (aNumber >= 30 && aNumber <= 39)
            {
                aStringBuilder.Append("XXX");
            }

            if (aNumber >= 40 && aNumber <= 49)
            {
                aStringBuilder.Append("XL");
            }

            ConvertDigitUsing(units, aStringBuilder);

            return aStringBuilder.ToString();

        }

        private void ConvertDigitUsing(int aNumber, StringBuilder aStringBuilder)
        {
            if (aNumber >= 1 && aNumber <= 3)
            {
                for (int i = 1; i <= aNumber; ++i)
                {
                    aStringBuilder.Append("I");
                }
            }

            if (aNumber == 4)
            {
                aStringBuilder.Append("IV");
            }

            if (aNumber >= 5 && aNumber <= 8)
            {
                aStringBuilder.Append("V");
                for (int i = 1; i <= aNumber - 5; ++i)
                {
                    aStringBuilder.Append("I");
                }
            }

            if (aNumber == 9)
            {
                aStringBuilder.Append("IX");
            }

        }

    }
}