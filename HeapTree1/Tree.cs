using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree1
{
    class Tree<T> where T : IComparable<T>
    {
        T[] tree;
        int index = 0;

        public Tree(int size)
        {
            tree = new T[size];
        }

        public int Left(int i)
        {
            return i * 2 + 1;
        }

        public int Right(int i)
        {
            return i * 2 + 2;
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public void Insert(T value)
        {
            if (index == tree.Length)
            {
                Console.WriteLine("Heap Full.");
            }
            else
            {
                tree[index] = value;
                HeapifyUp(index);
                index++;
            }
        }

        public void HeapifyUp(int i)
        {
            while (tree[i].CompareTo(tree[Parent(i)]) > 0)
            {
                T temp = tree[i];
                tree[i] = tree[Parent(i)];
                tree[Parent(i)] = temp;
                //i = ?
            }
        }

        public void Print()
        {
            for (int i = 0; i < tree.Length; i++)
            {
                Console.WriteLine(tree[i]);
            }
        }


    }
}
