using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class TT
    {
        public TT(int a)
        {
            this.a = a;
        }
        int a;
    }


    class Program
    {

        static void Main(string[] args)
        {
            CLinkedList<TT> t = new CLinkedList<TT>();
            t.Add(new TT(1));
            t.Add(new TT(2));
            t.Add(new TT(3));
            t.Add(new TT(4));
            t.Add(new TT(5));
            TT t1 = t[3];
            
        }
    }
}
