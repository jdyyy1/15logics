using System;


            // Problem: Implement a binary search algorithm to search for an element in a sorted array.
            // Concepts Used: Algorithms, loops, conditionals.

public class BinarySearchExample
{
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if target is present at mid
            if (arr[mid] == target)
            {
                return mid;
            }

            // If target is greater, ignore left half
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            // If target is smaller, ignore right half
            else
            {
                right = mid - 1;
            }
        }

        // Target is not in the array
        return -1;
    }

    public static void Main(string[] args)
    {
        int[] arr = {2, 3, 4, 10, 40};
        int target = 40;
        int result = BinarySearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine("\n\nElement found at index " + result + " using binary search\n\n");
        }
        else
        {
            Console.WriteLine("Element not found in the array");
        }
    }
}
