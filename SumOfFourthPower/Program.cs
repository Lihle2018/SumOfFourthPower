using System;

class Program
{
    //Explanation:

    //The program loops through all four-digit numbers from 1000 to 9999 using a for loop.For each number, it calculates the sum of the fourth powers of its digits by extracting each digit one by one using a while loop and then using the Math.Pow() function to raise it to the fourth power and add it to the sum.

    //If the sum is equal to the original number, the program prints the number to the console.

   //Note that this program assumes that there are exactly three four-digit numbers that can be written as the sum of the fourth powers of their digits. This is known to be true, but if you wanted to make the program more general, you could add a counter variable that keeps track of how many such numbers have been found and stops the loop once it reaches three.
    static void Main(string[] args)
    {
        for (int i = 1000; i <= 9999; i++)
        {
            int sum = 0;
            int temp = i;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, 4);
                temp /= 10;
            }

            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
