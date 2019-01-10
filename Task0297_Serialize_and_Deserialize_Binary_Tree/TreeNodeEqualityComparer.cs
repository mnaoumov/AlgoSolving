using System.Collections.Generic;

namespace AlgoSolving.Task0297_Serialize_and_Deserialize_Binary_Tree
{
    internal class TreeNodeEqualityComparer : IEqualityComparer<TreeNode>
    {
        public bool Equals(TreeNode x, TreeNode y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
            {
                return false;
            }

            return x.val == y.val && Equals(x.left, y.left) && Equals(x.right, y.right);
        }

        public int GetHashCode(TreeNode obj)
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable HeuristicUnreachableCode
            if (ReferenceEquals(obj, null))
            {
                return 0;
            }
            // ReSharper restore HeuristicUnreachableCode

            return (obj.val, GetHashCode(obj.left), GetHashCode(obj.right)).GetHashCode();
        }
    }
}