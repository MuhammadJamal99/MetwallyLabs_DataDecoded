using DataDeCoded.QueueArrayBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDeCoded.BinaryTree;

public class BinaryTree<T> where T : IComparable<T>
{
    BinaryTreeNode<T> root;
    public bool IsEmpty()
    {
        return root is null;
    }
    public void Insert(T data)
    {
        BinaryTreeNode<T> newNode = new(data);
        if (IsEmpty())
        {
            root = newNode;
            return;
        }
        QueueArrayBased<BinaryTreeNode<T>> queue = new();
        queue.EnQueue(root);
        while (!queue.IsEmpty())
        {
            BinaryTreeNode<T> currentNode = queue.DeQueue();
            if (currentNode.Left is null)
            {
                currentNode.Left = newNode;
                break;
            }
            else 
            {
                queue.EnQueue(currentNode.Left);
            }
            if (currentNode.Right is null)
            {
                currentNode.Right = newNode;
                break;
            }
            else
            {
                queue.EnQueue(currentNode.Right);
            }
        }
    }

    public void PreOrderTraversal()
    {
        InternalPreOrderTraversal(root);
    }
    private void InternalPreOrderTraversal(BinaryTreeNode<T> node)
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
    private void InternalInOrderTraversal(BinaryTreeNode<T> node)
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
    private void InternalPostOrderTraversal(BinaryTreeNode<T> node)
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
    private int GetHieght(BinaryTreeNode<T> node)
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
        List<BinaryTreeNode<T>> level = new(){ root };
        int width = (int)Math.Pow(2, depth) * 3;

        while (level.Any(n => n != null))
        {
            List<BinaryTreeNode<T>> nextLevel = new();
            List<string> line = new();
            List<string> edges = new();

            foreach (BinaryTreeNode<T> node in level)
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
