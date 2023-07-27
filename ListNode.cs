namespace Leetcodes
{
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public class Solution
        {
            public readonly int val;
            public Solution(int val)
            {
                this.val = val;
            }
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {

                //ListNode listNode = new ListNode();
                //if (list1.val <= list2.val) { listNode = list1; list1 = list1.next; }
                //else { listNode = list2; list2 = list2.next; }

                //while (list1 != null && list2!=null) { 
                //    if(list1.val<=list2.val && list1!=null) {
                //        new Solution(1);
                //        listNode=list1.next;
                //        list1=list1.next;
                //    }
                //    else if (list1.val > list2.val && list2 != null)
                //    {
                //        new Solution(2);
                //        list2 = listNode.next;
                //        listNode=list1.next;
                //    }
                //}
                //if (val == 1)
                //    return list1;
                //else return list2;
                return list1;
            }
        }
    }
}
