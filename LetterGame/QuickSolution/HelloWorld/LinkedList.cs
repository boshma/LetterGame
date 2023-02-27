using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class LinkedListNode
    {
        internal int data;
        internal LinkedListNode next;

        public LinkedListNode(int userData)
        {
            if (userData > 0)
            {
                data = userData;
            }
            else
            {
                Console.WriteLine("Positive numbers only");
            }

            next = null;
        }
    }

    internal class LinkedList
    {
        internal LinkedListNode head;

        public void initializeLL()
        {
            LinkedListNode node1 = new LinkedListNode(12);
            LinkedListNode node2 = new LinkedListNode(14);
            LinkedListNode node3 = new LinkedListNode(3);
            LinkedListNode node4 = new LinkedListNode(4);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            head = node1;

        }

        internal void add(int one, int two)
        {
            int numbToAdd1 = 0;
            int numbToAdd2 = 0;

            if (one == 0)
            {
                numbToAdd1 = head.data;
            }
            else
            {
                LinkedListNode crawler = head;
                int count = 0;
                while (crawler != null && count <= one)
                {
                    if (count == one)
                    {
                        numbToAdd1 = crawler.data;
                        break;
                    }
                    else
                    {
                        crawler = crawler.next;
                        count++;
                    }
                }
            }

            if (two == 0)
            {
                numbToAdd2 = head.data;
            }
            else
            {
                LinkedListNode crawler = head;
                int count = 0;
                while (crawler != null && count <= two)
                {
                    if (count == two)
                    {
                        numbToAdd2 = crawler.data;
                        break;
                    }
                    else
                    {
                        crawler = crawler.next;
                        count++;
                    }
                }
            }


            Console.WriteLine($"The sum of the indices is {numbToAdd1 + numbToAdd2}");

        }
    }

   
}

