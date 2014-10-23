namespace P03CustomTree
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        private T value;
        private bool hasParent;
        private List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Can't insert null value!");
            }

            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public int GetChildrenCount
        {
            get { return this.children.Count; }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Can't insert null!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The element already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode<T> GetChildByIndex(int index)
        {
            return this.children[index];
        }
    }
}
