using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class LinkedList : IEnumerable<int>
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }


        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public bool Includes(int value)
        {
            bool foundValue = false;
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    foundValue = true;
                }
                currentNode = currentNode.Next;
            }
            return foundValue;
        }

        public string ToString()
        {
            string listString = "";
            Node currentNode = Head;
            while (currentNode != null)
            {
                listString += currentNode.Value + " -> ";
                currentNode = currentNode.Next;
            }
            listString += "NULL";
            return listString;
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
