using System.Text;

namespace DataDeCoded.SinglyLinkedList;

public class LinkedList<T>
{
    public LinkedListNode<T> Head { get; set; } = null;
    public LinkedListNode<T> Tail { get; set; } = null;
    public LinkedListIterator<T> Begin()
    {
        LinkedListIterator<T> itr = new(this.Head);
        return itr;
    }
    public void Print()
    {
        StringBuilder result = new();
        for (LinkedListIterator<T> itr = this.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            result.Append(itr.Data());
            result.Append(" -> ");
        }
        result.Append("\n");
        Console.WriteLine(result.ToString());
    }
    public bool IsEmpty()
    {
        return Head == null;
    }
    public bool IsTail(LinkedListNode<T> node)
    {
        if (Tail == node)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsHead(LinkedListNode<T> node)
    {
        if (Head == node)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void InsertLast(T data)
    {
        LinkedListNode<T> newNode = new(data);
        if (IsEmpty())
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
    }
    public LinkedListNode<T> Find(T data)
    {
        if (data is null || IsEmpty())
        {
            return null;
        }
        else
        {
            for (LinkedListIterator<T> itr = this.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
            {
                if (itr.Data().Equals(data))
                    return itr.GetCurrent();
            }
            return null;
        }
    }
    public LinkedListNode<T> FindParent(T data)
    {
        if (data is null || IsEmpty())
        {
            return null;
        }
        else
        {
            for (LinkedListIterator<T> itr = this.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
            {
                if (itr.GetCurrent().Next is not null && itr.GetCurrent().Next.Data.Equals(data))
                    return itr.GetCurrent();
            }
            return null;
        }
    }
    public void InsertAfter(T nodeData, T data)
    {
        LinkedListNode<T> node = Find(nodeData);

        LinkedListNode<T> newNode = new(data);

        if (IsTail(node))
        {
            Tail = newNode;
        }
        else
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }
    }
    public void InsertBefore(T nodeData, T data)
    {
        LinkedListNode<T> node = Find(nodeData),
                          nodeParent = FindParent(nodeData),
                          newNode = new(data);

        if (node is null)
        {
            return;
        }
        if (IsHead(node) || nodeParent is null)
        {
            newNode.Next = Head;
            Head = newNode;
        }
        else
        {
            nodeParent.Next = newNode;
            newNode.Next = node;
        }
    }
    public bool DeleteNode(T data)
    {
        LinkedListNode<T> node = Find(data);
        if (node is null)
        {
            return false;
        }
        else if (IsTail(node) && IsHead(node))
        {
            Head = Tail = null;
            return true;
        }
        else if (IsHead(node))
        {
            Head = node.Next;
            return true;
        }
        else
        {
            LinkedListNode<T> parent = FindParent(data);
            if (IsTail(node))
            {
                parent.Next = null;
                Tail = parent;
                return true;
            }
            else
            {
                parent.Next = node.Next;
                return true;
            }
        }
    }
}
