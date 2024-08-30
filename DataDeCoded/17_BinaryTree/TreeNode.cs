using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDeCoded.BinaryTree;

public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public TreeNode<T> Left { get; set; }
    public TreeNode<T> Right { get; set; }
    public TreeNode(T data)
    {
        Data = data;
    }
}
