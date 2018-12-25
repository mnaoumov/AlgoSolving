namespace AlgoSolving.Task237_Delete_Node_in_a_Linked_List
{
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            while (node.next.next != null)
            {
                node.val = node.next.val;
                node = node.next;
            }

            node.val = node.next.val;
            node.next = null;
        }
    }
}