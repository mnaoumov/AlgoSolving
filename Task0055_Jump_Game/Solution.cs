using System;

namespace AlgoSolving.Task0055_Jump_Game
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int maxJump = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxJump)
                {
                    return false;
                }

                maxJump = Math.Max(maxJump, i + nums[i]);
            }

            return true;
        }
    }
}