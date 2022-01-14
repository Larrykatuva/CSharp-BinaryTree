using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T>
    {
        private T value;
        public BinaryTree<T> LeftChild { get; private set; }

        public BinaryTree<T> RightChild { get; private set; }

        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public BinaryTree (T value): this(value, null, null)
        {

        }

        public void PrintInOrder()
        {
            if(this.LeftChild != null)
            {
                this.LeftChild.PrintInOrder();
            }
            Console.Write(this.value + " ");
            if(this.RightChild != null)
            {
                this.RightChild.PrintInOrder();
            }
        }
    }
}
