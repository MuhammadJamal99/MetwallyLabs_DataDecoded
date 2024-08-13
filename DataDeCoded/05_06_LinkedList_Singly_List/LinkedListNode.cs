namespace DataDeCoded.SinglyLinkedList;
public class LinkedListNode<T> : IEquatable<LinkedListNode<T>>
{
    public LinkedListNode(T data)
    {
        Data = data;
        Next = null;
    }
    public T Data { get; set; }
    public LinkedListNode<T> Next { get; set; }

    public static bool operator ==(LinkedListNode<T> first, LinkedListNode<T> second)
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

    public static bool operator !=(LinkedListNode<T> first, LinkedListNode<T> second)
    {
        return !(first == second);
    }

    public bool Equals(LinkedListNode<T> other)
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
        if (obj is not LinkedListNode<T> entity)
        {
            return false;
        }

        return entity.Data.Equals(Data);
    }
}
