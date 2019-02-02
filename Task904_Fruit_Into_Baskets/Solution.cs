using System;
using System.Collections.Generic;
using System.Linq;

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

            var fruitTypeCounts = new Dictionary<int, int>();
            var startTreeIndex = 0;
            var endTreeIndex = 0;

            var maxFruitCount = 0;

            while (endTreeIndex < tree.Length)
            {
                while (fruitTypeCounts.Keys.Count == basketCount)
                {
                    var fruitType = tree[startTreeIndex];

                    fruitTypeCounts[fruitType]--;
                    if (fruitTypeCounts[fruitType] == 0)
                    {
                        fruitTypeCounts.Remove(fruitType);
                    }

                    startTreeIndex++;
                }

                while (endTreeIndex < tree.Length)
                {
                    var fruitType = tree[endTreeIndex];
                    endTreeIndex++;
                    if (!fruitTypeCounts.ContainsKey(fruitType))
                    {
                        if (fruitTypeCounts.Keys.Count == basketCount)
                        {
                            break;
                        }

                        fruitTypeCounts[fruitType] = 0;
                    }

                    fruitTypeCounts[fruitType]++;
                }

                maxFruitCount = Math.Max(maxFruitCount, fruitTypeCounts.Values.Sum());
            }

            return maxFruitCount;
        }
    }
}