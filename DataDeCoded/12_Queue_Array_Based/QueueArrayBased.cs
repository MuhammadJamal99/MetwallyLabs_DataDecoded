using System.Text;

namespace DataDeCoded.QueueArrayBased;
public class QueueArrayBased<T>
{
    private T[] _baseArray;
    private int _topIndex;
    private int _lastIndex;
    private int _initalSize;
    private bool? _isAllowDuplicates;
    public QueueArrayBased(bool? isAllowDuplicates = false)
    {
        _topIndex = -1;
        _lastIndex = 0;
        _initalSize = 5;
        _baseArray = new T[_initalSize];
        _isAllowDuplicates = isAllowDuplicates;
    }

    public void ReSizeOrNot()
    {
        if (_lastIndex == _baseArray.Length - 1)
        {
            T[] newBaseArray = new T[_baseArray.Length + _initalSize];

            Array.Copy(_baseArray, 0, newBaseArray, 0, _baseArray.Length);
            _baseArray = newBaseArray;
        }
    }
    public void EnQueue(T data)
    {
        ReSizeOrNot();
        if (!IsEmpty() && (Array.IndexOf(_baseArray, data) >= 0) && !_isAllowDuplicates.Value)
        {
            Console.WriteLine("{0} Already Exists", data);
            return;
        }
        if (IsEmpty())
        {
            _topIndex++;
        }
        _baseArray[_lastIndex] = data;
        _lastIndex++;
    }
    public T DeQueue()
    {
        if (IsEmpty())
        {
            return default;
        }
        T peekData = _baseArray[_topIndex];
        _baseArray[_topIndex] = default;
        _topIndex++;
        return peekData;
    }
    public T Top()
    {
        if (IsEmpty())
        {
            return default;
        }
        return _baseArray[_topIndex];
    }
    public bool IsEmpty()
    {
        return _lastIndex == 0;
    }
    public void Print()
    {
        StringBuilder result = new();
        result.Append("----------------------------------\n");
        for (int i = _topIndex; i <= _lastIndex - 1; i++)
        {
            result.Append(string.Format(" {0} ", _baseArray[i]));
        }
        result.Append("\n----------------------------------\n");
        Console.WriteLine("   Queue \n{0} Size: {1} \n", result.ToString(), Size());
    }
    public int Size()
    {
        return _lastIndex - _topIndex;
    }
}
