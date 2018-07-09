using System;
using System.Collections.Generic;
using System.Text;

namespace _1._3_URLify
{
    public static class Implementation
    {
        public static string replaceSpacesInInputStringOne(string aString)
        {
            int aStringLenght = aString.Length;

            int countWhiteSpaces = 0;
            for (var i = 0; i < aStringLenght; i++)
            {
                if (aString[i] == ' ') { countWhiteSpaces++; }
            }
            //LD I will replace with two underscore each whitespace
            var aCharArray = new char[aStringLenght + (countWhiteSpaces)]; //LD in order to have 2 sports for each white space

            var aCharArrayFinalIndex = aCharArray.Length - 1;

            for (int i = aStringLenght-1; i>= 0; i--)
            {
                if (aString[i] != ' ')
                {
                    aCharArray[aCharArrayFinalIndex] = aString[i];
                    aCharArrayFinalIndex--;
                }
                else
                {
                    aCharArray[aCharArrayFinalIndex] = '_';
                    aCharArray[aCharArrayFinalIndex-1] = '_';
                    aCharArrayFinalIndex = aCharArrayFinalIndex - 2;
                }
            }

        return new string(aCharArray);
        }

        


    }
}
