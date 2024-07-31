namespace DataDeCoded.DoublyLinkedList;

public class DoublyLinkedListIterator<T>
{
    private DoublyLinkedListNode<T> _currentNode;
    public DoublyLinkedListIterator()
    {
        _currentNode = null;
    }
    public DoublyLinkedListIterator(DoublyLinkedListNode<T> currentNode)
    {
        _currentNode = currentNode;
    }
    public T Data()
    {
        return _currentNode.Data;
    }

    public DoublyLinkedListIterator<T> MoveNext()
    {
        _currentNode = _currentNode.Next;
        return this;
    }
    public bool CanMoveNext()
    {
        return _currentNode.Next is not null;
    }
    public DoublyLinkedListNode<T> GetCurrent()
    {
        return _currentNode;
    }
}