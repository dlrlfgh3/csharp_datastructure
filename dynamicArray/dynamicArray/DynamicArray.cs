using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicArray
{
    class DynamicArray<T>
    {
        const int _defaultArrayCount = 2;
        int _arrCount = 0;
        int _arrCapacity = _defaultArrayCount;
        T[] _arr = new T[_defaultArrayCount];

        public DynamicArray()
        {

        }

        public T this[int index]
        {
            get
            {
                return _arr[index];
            }

            set
            {
                if (index < 0 || index > _arr.Length - 1)
                {
                    throw new Exception();
                }
                _arr[index] = value;
            }
        }

        public void Add(T item)
        {
            _arrCount++;
            if (_arrCapacity < _arrCount)
            {
                _arrCapacity *= 2;
                T[] newArr = new T[_arrCapacity];
                Array.Copy(_arr, newArr, _arrCount - 1);
                _arr = newArr;
            }
            _arr[_arrCount - 1] = item;
        }

        public void remove(int index)
        {
            if (index < 0 || index > _arrCapacity)
                throw new Exception();

            for (int i = index; i < _arrCount - 1; i++)
            {
                _arr[index] = _arr[index + 1];
            }
            _arrCount--;
        }
    }
}
