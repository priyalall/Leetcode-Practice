using System;

class Program
{
    static void Main()
    {
        int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
        int target = 10;
        int len = arr1.Length - 1;

        int left = 0;
        int right = arr1.Length - 1;

        while (left < right)
        {
            int sum = arr1[left] + arr1[right];
            if (sum == target)
            {
                Console.WriteLine($"Pair found :{arr1[left]} , {arr1[right]}");
                return;
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }

        }
        Console.WriteLine("No pair found.");
    }
}

