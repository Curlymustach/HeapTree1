using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(6);
            for (int i = 1; i <= 6; i++)
            {
                tree.Insert(i);
            }
            tree.Print();
            tree.pop();
            Console.WriteLine( "\n" + tree.pop() + "\n");
            tree.Print();
            Console.ReadKey();
        }
    }
}
