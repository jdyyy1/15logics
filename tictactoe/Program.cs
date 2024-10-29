using System;

class Program {
    public static void Main(string[] args) {
        // 3x3 board initialized with cell numbers
        char[,] table = { {'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'} };
        char player = 'X';  // Start with player 'X'
        bool gameWon = false;
        
        // Main game loop
        while (true) {
            Console.Clear();
            DisplayBoard(table);

            // Ask player to select a cell
            Console.WriteLine($"Player {player}, enter the cell number (1-9) where you want to place your mark:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int cellNumber) && cellNumber >= 1 && cellNumber <= 9) {
                int row = (cellNumber - 1) / 3;
                int col = (cellNumber - 1) % 3;

                // Check if the cell is available
                if (table[row, col] != 'X' && table[row, col] != 'O') {
                    table[row, col] = player;  // Place the player's mark
                    gameWon = CheckWin(table, player);  // Check for a win

                    if (gameWon) {
                        Console.Clear();
                        DisplayBoard(table);
                        Console.WriteLine($"Player {player} wins!");
                        break;
                    }
                    
                    // Check for a draw
                    if (IsDraw(table)) {
                        Console.Clear();
                        DisplayBoard(table);
                        Console.WriteLine("It's a draw!");
                        break;
                    }
                    
                    // Switch players
                    player = (player == 'X') ? 'O' : 'X';
                } else {
                    Console.WriteLine("That cell is already taken. Try again.");
                }
            } else {
                Console.WriteLine("Invalid input. Enter a number between 1 and 9.");
            }
        }
    }

    // Method to display the board
    static void DisplayBoard(char[,] table) {
        for (int row = 0; row < table.GetLength(0); row++) {
            for (int col = 0; col < table.GetLength(1); col++) {
                Console.Write(table[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    // Method to check if the current player has won
    static bool CheckWin(char[,] table, char player) {
        // Check rows, columns, and diagonals
        for (int i = 0; i < 3; i++) {
            if ((table[i, 0] == player && table[i, 1] == player && table[i, 2] == player) || // Row check
                (table[0, i] == player && table[1, i] == player && table[2, i] == player))   // Column check
                return true;
        }
        // Diagonal checks
        if ((table[0, 0] == player && table[1, 1] == player && table[2, 2] == player) ||
            (table[0, 2] == player && table[1, 1] == player && table[2, 0] == player))
            return true;

        return false;
    }

    // Method to check if the board is full (draw condition)
    static bool IsDraw(char[,] table) {
        foreach (char cell in table) {
            if (cell != 'X' && cell != 'O') {
                return false;
            }
        }
        return true;
    }
}
