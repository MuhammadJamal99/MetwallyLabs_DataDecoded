using System.Text;

namespace DataDeCoded.DictionaryArrayBased;

public class DictionaryArrayBased<TKey, TValue> where TKey : class
{
    KeyValuePair[] _baseArray;
    int _initalSize;
    int _entriesCount;
    KeyValuePair _defaultPair;
    public DictionaryArrayBased()
    {
        _defaultPair = default(KeyValuePair);
        _initalSize = 3;
        _entriesCount = 0;
        _baseArray = new KeyValuePair[_initalSize];
    }
    public void Set(TKey key, TValue value)
    {
        
        KeyValuePair entry = Find(key);
        if(entry is not null && !entry.Equals(_defaultPair))
        {
            entry.Value = value;
            return;
        }

        ReSizeOrNot();
        KeyValuePair newKeyValue = new KeyValuePair(key, value);
        _baseArray[_entriesCount] = newKeyValue;
        _entriesCount = _entriesCount + 1;
    }
    public TValue Get(TKey key)
    {
        KeyValuePair entry = Find(key);
        if(entry is not null && !entry.Equals(_defaultPair))
        {
            return entry.Value;
        }
        return default(TValue);
    }
    public bool Remove(TKey key)
    {
        KeyValuePair entry = Find(key);
        for (int i = 0; i < _baseArray.Length; i++)
        {
            if (_baseArray[i] is not null && !_baseArray[i].Equals(_defaultPair)&& _baseArray[i].Key.Equals(key))
            {
                _baseArray[i] = _baseArray[_entriesCount - 1];
                _baseArray[_entriesCount - 1] = null;
                _entriesCount--;
                return true;
            }
        }
       
        return false;
    }
    public void ReSizeOrNot()
    {
        if (_entriesCount < _baseArray.Length - 1)
        {
            return;
        }
        int newSize = _baseArray.Length + _initalSize;
        //Console.WriteLine("");
        KeyValuePair[] newBaseArray = new KeyValuePair[newSize];
        Array.Copy(_baseArray, 0, newBaseArray, 0, _baseArray.Length);
        _baseArray = newBaseArray;
    }
    public int Size()
    {
        return _entriesCount;
    }
    public void Print()
    {
        StringBuilder result = new();
        result.Append("----------------------------------\n");
        result.Append(string.Format("Size {0}\n", Size()));
        result.Append("key : Value \n");
        for (int i = 0; i < _entriesCount; i++) 
        {
            result.Append(string.Format("{0} : {1} \n", _baseArray[i].Key, _baseArray[i].Value));
        }
        result.Append("\n----------------------------------\n");
        Console.WriteLine(result.ToString());
    }
    private ref KeyValuePair Find(TKey key)
    {
        for (int i = 0; i < _baseArray.Length; i++)
        {
            if (_baseArray[i] is not null && _baseArray[i].Key.Equals(key))
            {
                return ref _baseArray[i];
            }
        }
        return ref _defaultPair;
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
