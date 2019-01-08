using System.Collections.Generic;

namespace AlgoSolving.Task297_Serialize_and_Deserialize_Binary_Tree
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
            if (ReferenceEquals(obj, null))
            {
                return 0;
            }

            return (obj.val, GetHashCode(obj.left), GetHashCode(obj.right)).GetHashCode();
        }
    }
}