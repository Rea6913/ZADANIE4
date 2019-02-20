using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            // put your code here
            //throw new NotImplementedException();
            int kol = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'o' || str[i] == 'i' || str[i] == 'u')
                    kol++;
            return (kol);



        }
    }
}
