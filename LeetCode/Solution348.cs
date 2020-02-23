using System;

namespace LeetCode
{
    public class Solution348
    {
        public class TicTacToe
        {
            private readonly int[] _cols;
            private readonly int[] _dias;
            private readonly int _n;
            private readonly int[] _rows;
            private int _moves;


            /**
             * Initialize your data structure here.
             */
            public TicTacToe(int n)
            {
                _n = n;
                _rows = new int[n];
                _cols = new int[n];
                _dias = new int[2];
            }

            /**
             * Player {player} makes a move at ({row}, {col}).
             * @param row The row of the board.
             * @param col The column of the board.
             * @param player The player, can be either 1 or 2.
             * @return The current winning condition, can be either:
             * 0: No one wins.
             * 1: Player 1 wins.
             * 2: Player 2 wins.
             */
            public int Move(int row, int col, int player)
            {
                _moves++;
                var s = player == 1 ? 1 : -1;
                var r = row;
                var c = col;

                _rows[r] += s;
                _cols[c] += s;
                if (row == col)
                {
                    _dias[0] += s;
                }

                if (row + col == _n - 1)
                {
                    _dias[1] += s;
                }

                if (_moves >= _n && (Math.Abs(_rows[r]) == _n || Math.Abs(_cols[c]) == _n ||
                                     row == col && Math.Abs(_dias[0]) == _n ||
                                     row + col == _n - 1 && Math.Abs(_dias[1]) == _n))
                {
                    return player;
                }


                return 0;
            }
        }

        /**
         * Your TicTacToe object will be instantiated and called as such:
         * TicTacToe obj = new TicTacToe(n);
         * int param_1 = obj.Move(row,col,player);
         */
    }
}