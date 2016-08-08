using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWindowFormAppliacaion
{
    public class genList<var>
    {
        private class Node
        {
            public Node next;
            public int partNo;
            public string name;
            public double price;
        }
        
        private Node head = null;
        

        private void Add(int partNo, string name, double price)
        {
            Node newNode = new Node();
            newNode.next = head;

            newNode.partNo = partNo;
            newNode.name = name;
            newNode.price = price;

            head = newNode;
        }

    }
    
}





















