class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Enter a palindrome word and we'll check if it's symmetrical\nReturn false if not");
        string input = Console.ReadLine();

        string reverse = "";
        for (int i = 0; i < input.Length; i++) {
            reverse = input[i] + reverse;
        }
        Console.WriteLine("Your input: " + input);
        Console.WriteLine("Reversed : " + reverse);
        if (input == reverse) {
            Console.WriteLine("True");
        }
        else 
        Console.WriteLine("False");
    }
}