namespace DataDeCoded.DoublyLinkedList;

public class DoublyLinkedListNode<T> : IEquatable<DoublyLinkedListNode<T>>
{
    public DoublyLinkedListNode(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
    public T Data { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }
    public DoublyLinkedListNode<T> Previous { get; set; }

    public static bool operator ==(DoublyLinkedListNode<T> first, DoublyLinkedListNode<T> second)
    {
        if (first is null && second is null)
        {
            return true;
        }

        if (first is null || second is null)
        {
            return false;
        }

        return first.Equals(second);
    }

    public static bool operator !=(DoublyLinkedListNode<T> first, DoublyLinkedListNode<T> second)
    {
        return !(first == second);
    }

    public bool Equals(DoublyLinkedListNode<T> other)
    {
        if (other is null || other.GetType() != GetType())
        {
            return false;
        }

        return other.Data.Equals(Data);
    }

    public override bool Equals(object obj)
    {
        // Check if the two have same type.
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        // Check If the obj if of type Entity.
        if (obj is not DoublyLinkedListNode<T> entity)
        {
            return false;
        }

        return entity.Data.Equals(Data);
    }
}