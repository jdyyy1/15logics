class Program {
    public static void Main(string[] args) {


        while (true) {
        Console.Write("Enter int for fibo sequence: ");
        int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0) {
                System.Environment.Exit(0);
            }

        // sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
        int seq = 0;
        int seq1 = 1;
        int newseq=0;
        for (int i = 0; i < input; i++) {
        Console.Write(seq + " ");
            newseq = seq + seq1;
            seq = seq1;
            seq1 = newseq;
            }
            Console.WriteLine();
        }
    }
}