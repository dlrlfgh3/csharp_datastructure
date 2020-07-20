using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circularArray
{
    class CircularArray<T>
    {
        public int _capacity;
        public int _count;
        private T[] _arr;
        private int _rear;
        private int _front;
        private int _realCapacity;

        public CircularArray(int capacity)
        {
            if (capacity <= 0)
            {
                throw new Exception();
            }
            _capacity = capacity;
            _realCapacity = _capacity + 1;
            _count = 0;
            _rear = 0;
            _front = 0;
            _arr = new T[_realCapacity];
        }

        public bool push_back(T item)
        {
            if ((_rear + 1) % _realCapacity == _front)
            {
                return false;
            }
            _arr[_rear] = item;
            _rear = (_rear + 1) % _realCapacity;
            _count++;
            return true;
        }

        public bool pop_front(ref T item)
        {
            if(_rear == _front)
            {
                return false;
            }
            item = _arr[_front];
            _front = (_front + 1) % _realCapacity;
            _count--;
            return true;
        }

        public bool peek(ref T item)
        {
            if (_rear == _front)
            {
                return false;
            }
            item = _arr[_front];
            return true;
        }
    }
}
