﻿namespace AlgoSolving.Task79_Word_Search
{
    public class Solution
    {
        public bool Exist(char[,] board, string word)
        {
            var m = board.GetLength(0);
            var n = board.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var visited = new bool[m, n];
                    if (Exist(board, word, i, j, 0, visited))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Exist(char[,] board, string word, int i, int j, int wordIndex, bool[,] visited)
        {
            var m = board.GetLength(0);
            var n = board.GetLength(1);
            if (i < 0 || j < 0 || i >= m || j >= n)
            {
                return false;
            }

            if (visited[i, j])
            {
                return false;
            }

            if (wordIndex >= word.Length)
            {
                return true;
            }

            if (board[i, j] != word[wordIndex])
            {
                return false;
            }

            visited[i, j] = true;

            var result = 
                Exist(board, word, i + 1, j, wordIndex + 1, visited)
                && Exist(board, word, i - 1, j, wordIndex + 1, visited)
                && Exist(board, word, i, j + 1, wordIndex + 1, visited)
                && Exist(board, word, i, j - 1, wordIndex + 1, visited);

            visited[i, j] = false;

            return result;
        }
    }
}