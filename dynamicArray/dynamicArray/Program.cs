using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicArray
{
    class Temp
    {
        int a = 0;

        public Temp(int a)
        {
            this.a = a;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<Temp> arr = new DynamicArray<Temp>();
            arr.Add(new Temp(0));
            arr.Add(new Temp(1));
            arr.Add(new Temp(2));
            arr.remove(2);
            arr.Add(new Temp(3));
            arr.Add(new Temp(4));

            arr.remove(2);
        }
    }
}
