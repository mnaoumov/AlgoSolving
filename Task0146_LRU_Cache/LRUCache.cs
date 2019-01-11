﻿using System.Collections.Generic;

namespace AlgoSolving.Task0146_LRU_Cache
{
    public class LRUCache
    {
        private readonly int _capacity;
        private readonly Dictionary<int, int> _dictionary;
        private readonly LinkedList<int> _list;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _dictionary = new Dictionary<int, int>(capacity);
            _list = new LinkedList<int>();
        }

        public int Get(int key)
        {
            const int notFound = -1;

            if (_dictionary.ContainsKey(key))
            {
                _list.Remove(key);
                _list.AddLast(key);
                return _dictionary[key];
            }

            return notFound;
        }

        public void Put(int key, int value)
        {
            if (!_dictionary.ContainsKey(key) && _dictionary.Keys.Count == _capacity)
            {
                var leastUsedKey = _list.First.Value;
                _dictionary.Remove(leastUsedKey);
            }

            _dictionary[key] = value;
            _list.AddLast(key);
        }
    }
}