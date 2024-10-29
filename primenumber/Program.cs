class Program {
    public static void Main(string[] args) {
        Console.WriteLine("From 1 up to what? Prime number generator: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0) {
            Console.WriteLine("Sorry, number only start from 1");
        }
        for (int i = 1; i <= input; i += 2) {
            Console.Write(i + " ");
        }
    }
}