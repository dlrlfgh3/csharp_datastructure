using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circularArray
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularArray<int> arr = new CircularArray<int>(10);

            // push
            arr.push_back(1);
            arr.push_back(2);
            arr.push_back(3);
            arr.push_back(4);
            arr.push_back(5);
            arr.push_back(6);
            arr.push_back(7);
            arr.push_back(8);
            arr.push_back(9);
            arr.push_back(10);
            arr.push_back(11);

            // pop
            int tmp = 0;
            arr.pop_front(ref tmp);
            arr.pop_front(ref tmp);
            arr.pop_front(ref tmp);
            arr.pop_front(ref tmp);
            arr.pop_front(ref tmp);
            arr.pop_front(ref tmp);
        }
    }
}
