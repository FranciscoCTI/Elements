namespace Elements.Search
{
    /// <summary>
    /// A generic binary tree node.
    /// </summary>
    /// <typeparam name="T">The type of the data referenced by the node.</typeparam>
    internal class BinaryTreeNode<T>
    {
        /// <summary>
        /// The left child.
        /// </summary>
        public BinaryTreeNode<T> Left { get; set; }

        /// <summary>
        /// The right child.
        /// </summary>
        public BinaryTreeNode<T> Right { get; set; }

        /// <summary>
        /// The parent.
        /// </summary>
        public BinaryTreeNode<T> Parent { get; set; }

        /// <summary>
        /// The data to store.
        /// </summary>
        public T Data { get; set; }
    }
}