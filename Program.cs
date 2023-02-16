/*
Author: Alicia Sullivan
Date: 02/16/2023
Description:C# console application using methods
*/

namespace Deliverable_5_;
class Program
{

    static int[] random_array(int array_len)
    {
        Random random = new Random();
        int[] MyArray = new int[array_len];
        for (int i = 0; i < array_len; i++)
        {
            MyArray[i] = random.Next(10, 50);
        }
        return MyArray;
    }

    static int sum(int[] array)
    {
        int sum = 0;
        foreach (int item in array)
        {
            sum = sum + item;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter an integer between 5 and 15");
            int input = int.Parse(Console.ReadLine());
            int[] sampleArray = random_array(input);

            if(input > 4 && input < 16)
            {
                Console.WriteLine("The elements in the random array are: ");
                foreach (int element in sampleArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(sampleArray));
            }

            else
            {
                Console.WriteLine("Invalid. Please enter an integer between 5 and 15");
            }
        }
        catch
        {
            Console.WriteLine("Invalid. Please enter an integer between 5 and 15");
        }
    }
}