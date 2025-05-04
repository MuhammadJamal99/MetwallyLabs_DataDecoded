namespace DataDeCoded.BinarySearchTree;

public class BinarySearchTreeNode<T>
{
    public T Data { get; set; }
    public BinarySearchTreeNode<T> Parent { get; set; }
    public BinarySearchTreeNode<T> Left { get; set; }
    public BinarySearchTreeNode<T> Right { get; set; }
    public BinarySearchTreeNode(T data)
    {
        Data = data;
    }
}
