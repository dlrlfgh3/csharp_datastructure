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

            public static void NextNode(ref Node node)
            {
                node = node._nextNode;
            }

            public T getData()
            {
                return _data;
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

        public T this[int index]
        {
            get
            {
                Node _indexNode = _tail;
                for(int i = 0; i < index;i++)
                {
                    Node.NextNode(ref _indexNode);
                }
                return _indexNode.getData();
            }
        }

    }
}
