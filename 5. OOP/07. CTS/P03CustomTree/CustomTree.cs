namespace P03CustomTree
{
    using System;

    public class CustomTree
    {
        public static void Main()
        {
            BinarySearchTree<int> tree =
            new BinarySearchTree<int>(7,
                new BinarySearchTree<int>(19,
                    new BinarySearchTree<int>(1),
                    new BinarySearchTree<int>(12),
                    new BinarySearchTree<int>(31)),
                new BinarySearchTree<int>(21),
                new BinarySearchTree<int>(14,
                    new BinarySearchTree<int>(23),
                    new BinarySearchTree<int>(6))
            );

            Console.WriteLine(tree);
        }
    }
}
