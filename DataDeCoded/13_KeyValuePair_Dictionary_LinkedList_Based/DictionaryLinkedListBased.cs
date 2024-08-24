using DataDeCoded.SinglyLinkedList;
using System.Text;

namespace DataDeCoded.DictionaryLinkedListBased;

public class DictionaryLinkedListBased<TKey, TValue> where TKey : class
{
    SinglyLinkedList.LinkedList<KeyValuePair> _baseList;
    KeyValuePair _defaultPair;
    public DictionaryLinkedListBased()
    {
        _defaultPair = default(KeyValuePair);
        _baseList = new SinglyLinkedList.LinkedList<KeyValuePair>(false);
    }
    public void Set(TKey key, TValue value)
    {
        for (LinkedListIterator<KeyValuePair> itr = this._baseList.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            if (itr.Data() is not null && !itr.Data().Equals(_defaultPair) && itr.Data().Key.Equals(key))
            {
                itr.Data().Value = value;
                return;
            }
        }
        KeyValuePair newKeyValue = new KeyValuePair(key, value);
        _baseList.InsertLast(newKeyValue);
    }
    public TValue Get(TKey key)
    {
        for (LinkedListIterator<KeyValuePair> itr = this._baseList.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            if (itr.Data() is not null && !itr.Data().Equals(_defaultPair) && itr.Data().Key.Equals(key))
            {
                return itr.Data().Value;
            }
        }
        return default(TValue);
    }
    public bool Remove(TKey key)
    {
        for (LinkedListIterator<KeyValuePair> itr = this._baseList.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            if (itr.Data() is not null && !itr.Data().Equals(_defaultPair)&& itr.Data().Key.Equals(key))
            {
                return _baseList.DeleteNode(itr.Data());
            }
        }
        return false;
    }
    public int Size()
    {
        return _baseList.Length;
    }
    public void Print()
    {
        StringBuilder result = new();
        result.Append("----------------------------------\n");
        result.Append(string.Format("Size {0}\n", Size()));
        result.Append("key : Value \n");
        for (LinkedListIterator<KeyValuePair> itr = this._baseList.Begin(); itr.GetCurrent() is not null; itr.MoveNext())
        {
            result.Append(string.Format("{0} : {1} \n", itr.Data().Key, itr.Data().Value));
        }
        result.Append("\n----------------------------------\n");
        Console.WriteLine(result.ToString());
    }
    class KeyValuePair
    {
        private TKey _key;
        private TValue _value;
        public KeyValuePair(TKey key, TValue value)
        {
            _value = value;
            _key = key; 
        }
        public TKey Key
        {
            get { return _key; } 
        }
        public TValue Value 
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
