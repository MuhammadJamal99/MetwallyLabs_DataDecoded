using System.Text;

namespace DataDeCoded.HashTable;

public class HashTable<TKey, TValue> where TKey : class
{
    KeyValuePair[] _baseArray;
    int _initalSize;
    int _entriesCount;
    KeyValuePair _defaultPair;
    public HashTable()
    {
        _defaultPair = default(KeyValuePair);
        _initalSize = 3;
        _entriesCount = 0;
        _baseArray = new KeyValuePair[_initalSize];
    }
    public void Set(TKey key, TValue value)
    {
        ReSizeOrNot();
        Add(key, value);
    }
    public TValue Get(TKey key)
    {
        int hash = GetHash32(key);
        if (_baseArray[hash] is not null && !_baseArray[hash].Key.Equals(key))
        {
            hash = LinearProprobingCollisionHandling(key, hash, false);
        }
        if (hash == -1 || _baseArray[hash] is null)
        {
            return default(TValue);
        }
        if (_baseArray[hash].Key.Equals(key))
        {
            return _baseArray[hash].Value;
        }
        else
        {
            throw new Exception("Invalid HashTable!!!");
        }
    }
    int GetHash32(TKey key)
    {
        uint offsetBasis = 2166136261;
        uint fnvPrime = 16777619;
        byte[] data = Encoding.ASCII.GetBytes(key.ToString());
        uint hash = offsetBasis;
        foreach (byte dataByte in data)
        {
            hash = hash ^ dataByte;
            hash = hash * fnvPrime;
        }
        Console.WriteLine("[Hash] {0} {1} ", key.ToString(), hash);
        return (int)(hash % (uint)_baseArray.Length);
    }
    int LinearProprobingCollisionHandling(TKey key, int hash, bool isSet)
    {
        int newHash;
        for (int i = 1; i < _baseArray.Length; i++) 
        {
            newHash = (hash + i) % _baseArray.Length;
            Console.WriteLine("[Coll] {0} {1}, New Hashed Value: {1}", key.ToString(), hash, newHash);
            if (isSet && (_baseArray[newHash] is null || _baseArray[newHash].Key.Equals(key))) 
            {
                return newHash;
            }
            else if(!isSet && _baseArray[newHash].Key.Equals(key))
            {
                return newHash;
            }
        }
        return -1;
    }
    public void Add(TKey key, TValue value) 
    {
        int hash = GetHash32(key);
        if (_baseArray[hash] is not null && !_baseArray[hash].Key.Equals(key))
        {
            hash = LinearProprobingCollisionHandling(key, hash, true);
        }
        if(hash == -1)
        {
            throw new Exception("Invalid HashTable!!!");
        }
        if (_baseArray[hash] is null) 
        {
            KeyValuePair newEntry = new KeyValuePair(key, value);
            _baseArray[hash] = newEntry;
            _entriesCount++;
        }
        else if (_baseArray[hash].Key.Equals(key))
        {
            _baseArray[hash].Value = value;
        }
        else
        {
            throw new Exception("Invalid HashTable!!!");
        }
    }
    public void ReSizeOrNot()
    {
        if (_entriesCount < _baseArray.Length - 1)
        {
            return;
        }
        int newSize = _baseArray.Length * 2;
        Console.WriteLine("[Resize] From {0} To {1}", _baseArray.Length, newSize);
        KeyValuePair[] baseArrayCopy = new KeyValuePair[_baseArray.Length];
        Array.Copy(_baseArray, 0, baseArrayCopy, 0, baseArrayCopy.Length);
        _baseArray = new KeyValuePair[newSize];
        _entriesCount = 0;
        foreach (KeyValuePair? item in baseArrayCopy) 
        {
            if (item is null)
            {
                continue;
            }
            else
            {
                Add(item.Key, item.Value);
            }
        }
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
        for (int i = 0; i < _baseArray.Length; i++)
        {
            if (_baseArray[i] is null) 
            {
                continue;
            }
            result.Append(string.Format("{0} : {1} \n", _baseArray[i].Key, _baseArray[i].Value));
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
