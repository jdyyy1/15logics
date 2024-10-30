class Program {
    public static void Main(string[] args) {

            // Problem: Write a program that finds the largest and smallest numbers in an array without using built-in functions.
            // Concepts Used: Arrays, loops, conditionals.

        int[] array = new int[] {8, 9, 3, 4, 10, 9, 21, 15};

        //finding smallest and largest num without build in functions, pure logic

        int smallest = array[0];
        int largest = array[0];
        
        for (int i = 1; i < array.Length; i++) {
            if (array[i] < smallest) {
                smallest = array[i];
            }
            if (array[i] > largest) {
                largest = array[i];
            }
        }
        Console.WriteLine("Array output :");
        foreach (int a in array) {
            Console.Write(a + " ");
        }
        Console.WriteLine("\nSmallest number: " + smallest);
        Console.WriteLine("Largest number: " + largest);

        // sorting array using a built in function
        Array.Sort(array); 
        foreach (int sorts in array) {
            Console.Write (sorts + " ");
        }
        Console.WriteLine();
        
        bool loop = true;
        while (loop) {
            Console.Write("How many data? ");
            int input = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[input];
            for (int i = 0; i < input; i++) {
                Console.WriteLine("Enter ints: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        //finding smallest and largest num without build in functions, pure logic
            int small = arr[0];
            int large = arr[0];
        
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] < small) {
                small = arr[i];
            }
            if (arr[i] > large) {
                large = arr[i];
            }
        }
        Console.WriteLine("Array output :");
        foreach (int a in arr) {
            Console.Write(a + " ");
        }
        Console.WriteLine("\nSmallest number: " + small);
        Console.WriteLine("Largest number: " + large);

        // sorting array using a built in function
        Console.WriteLine("Sorted array: ");
        Array.Sort(arr); 
        foreach (int sorts in arr) {
            Console.Write (sorts + " ");
        }
        Console.WriteLine();
        Console.Write("Would u still continue? (Y/N): ");
        char response = char.ToUpper(Convert.ToChar(Console.ReadLine()));
        if (response == 'Y') {
            continue;
        }
        else {
            loop = false; //exit while loop
            }
        }
    }
}