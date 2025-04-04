using System;
 class Program
{
    static void Main()
    {
        char[] arr = { 'a', 'b', 'c', 'b', 'a' };

        int left = 0;
        int right=arr.Length-1;
        while (left < right) 
        {
            if (arr[left] == arr[right])
            {
                left++;
                right--;
            }

            else
            {
                Console.WriteLine("not a pallendrome");
                break;
            }

        }
        Console.WriteLine(  "its a pallendrome ");

    }
}
