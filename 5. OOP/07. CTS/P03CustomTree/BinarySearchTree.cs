namespace P03CustomTree
{
    using System;

    public class BinarySearchTree<T>
    {
        private TreeNode<T> root;

        public BinarySearchTree(T value)
        {
            this.root = new TreeNode<T>(value);
        }

        public BinarySearchTree(T value, params BinarySearchTree<T>[] children)
        {
            foreach (BinarySearchTree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root
        {
            get { return this.root; }
        }
    }
}
