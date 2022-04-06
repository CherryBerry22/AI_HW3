namespace HW2
{
    class HW2
    {
        class GameNode
        {
            private char[] gameState = new char[9];
            int ply;
            int hValue;

            public GameNode(char[] gameState, int depth, int hValue)
            {
                this.gameState = gameState;
                this.ply = depth;
                this.hValue = hValue;
            }
        }


        private static char[] board;
        public static void Main()
        {
            board = new char[9] { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' };

            GameNode root = new GameNode(board, 1, 0);

            printBoard(board);
            Console.WriteLine();

            playGame(board);
        }

        private static void playGame(char[] board)
        {
            initializeBoard(board);
            bool gameOver = false;
            char playerTurn = 'W';
            while (!gameOver)
            {
                board = takeTurn(board, playerTurn);
                printBoard(board);
                gameOver = isWin(board, playerTurn);

                if (playerTurn == 'W')
                    playerTurn = 'B';
                else
                    playerTurn = 'W';
            }

            // Must be inverted since the current player's turn gets updated after placement.
            if (playerTurn == 'B')
                Console.WriteLine("Player 1 (White) wins!");
            else
                Console.WriteLine("Player 2 (Black) wins!");
        }

        private static char[] takeTurn(char[] board, char player)
        {
            if (player == 'W')
                Console.Write("Player 1 (White) please select an index to move a piece from: ");
            else
                Console.Write("Player 2 (Black) please select an index to move a piece from: ");

            // Read in what piece to move.
            int indexFrom = Convert.ToInt32(Console.ReadLine());

            // Check if the index to move from is within the board's range and contains one of the player's pieces.
            while (indexFrom < 1 || indexFrom > 9 || board[indexFrom - 1] != player)
            {
                if (indexFrom < 1 || indexFrom > 9)
                    Console.Write("That index was out of bounds! Please input a valid board index to move a piece from: ");
                else
                    Console.Write("That index doesn't contain one of your pieces! Please input a valid board index to move a piece from: ");

                indexFrom = Convert.ToInt32(Console.ReadLine());
            }

            // Read in where to move the piece to.
            Console.Write("And an index to move to: ");
            int indexTo = Convert.ToInt32(Console.ReadLine());

            // Check if the index to move to is within the board's range and is open.
            while (indexTo < 1 || indexTo > 9 || board[indexTo - 1] != 'O')
            {
                if (indexTo < 1 || indexTo > 9)
                    Console.Write("That index was out of bounds! Please input a valid board index to move a piece to: ");
                else
                    Console.Write("That index is already taken! Please input a valid board index to move a piece to: ");

                indexTo = Convert.ToInt32(Console.ReadLine());
            }

            // Now we can actually move the pieces.
            board[indexFrom - 1] = 'O';
            board[indexTo - 1] = player;

            return board;
        }

        private static void printBoard(char[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(board[i] + " ");
                if ((i+1) % 3 == 0)
                    Console.WriteLine();
            }
        }

        private static void initializeBoard(char[] board)
        {
            int boardIndex;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Player 1 (White) please input a board index to place a piece on: ");
                boardIndex = Convert.ToInt32(Console.ReadLine());

                while (boardIndex < 1 || boardIndex > 9 || board[boardIndex - 1] != 'O')
                {
                    if (boardIndex < 1 || boardIndex > 9)
                        Console.Write("That index was out of bounds! Please input a valid board index to place a piece on: ");
                    else
                        Console.Write("That index is already taken! Please input a valid board index to place a piece on: ");

                    boardIndex = Convert.ToInt32(Console.ReadLine());
                }
                board[boardIndex - 1] = 'W';
                printBoard(board);

                Console.Write("Player 2 (Black) please input a board index to place a piece on: ");
                boardIndex = Convert.ToInt32(Console.ReadLine());

                while (boardIndex < 1 || boardIndex > 9 || board[boardIndex - 1] != 'O')
                {
                    if (boardIndex < 1 || boardIndex > 9)
                        Console.Write("That index was out of bounds! Please input a valid board index to place a piece on: ");
                    else
                        Console.Write("That index is already taken! Please input a valid board index to place a piece on: ");

                    boardIndex = Convert.ToInt32(Console.ReadLine());
                }
                board[boardIndex - 1] = 'B';
                printBoard(board);
            }
        }

        private static bool isWin(char[] board, char player)
        {
            bool isWin = false;
            // Check for 3 in a row horizontally
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == player && board[i + 3] == player && board[i + 6] == player)
                    isWin = true;
            }

            // Check for 3 in a row vertically
            for (int i = 0; i < 9; i+=3)
            {
                if (board[i] == player && board[i + 1] == player && board[i + 2] == player)
                    isWin = true;
            }

            // Check for 3 in a row diagonally (NOT SURE IF NEEDED)

            return isWin;
        }

        private static int WinPaths(char[] board, char player)
        {
            int winPathsWhite = 0;
            int winPathsBlack = 0;


            return winPathsBlack - winPathsWhite;
        }
    }

}

