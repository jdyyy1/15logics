class Program {
    public static void Main (string[] args) {

            // Problem: Implement bubble sort to sort an array of integers.
            // Concepts Used: Arrays, sorting algorithms, loops.
            bool looping = true;
        while(looping) {
        Console.Write("How many do u want to store in an array: ");
        int input = Convert.ToInt32(Console.ReadLine());
            if(input == 0) {
                System.Environment.Exit(0);
            }

        int[] array = new int[input];
        int a = 0;
        for (int i = 1; i <= input; i++) {
            Console.WriteLine("Int #" + i + ": ");
            array[a] = Convert.ToInt32(Console.ReadLine());
            a++;
        }
        Console.WriteLine("\n\n---This is your input by random---");
        foreach (int ints in array) {
            Console.Write(ints + " ");
        }
        Console.WriteLine("\n\n---This is your input by bubble sort---");
            Array.Sort(array);
        foreach (int sorts in array) {
            Console.Write(sorts + " ");
            }
            Console.Write("\n\nWould you like to use this program again?(Y/N): ");
            string response = Convert.ToString(Console.ReadLine()).ToUpper();
            if (response == "Y") {
                continue;
            }
            else {
                looping = false;
            }
        }
    }
}