class Array{ 
        // Declare a single-dimensional array
        byte[] ages = new byte[100];

        string[] names = {"Deep", "Ram", "Shyam"};

        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // multi-dimensional string
        string[,] chessBoard1 = new string[8, 8];
        string[,] chessBoard2 = {
            {"A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8"},
            {"B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8"},
            {"C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8"},
            {"D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8"},
            {"E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8"},
            {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8"},
            {"G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8"},
            {"H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8"},
        };

        // Jagged Array
        bool[][] data = new bool[5][];
        // initialize
        void AssignVariables(){
            data[0] = new bool[3] {true, false, false};
            data[1] = new bool[2] {true, false};
        }
        bool[] c = {true, false};
}