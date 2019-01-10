using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0102_BinaryTree_Level_Order_Traversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            var currentLevelNodes = new List<TreeNode> {root};

            while (currentLevelNodes.Any())
            {
                var nextLevelNodes = new List<TreeNode>();
                var currentLevelValues = new List<int>();
                foreach (var currentLevelNode in currentLevelNodes)
                {
                    if (currentLevelNode != null)
                    {
                        nextLevelNodes.Add(currentLevelNode.left);
                        nextLevelNodes.Add(currentLevelNode.right);
                        currentLevelValues.Add(currentLevelNode.val);
                    }
                }

                if (currentLevelValues.Any())
                {
                    result.Add(currentLevelValues);
                }

                currentLevelNodes = nextLevelNodes;
            }

            return result;
        }
    }
}