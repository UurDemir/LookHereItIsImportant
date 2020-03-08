using System;
using System.Collections.Generic;

namespace LHIII.Common
{
    public static class RandomHelper
    {
        private static  Random random = new Random();
        public static string GenerateString(int length)
        {
            char[] generatedValue = new char[length];

            for (int i = 0; i < length; i++)
            {
                if (random.Next() % 2 == 0)
                    generatedValue[i] = (char)random.Next(65, 90);
                else
                    generatedValue[i] = (char)random.Next(97, 122);

            }

            return new string(generatedValue);
        }
        public static string GenerateUniqueString(int length,string[] values)
        {
            char[] generatedValue = new char[length];

            for (int i = 0; i < length; i++)
            {
                if (random.Next() % 2 == 0)
                    generatedValue[i] = (char)random.Next(65, 90);
                else
                    generatedValue[i] = (char)random.Next(97, 122);

            }

            return new string(generatedValue);
        }
    }
}
