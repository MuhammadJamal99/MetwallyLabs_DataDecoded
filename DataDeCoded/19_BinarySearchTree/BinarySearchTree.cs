namespace DataDeCoded.BinarySearchTree;

public class BinarySearchTree<T> where T : IComparable<T>
{
    BinarySearchTreeNode<T> root;
    public bool IsEmpty()
    {
        return root is null;
    }
    public void Insert(T data)
    {
        BinarySearchTreeNode<T> newNode = new(data);
        if (IsEmpty())
        {
            newNode.Right = null;
            newNode.Left = null;
            newNode.Parent = null;
            root = newNode;
            return;
        }
        BinarySearchTreeNode<T> currentNode = this.root;
        while (currentNode is not null)
        {
            if (currentNode.Data.CompareTo(data) > 0)
            {
                if (currentNode.Left is null)
                {
                    newNode.Parent = currentNode;
                    currentNode.Left = newNode;
                    break;
                }
                else
                {
                    currentNode = currentNode.Left;
                }
            }
            else
            {
                if (currentNode.Right is null)
                {
                    newNode.Parent = currentNode;
                    currentNode.Right = newNode;
                    break;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }
        }
    }
    public bool IsExists(T data) 
    {
        return Find(data) is not null;
    }
    private BinarySearchTreeNode<T> Find(T data) 
    {
        BinarySearchTreeNode<T> currentNode = this.root;
        while (currentNode is not null) 
        {
            if (currentNode.Data.CompareTo(data) == 0)
            {
                return currentNode;
            }
            else if (currentNode.Data.CompareTo(data) > 0)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }
        return null;
    }
    public void PreOrderTraversal()
    {
        InternalPreOrderTraversal(root);
    }
    private void InternalPreOrderTraversal(BinarySearchTreeNode<T> node)
    {
        if(node is null)
        {
            return;
        }
        Console.Write(node.Data + " -> ");
        InternalPreOrderTraversal(node.Left);
        InternalPreOrderTraversal(node.Right);
    }
    public void InOrderTraversal()
    {
        InternalInOrderTraversal(root);
    }
    private void InternalInOrderTraversal(BinarySearchTreeNode<T> node)
    {
        if (node is null)
        {
            return;
        }
        InternalPreOrderTraversal(node.Left);
        Console.Write(node.Data + " -> ");
        InternalPreOrderTraversal(node.Right);
    }
    public void PostOrderTraversal()
    {
        InternalPostOrderTraversal(root);
    }
    private void InternalPostOrderTraversal(BinarySearchTreeNode<T> node)
    {
        if (node is null)
        {
            return;
        }
        InternalPreOrderTraversal(node.Left);
        InternalPreOrderTraversal(node.Right);
        Console.Write(node.Data + " -> ");
    }
    public int Hieght()
    {
        return GetHieght(root);
    }
    private int GetHieght(BinarySearchTreeNode<T> node)
    {
        if (node == null)
            return 0;
        return 1 + Math.Max(GetHieght(node.Left), GetHieght(node.Right));
    }
    public void Print()
    {
        if (root == null)
            return;

        int depth = GetHieght(root);
        List<List<string>> lines = new();
        List<BinarySearchTreeNode<T>> level = new(){ root };
        int width = (int)Math.Pow(2, depth) * 3;

        while (level.Any(n => n != null))
        {
            List<BinarySearchTreeNode<T>> nextLevel = new();
            List<string> line = new();
            List<string> edges = new();

            foreach (BinarySearchTreeNode<T> node in level)
            {
                if (node is null)
                {
                    line.Add(new string(' ', width));
                    edges.Add(new string(' ', width));
                    nextLevel.Add(null);
                    nextLevel.Add(null);
                }
                else
                {
                    string value = node.Data.ToString();
                    int padding = (width - value.Length) / 2;
                    line.Add(new string(' ', padding) + value + new string(' ', padding));

                    if (node.Left is not null)
                    {
                        edges.Add(new string(' ', padding - 1) + "/" + new string(' ', padding));
                    }
                    else
                    {
                        edges.Add(new string(' ', padding));
                    }

                    if (node.Right != null)
                    {
                        edges[edges.Count - 1] = edges[edges.Count - 1] + "\\";
                    }

                    nextLevel.Add(node.Left);
                    nextLevel.Add(node.Right);
                }
            }

            lines.Add(line);
            lines.Add(edges);
            width /= 2;
            level = nextLevel;
        }
        foreach (var line in lines)
        {
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
