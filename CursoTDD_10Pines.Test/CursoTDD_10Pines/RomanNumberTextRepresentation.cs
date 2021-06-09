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
            int tens = ( aNumber / 10 ) % 10;

            ConvertDigitUsing(tens, aStringBuilder, 'X', 'L', 'C');
            ConvertDigitUsing(units, aStringBuilder);

            return aStringBuilder.ToString();

        }

        private void ConvertDigitUsing(
            int aNumber, 
            StringBuilder aStringBuilder, 
            char asOne = 'I', 
            char asFive = 'V', 
            char asTen = 'X'
        )
        {
            if (aNumber >= 1 && aNumber <= 3)
            {
                for (int i = 1; i <= aNumber; ++i)
                {
                    aStringBuilder.Append(asOne);
                }
            }

            if (aNumber == 4)
            {
                aStringBuilder.Append(asOne);
                aStringBuilder.Append(asFive);
            }

            if (aNumber >= 5 && aNumber <= 8)
            {
                aStringBuilder.Append(asFive);
                for (int i = 1; i <= aNumber - 5; ++i)
                {
                    aStringBuilder.Append(asOne);
                }
            }

            if (aNumber == 9)
            {
                aStringBuilder.Append(asOne);
                aStringBuilder.Append(asTen);
            }

        }

    }
}