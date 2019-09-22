using System;

namespace _1_LargetCommonEnd
{
    class Program
    {

        static void Main(string[] args)
        {
            String str1;
            String str2;
            String str3;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            int[,] arr = new int[str1.Length, str2.Length];

            int newStrLength = 0, m2 = 0;

            int i, j;
            for (i = 0; i < str1.Length; i++)
            {
                for (j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        if (i == 0 || j == 0)
                        {
                            arr[i, j] = 1;
                        }
                        else
                        {
                            arr[i, j] = arr[i - 1, j - 1] + 1;
                        }
                        if (arr[i, j] > newStrLength)
                        {
                            newStrLength = arr[i, j];
                            m2 = i;
                        }
                    }
                }
            }

            str3 = str1.Substring(m2 + 1 - newStrLength, newStrLength); //m2 + 1 - newStrLength це індекс початку обрізки а newStrLength довжина обрізаної частини
            if (str3[0] == ' ')
            {
                str3 = str3.Remove(0, 1); //видаляємо перший пробіл
            }
            if (str3[str3.Length - 1] == ' ')
            {
                str3 = str3.Remove(str3.Length - 1, 1);
            }
            //Console.WriteLine(str3);

            string[] words = str3.Split(new char[] { ' ' });

            Console.WriteLine("Result: " + words.Length);
        }
    }
}
