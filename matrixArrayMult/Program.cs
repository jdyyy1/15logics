using System;
using System.Linq;
using System.Threading;

class Program {
    public static void Main(String[] args) {

            // Problem: Write a program that multiplies two matrices entered by the user.
            // Concepts Used: 2D arrays, loops.
        
        Console.Write("Enter number of rows in the first matrix: ");
        int row1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns in the first matrix: ");
        int col1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of rows in the second matrix: ");
        int row2 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns in the second matrix: ");
        int col2 = int.Parse(Console.ReadLine());

        if (row1 != col2) {
            Console.WriteLine("Row1 should be equal to column2 for matrix multiplication to work!");
            int timer = 3;
            for (int i = timer; i > 0; i--) {
                Console.WriteLine("Ending program in " + i + "...");
                Thread.Sleep(1000);
            }
            System.Environment.Exit(0);
        }

        int[,] matrix1 = new int[row1, col1];
        int[,] matrix2 = new int[row2, col2];
        int[,] result = new int[row1, col2];

        Console.WriteLine("Enter elements in the first matrix: ");
        for (int i = 0; i < row1; i++) {
            for (int j = 0; j < col1; j++) {
                Console.Write($"Matrix1[{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter elements in the second matrix: ");
        for (int i = 0; i < row2; i++) {
            for (int j = 0; j < col2; j++) {
                Console.Write($"Matrix2[{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

         // Matrix multiplication
        for (int i = 0; i < row1; i++) {
            for (int j = 0; j < col2; j++) {
                result[i, j] = 0;
                for (int k = 0; k < col1; k++) {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Display the result matrix
        Console.WriteLine("Resultant matrix after multiplication:");
        for (int i = 0; i < row1; i++) {
            for (int j = 0; j < col2; j++) {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}