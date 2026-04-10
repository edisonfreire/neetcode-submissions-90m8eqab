public class Solution {
        public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] squares = new HashSet<char>[9];

        for (int i=0; i<9; i++)
        {
            rows[i] = [];
            cols[i] = [];
            squares[i] = [];
        }
        
        for (int i=0; i<9; i++)
        {
            for (int j=0; j<9; j++)
            {
                char val = board[i][j];

                if (val == '.') continue;

                int square = i/3 * 3 + (j/3);

                if (!rows[i].Add(val) || !cols[j].Add(val) || !squares[square].Add(val)) return false;
            }
        }

        return true;
    }
}
