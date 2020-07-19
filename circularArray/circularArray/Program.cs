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
            CircularArray arr = new CircularArray(10);

            // push
            arr.push_back();
            arr.push_back();
            arr.push_back();
            arr.push_back();
            arr.push_back();

            // pop
            arr.pop_front();
            arr.pop_front();
            arr.pop_front();
            arr.pop_front();

        }
    }
}
