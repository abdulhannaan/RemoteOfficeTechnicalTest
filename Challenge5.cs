using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RemoteOfficeTechnicalTest.Program;

namespace RemoteOfficeTechnicalTest
{
    public static class Challenge5
    {
        //Write a C# method that accepts the head of a linked list as input and returns the head of the
        //linked list in reverse order.For example, if the linked list is 1 -> 2 -> 3 -> 4 -> null, the method
        //should return 4 -> 3 -> 2 -> 1 -> null
        public static void CallerMethod()
        {
            ListNode node1 = new ListNode(4);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(2);
            ListNode node4 = new ListNode(1);

            node1.nextNode = node2;
            node2.nextNode = node3;
            node3.nextNode = node4;
            node4.nextNode = null;

            ListNode head = ReverseLinkedList(node1);
            PrintList(head);
        }

       
        public class ListNode
        {
            public int value { get; set; }
            public ListNode nextNode { get; set; }

            public ListNode(int value)
            {
                this.value = value;
            }
        }

        public static ListNode ReverseLinkedList(ListNode currentNode)
        {
            //setting up basecases that if current or next node is null return the node which is sent to this 
            if (currentNode == null || currentNode.nextNode == null)
                return currentNode;

            //recursive method calling thiss function again and again until currentNode.nextNode == null;
            ListNode head = ReverseLinkedList(currentNode.nextNode);
            //setting up the pointer to the current node to the previous
            currentNode.nextNode.nextNode = currentNode;
            //setting next ponter of current node is null so that it wont call towards each other like to break orignal link
            currentNode.nextNode = null;

            return head;
        }

        public static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.nextNode;
            }
        }
    }
}
