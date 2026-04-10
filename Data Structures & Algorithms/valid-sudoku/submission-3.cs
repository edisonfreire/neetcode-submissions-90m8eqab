public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, HashSet<int>> rows = [];
        Dictionary<int, HashSet<int>> cols = [];
        Dictionary<int, HashSet<int>> squares = [];
        
        for (int i=0; i<9; i++)
        {
            for (int j=0; j<9; j++)
            {
                if (board[i][j] == '.') continue;

                rows.TryAdd(i, []);
                if (!rows[i].Add(board[i][j])) return false;

                cols.TryAdd(j, []);
                if (!cols[j].Add(board[i][j])) return false;

                int square = i/3 * 3 + (j/3);
                squares.TryAdd(square, []);
                if(!squares[square].Add(board[i][j])) return false;
            }
        }

        return true;
    }
}
