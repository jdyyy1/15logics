using System.Threading;
class Program {
    public static void Main(string[] args) {

        while (true) {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /, %, x): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result=0.00;
        switch (op) {
            case '+':
            result = num1+num2;
            break;
            case '-':
            result = num1-num2;
            break;
            case '*':
            result = num1*num2;
            break;
            case '/':
            result = num1/num2;
            break;
            case '%':
            result = num1%num2;
            break;
            case 'x':
            int timer = 3;
            for (int i = timer; i > 0; i--) {
                Console.WriteLine("Terminating program in " + i + "...");
                Thread.Sleep(1000);
            }
            System.Environment.Exit(0);
            break;
            default:
            Console.WriteLine("Wrong input operator. Try again.");
            break;
        }
        Console.WriteLine("Result = " + result);
        }
        
    }
}