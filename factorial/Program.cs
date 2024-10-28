class Program {
    public static void Main(string[] args) {

        while (true) {
        Console.Write("Enter a number to calculate its factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result of your input: " + RecursionFactorial(num));

        int RecursionFactorial(int num) {
            if (num == 0) {
                return 1;
            }
            return num * RecursionFactorial(num-1);
            }
        }
    }
}