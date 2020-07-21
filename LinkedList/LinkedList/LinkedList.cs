using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CLinkedList<T>
    {
        Node _head;
        Node _tail;
        class Node
        {
            public Node()
            {
                _nextNode = null;   
            }

            public Node(T data, ref Node head)
            {
                _data = data;
                head._nextNode = this;
                head = this;
                _nextNode = null;
            }
            T _data;
            Node _nextNode;
        }

        public CLinkedList()
        {
             _head = new Node();
            _tail = _head;
        }

        public void Add(T data)
        {
            new Node(data, ref _head);
        }

        public void Remove()
        {

        }

    }
}
