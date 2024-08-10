using System.Text;

namespace DataDeCoded.DoublyLinkedList;

public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> Head { get; set; } = null;
    public DoublyLinkedListNode<T> Tail { get; set; } = null;
    public bool IsAllowDuplicates { get; set; } = false;

    public int Length = 0;
    public DoublyLinkedList(bool? isAllowDuplicates)
    {
        Head = null;
        Tail = null;
        Length = 0;
        IsAllowDuplicates = isAllowDuplicates ?? false;
    }
    public DoublyLinkedListIterator<T> Begin()
    {
        DoublyLinkedListIterator<T> itr = new(this.Head);
        return itr;
    }
    public void Print()
    {
        StringBuilder result = new();
        for (DoublyLinkedListIterator<T> itr = this.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
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
    public bool IsTail(DoublyLinkedListNode<T> node)
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
    public bool IsHead(DoublyLinkedListNode<T> node)
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
    public DoublyLinkedListNode<T> Find(T data)
    {
        if (data is null || IsEmpty())
        {
            return null;
        }
        else
        {
            for (DoublyLinkedListIterator<T> itr = this.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
            {
                if (itr.Data().Equals(data))
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
        DoublyLinkedListNode<T> newNode = new(data);
        if (IsEmpty())
        {
            Head = newNode;
            Tail = newNode;
            newNode.Previous = null;
            newNode.Next = null;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
            newNode.Next = null;

        }
        Length += 1;
    }
    public void InsertAfter(T nodeData, T data)
    {
        if (!CanInsert(data))
        {
            return;
        }
        DoublyLinkedListNode<T> node = Find(nodeData),
                                newNode = new(data);

        if (node is null)
        {
            return;
        }
        else if (IsTail(node))
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
        else
        {
            newNode.Next = node.Next;
            newNode.Previous = node;
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
        DoublyLinkedListNode<T> node = Find(nodeData),
                                newNode = new(data);

        if (node is null)
        {
            return;
        }
        else if (IsHead(node))
        {
            newNode.Next = Head;
            Head = newNode;
            newNode.Previous = null;
        }
        else
        {
            newNode.Next = node;
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
        }
        Length += 1;
    }
    public void InsertFirst(T data)
    {
        if (!CanInsert(data))
        {
            return;
        }
        DoublyLinkedListNode<T> newNode = new(data);
        if (IsEmpty())
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
        Length += 1;
    }
    public bool DeleteNode(T data)
    {
        DoublyLinkedListNode<T> node = Find(data);
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
            node.Next.Previous = null;
            Length -= 1;
            return true;
        }
        else
        {
            DoublyLinkedListNode<T> previous = node.Previous;
            if (IsTail(node))
            {
                Tail = previous;
                previous.Next = null;
                Length -= 1;
                return true;
            }
            else
            {
                previous.Next = node.Next;
                node.Next.Previous = node.Previous;
                Length -= 1;
                return true;
            }
        }
    }

    public void DeleteHead()
    {
        if (IsEmpty())
        {
            return;
        }
        else
        {
            Head = Head.Next;
        }
        Length -= 1;
    }

    public DoublyLinkedList<T> CopyTo(DoublyLinkedList<T> newList)
    {
        DoublyLinkedListIterator<T> itr = Begin();
        if (!IsEmpty())
        {
            do
            {
                newList.InsertLast(itr.Data());
                itr.MoveNext();
            } while (itr.CanMoveNext());

            newList.InsertLast(itr.Data());
        }
        return newList;
    }
}