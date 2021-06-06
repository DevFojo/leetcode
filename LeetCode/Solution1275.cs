using Xunit;

namespace LeetCode
{
    public class Solution1275
    {
        public string Tictactoe(int[][] moves)
        {
            var board = new string[3, 3];
            var movesPlayed = 0;
            for (var i = 0; i < moves.Length; i++)
            {
                var move = moves[i];
                movesPlayed++;
                var currentPlayer = i % 2 == 0 ? "A" : "B";
                board[move[0], move[1]] = currentPlayer;
                if (i <= 3)
                {
                    continue;
                }

                if (SomeoneWins(board, move))
                {
                    return currentPlayer;
                }
            }

            return movesPlayed < 9 ? "Pending" : "Draw";
        }

        private bool SomeoneWins(string[,] board, int[] move)
        {
            return board[move[0], 0] == board[move[0], 1] && board[move[0], 0] == board[move[0], 2] ||
                   board[0, move[1]] == board[1, move[1]] && board[0, move[1]] == board[2, move[1]] ||
                   board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[1, 1] != null ||
                   board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[1, 1] != null;
        }


        [Fact]
        public void Test()
        {
            Assert.Equal("Pending", Tictactoe(new[]
            {
                new[] {0, 2}, new[] {2, 0}, new[] {2, 1}, new[] {0, 1}, new[] {1, 2}
            }));
        }
    }
}
