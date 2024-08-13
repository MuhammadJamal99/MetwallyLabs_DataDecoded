namespace DataDeCoded.SinglyLinkedList;

public class LinkedListIterator<T>
{
    private LinkedListNode<T> _currentNode;
    public LinkedListIterator()
    {
        _currentNode = null;
    }
    public LinkedListIterator(LinkedListNode<T> currentNode)
    {
        _currentNode = currentNode;
    }
    public T Data()
    {
        return _currentNode.Data;
    }

    public LinkedListIterator<T> MoveNext()
    {
        _currentNode = _currentNode.Next;
        return this;
    }
    public bool CanMoveNext()
    {
        return _currentNode.Next is not null;
    }
    public LinkedListNode<T> GetCurrent()
    {
        return _currentNode;
    }
}