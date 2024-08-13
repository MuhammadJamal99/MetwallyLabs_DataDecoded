using System.Text;

namespace DataDeCoded.StackArrayBased;
public class StackArrayBased<T>
{
    private T[] _baseArray;
    private int _topIndex;
    private int _initalSize;
    private bool? _isAllowDuplicates;
    public StackArrayBased(bool? isAllowDuplicates = false)
    {
        _topIndex = -1;
        _initalSize = 5;
        _baseArray = new T[_initalSize];
        _isAllowDuplicates = isAllowDuplicates;
    }

    public void ReSizeOrNot()
    {
        if (_topIndex < _baseArray.Length - 1)
        {
            return;
        }
        T[] newBaseArray = new T[_baseArray.Length + _initalSize];

        Buffer.BlockCopy(_baseArray, 0, newBaseArray, 0, _baseArray.Length * sizeof(int));
        _baseArray = newBaseArray;
    }
    public void Push(T data)
    {
        ReSizeOrNot();
        if (!IsEmpty() && (Array.IndexOf(_baseArray, data) >= 0) && !_isAllowDuplicates.Value)
        {
            Console.WriteLine("{0} Already Exists", data);
            return;
        }
        _baseArray[_topIndex + 1] = data;
        _topIndex++;
    }
    public T Pop()
    {
        if (IsEmpty())
        {
            return default;
        }
        T peekData = _baseArray[_topIndex];
        _baseArray[_topIndex] = default;
        _topIndex--;
        return peekData;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            return default;
        }
        return _baseArray[_topIndex];
    }
    public bool IsEmpty()
    {
        return _topIndex == -1;
    }
    public void Print()
    {
        StringBuilder result = new();
        for (int i = _topIndex; i >= 0; i--)
        {
            result.Append("|    ");
            result.Append(_baseArray[i]);
            result.Append("    |\n");
        }
        result.Append("\n___________\n");
        Console.WriteLine("   Stack \n{0} Size: {1} \n", result.ToString(), Size());
    }
    public int Size()
    {
        return _topIndex + 1;
    }
}
