using DataDeCoded.SinglyLinkedList;
using System.Text;

namespace DataDeCoded.StackLinkedListbased;
public class StackLinkedListBased<T>
{
    private SinglyLinkedList.LinkedList<T> _baseList;
    public StackLinkedListBased(bool? isAllowDuplicates)
    {
        _baseList = new(isAllowDuplicates);
    }
    public void Push(T data)
    {
        _baseList.InsertFirst(data);
    }
    public T Pop()
    {
        if (IsEmpty())
        {
            return default;
        }
        T headData = _baseList.Head.Data;
        _baseList.DeleteHead();
        return headData;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            return default;
        }
        return _baseList.Head.Data;
    }
    public bool IsEmpty()
    {
        return _baseList.IsEmpty();
    }
    public void Print()
    {
        StringBuilder result = new();
        for (LinkedListIterator<T> itr = this._baseList.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            result.Append("|    ");
            result.Append(itr.Data());
            result.Append("    |\n");
        }
        result.Append("\n___________\n");
        Console.WriteLine("Stack: \n{0} Size: {1}", result.ToString(), _baseList.Length);
    }
    public int Size()
    {
        return _baseList.Length;
    }
}
