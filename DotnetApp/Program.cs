using System.ComponentModel;
using System.Xml.Linq;
using DotnetApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dotnetapp;
class Program
{
    public static void Main(string[] args)
    {
        //FatherProperties f = new FatherProperties();
        //f.gadgets();
        //f.asserts();

        //Son s = new Son();

        //s.gadgets();
        //s.asserts();

        //RetailStock r = new RetailStock("AAPL", "Apple Inc", 23, 1.8, "Retails");
        //r.sell();
        //r.sell(4);

        //r.buy();
        //r.buy(3);


        /* Write a program that accepts 10 integers from the user, stores them in a one-dimensional array, and then calculates and
                  displays the sum and average of the numbers.
        int num = 0;
        int sum= 0;
        Console.WriteLine("Enter the numbers");
        for(int i = 0; i<10;i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;

        }
        double avg = sum / 10;
        Console.WriteLine(sum);
        Console.WriteLine(avg);

        */


        /* Find Maximum and Minimum. Create a program that finds the maximum and minimum value in a one-dimensional array of integers.

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        int max = arr[0];
        int min = arr[1];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }

        }
        Console.WriteLine("Max: "+max);
        Console.WriteLine("Min: " + min);

        */

        /*Reverse an Array - Write a method that reverses a one - dimensional array in place and prints the reversed array.

        int[] arr = { 1, 23, 45, 2 };
        for (int i = arr.Length - 1; i >= 0; i--)
        {
        Console.WriteLine(arr[i]);
        
        }
        */

        /* Frequency Count Given an array of integers, count how many times each number appears and display the result.
        int[] arr = { 1, 2, 3, 4, 2, 3, 4, 5, 2, 2 };
        bool[] visited = new bool[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i]) continue;

            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine($"{arr[i]} appears {count} time(s)");
        }
        */

        /* Matrix Addition - Write a program to add two 3x3 matrices and display the resulting matrix.
        int [,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] b = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        int[,] sum = new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0;j<3;j++)
            {
              sum[i, j] = a[i, j] + b[i, j];
            }
        }
        for(int i = 0;i<3;i++)
        {
            for(int j = 0;j <3;j++)
            {
                Console.Write(sum[i, j]+" ");
            }

            Console.WriteLine();
        }

        */

        /* Matrix Multiplication - Create a program that multiplies two matrices(e.g., 3x2 and 2x4) and displays the result.

        int[,] A = {{1, 2},{3, 4},{5, 6}};

        int[,] B = {{7, 8, 9, 10},{11, 12, 13, 14}};

        int[,] result = new int[3, 4];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
        */
        /* Transpose of a Matrix - Write a program to compute and print the transpose of a 3x3 matrix.
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        Console.WriteLine("Original Matrix:");

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Traspose Matrix");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[j,i] + "\t");
            }
            Console.WriteLine();
        }

        */


        //Diagonal Sum Given a 3x3 matrix, calculate the sum of the main diagonal and the secondary diagonal elements.

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int mainDiagonal = 0;
        int secDiagonal = 0;

        for(int i =0; i< 3; i++)
        {
            mainDiagonal += matrix[i,i];
            secDiagonal += matrix[i, 2 - i];
        }

        Console.WriteLine("Main Diagonal Sum: " + mainDiagonal);
        Console.WriteLine(("Secondary Diagonal Sum: " + secDiagonal));


    }
}
