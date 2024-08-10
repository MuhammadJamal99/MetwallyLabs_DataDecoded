using System.Text;

namespace DataDeCoded.SinglyLinkedList;

public class LinkedList<T>
{
    public LinkedListNode<T> Head { get; set; } = null;
    public LinkedListNode<T> Tail { get; set; } = null;
    public bool IsAllowDuplicates { get; set; } = false;
    public int Length = 0;
    public LinkedList(bool? isAllowDuplicates)
    {
        Head = null;
        Tail = null;
        IsAllowDuplicates = isAllowDuplicates ?? false;
        Length = 0;
    }
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
        Console.WriteLine("List:{0} , Length: {1}", result.ToString(), Length);
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
    public bool IsExists(T data)
    {
        if (Find(data) is not null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool CanInsert(T data)
    {
        if (!IsAllowDuplicates && IsExists(data))
        {
            Console.WriteLine("Data {0} Already Exists", data);
            return false;
        }
        else
        {
            return true;
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
    public void InsertLast(T data)
    {
        if (!CanInsert(data))
        {
            return;
        }
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
        Length += 1;
    }
    public void InsertAfter(T nodeData, T data)
    {
        if (!CanInsert(data))
        {
            return;
        }
        LinkedListNode<T> node = Find(nodeData);

        LinkedListNode<T> newNode = new(data);

        if (IsTail(node))
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = node.Next;
            node.Next = newNode;

        }
        Length += 1;
    }
    public void InsertBefore(T nodeData, T data)
    {
        if (!CanInsert(data))
        {
            return;
        }
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
        Length += 1;
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
            Length -= 1;
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
                Length -= 1;
                return true;
            }
            else
            {
                parent.Next = node.Next;
                Length -= 1;
                return true;
            }
        }
    }
}
