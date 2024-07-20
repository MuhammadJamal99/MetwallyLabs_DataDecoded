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
}
