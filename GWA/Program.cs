class Program {
    public static void Main(string[] args) {

            // Problem: Write a program that takes the scores of students and calculates their grades (A, B, C, D, F) based on predefined criteria.
            // Concepts Used: Arrays, conditionals, loops.
        Console.Write("How many subjects do you have: ");
        int input = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[input];

        for (int i = 0; i < input; i++) {
            Console.Write("Enter grade in subject " + (i+1) + ": ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int grades in array) {
            Console.WriteLine("Your input grades are: " + grades);
        }
        int sum = 0;
        foreach (int gwa in array) {
            sum += gwa;
        }
        double computedGrade = (double)sum / input;
        Console.WriteLine("Your gwa is: " + computedGrade);
    }
}