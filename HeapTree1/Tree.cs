﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapTree1
{
    class Tree<T> where T : IComparable<T>
    {
        T[] tree;
        int maxIndex = 0;

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

        public void Swap(int i, int j)
        {
            T temp = tree[i];
            tree[i] = tree[j];
            tree[j] = temp;
        }

        public void Insert(T value)
        {
            if (maxIndex == tree.Length)
            {
                Resize(tree.Length * 2);
            }
            else
            {  
                tree[maxIndex] = value;
                HeapifyUp(maxIndex);
                maxIndex++;
            }
        }

        public void HeapifyUp(int i)
        {
            if (i == 0 || tree[i].CompareTo(tree[Parent(i)]) < 0)
            {
                return;
            }

            Swap(i, Parent(i));
            HeapifyUp(Parent(i));
        }

        public T pop()
        {
            T value = tree[0];
            tree[0] = tree[maxIndex - 1];
            maxIndex--;
            HeapifyDown(0);
            Resize(maxIndex);
            return value;
        }

        public void HeapifyDown(int i)
        {
            int master = i;
            int left = Left(i);
            int right = Right(i);

            
            if(left <= maxIndex && tree[master].CompareTo(tree[left]) < 0)
            {
                master = left;
            }
            if(right <= maxIndex && tree[master].CompareTo(tree[right]) < 0)
            {
                master = right;
            }
            if(master == i)
            {
                return;
            }

            Swap(i, master);
            HeapifyDown(master);
        }

        public void Resize(int size)
        {
            T[] tempHeap = new T[size];
            for(int i = 0; i < maxIndex; i++)
            {
                tempHeap[i] = tree[i];
            }
            tree = tempHeap;
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
