using System;
using System.Collections.Generic;

namespace AlgoSolving.Task904_Fruit_Into_Baskets
{
    public class Solution
    {
        public int TotalFruit(int[] tree)
        {
            const int basketCount = 2;
            if (tree.Length <= basketCount)
            {
                return tree.Length;
            }

            var maxFruitCount = basketCount;

            for (int i = 0; i < tree.Length; i++)
            {
                var fruitCount = 0;
                var fruitTypes = new HashSet<int>();
                for (int j = i; j < tree.Length; j++)
                {
                    fruitTypes.Add(tree[j]);
                    if (fruitTypes.Count > basketCount)
                    {
                        break;
                    }

                    fruitCount++;
                }

                maxFruitCount = Math.Max(maxFruitCount, fruitCount);
            }

            return maxFruitCount;
        }
    }
}