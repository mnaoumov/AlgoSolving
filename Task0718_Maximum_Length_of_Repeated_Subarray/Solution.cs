﻿using System;

namespace AlgoSolving.Task0718_Maximum_Length_of_Repeated_Subarray
{
    public class Solution
    {
        // ReSharper disable InconsistentNaming
        public int FindLength(int[] A, int[] B)
        // ReSharper restore InconsistentNaming
        {
            var suffixArrayLengths = new int[A.Length + 1, B.Length + 1];
            var max = 0;
            for (var j = B.Length - 1; j >= 0; j--)
            {
                for (var i = A.Length - 1; i >= 0; i--)
                {
                    if (A[i] != B[j])
                    {
                        suffixArrayLengths[i, j] = 0;
                    }
                    else
                    {
                        suffixArrayLengths[i, j] = suffixArrayLengths[i + 1, j + 1] + 1;
                        max = Math.Max(max, suffixArrayLengths[i, j]);
                    }
                }
            }

            return max;
        }
    }
}