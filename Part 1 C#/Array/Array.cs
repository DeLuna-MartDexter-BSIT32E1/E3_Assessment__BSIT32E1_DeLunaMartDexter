using System;

class Arrayof5Number
{
    static void Main()
    {
        // Declare an array of 5 integers
        int[] array = new int[5];

        // Fill the array with values based on the user-defined formula (n^2)
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for array index " + i + ": ");
            int n = Convert.ToInt32(Console.ReadLine());
            array[i] = n * n;
        }

        // Print the largest element in the array
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("The largest element in the array is: " + max);
    }
}