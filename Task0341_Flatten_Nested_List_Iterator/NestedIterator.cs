﻿using System;
using System.Collections.Generic;

namespace AlgoSolving.Task0341_Flatten_Nested_List_Iterator
{
    public class NestedIterator
    {
        private readonly IList<NestedInteger> _nestedList;
        private int _index;
        private NestedIterator _innerIterator;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            _nestedList = nestedList;
            _index = 0;
        }

        public bool HasNext()
        {
            while (true)
            {
                if (_innerIterator != null && _innerIterator.HasNext())
                {
                    return true;
                }

                _innerIterator = null;

                if (_index == _nestedList.Count)
                {
                    return false;
                }

                NestedInteger nestedInteger = _nestedList[_index];
                if (nestedInteger.IsInteger())
                {
                    return true;
                }

                _innerIterator = new NestedIterator(nestedInteger.GetList());
                _index++;
            }
        }

        public int Next()
        {
            while (true)
            {
                if (_innerIterator != null && _innerIterator.HasNext())
                {
                    return _innerIterator.Next();
                }

                _innerIterator = null;

                if (_index == _nestedList.Count)
                {
                    throw new InvalidOperationException();
                }

                NestedInteger nestedInteger = _nestedList[_index];
                _index++;
                if (nestedInteger.IsInteger())
                {
                    return nestedInteger.GetInteger();
                }

                _innerIterator = new NestedIterator(nestedInteger.GetList());
            }
        }
    }
}