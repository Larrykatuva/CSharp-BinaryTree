using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree =
                new BinaryTree<int>(14,
                    new BinaryTree<int>(19,
                        new BinaryTree<int>(23),
                        new BinaryTree<int>(6,
                            new BinaryTree<int>(10),
                     new BinaryTree<int>(21))),
                     new BinaryTree<int>(15,
                new BinaryTree<int>(3),
             null));

            binaryTree.PrintInOrder();
            Console.WriteLine();

        }
    }
}
