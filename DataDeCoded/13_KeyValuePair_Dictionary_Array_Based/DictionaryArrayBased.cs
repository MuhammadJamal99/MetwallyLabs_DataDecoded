using System.Collections.Generic;

namespace DataDeCoded.DictionaryArrayBased;

public class DictionaryArrayBased<TKey, TValue> where TKey : class
{
    KeyValuePair[] _entries;
    int _initalSize;
    int _entriesCount;
    public DictionaryArrayBased()
    {
        _initalSize = 3;
        _entriesCount = 0;
        _entries = new KeyValuePair[_initalSize];
    }
    public void ReSizeOrNot()
    {
        if (_entriesCount < _entries.Length - 1)
        {
            return;
        }
        int newSize = _entries.Length + _initalSize;
        Console.WriteLine("");
        KeyValuePair[] newBaseArray = new KeyValuePair[newSize];
        Array.Copy(_entries, 0, newBaseArray, 0, _entries.Length);
        _entries = newBaseArray;
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
