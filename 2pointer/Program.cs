using System;
namespace LearnDictionaryTutorial
{
    internal class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2,4,6 ,7};

            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result[k++] = arr1[i++];
                    
                }
                else
                {
                    result[k++] = arr2[j++];
                }

            }
            while(i < arr1.Length)
            {
                result[k++]= arr1[i++];
            }

            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
               
            }
            for (int m =0; m < result.Length; m++)
            Console.WriteLine(result[m]);
        }
    }
}