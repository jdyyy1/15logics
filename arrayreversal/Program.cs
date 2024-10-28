class Program {
    public static void Main(String[] args) {

        Console.WriteLine("How many u want to put in an array?");
        int numofArray = Convert.ToInt32(Console.ReadLine());

            string[] array = new string[numofArray];
        for(int i = 0; i < numofArray; i++) {
            Console.Write("Enter data number " + (i+1) + " : ");
            array[i] = Console.ReadLine();
        }
        foreach (string data in array) {
            string reverse = "";
            for (int i = 0; i < data.Length; i++) {
                reverse = data[i] + reverse;
            }
            Console.WriteLine("\t" + reverse);
        }
    }
}