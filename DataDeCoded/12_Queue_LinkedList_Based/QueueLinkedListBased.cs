using DataDeCoded.SinglyLinkedList;
using System.Text;

namespace DataDeCoded.QueueLinkedListBased;
public class QueueLinkedListBased<T>
{
    private SinglyLinkedList.LinkedList<T> _baseList;
    public QueueLinkedListBased(bool? isAllowDuplicates)
    {
        _baseList = new(isAllowDuplicates);
    }

    public void EnQueue(T data)
    {
        _baseList.InsertLast(data);
    }
    public T DeQueue()
    {
        if (IsEmpty())
        {
            return default;
        }
        T headData = _baseList.Head.Data;
        _baseList.DeleteHead();
        return headData;
    }
    public T Top()
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
        result.Append("\n       ----------------------------------      \n      ");
        for (LinkedListIterator<T> itr = this._baseList.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            result.Append(string.Format(" {0} ", itr.Data()));
        }
        result.Append("     \n       ----------------------------------      \n");
        Console.WriteLine("         Queue \n{0}       Size: {1} \n", result.ToString(), _baseList.Length);
    }
    public int Size()
    {
        return _baseList.Length;
    }
}
