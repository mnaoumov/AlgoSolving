using System.Collections.Generic;

namespace AlgoSolving.Task0341_Flatten_Nested_List_Iterator
{
    public class NestedIntegerImpl : NestedInteger
    {
        private readonly IList<NestedInteger> _list;
        private readonly int _integer;

        public NestedIntegerImpl(int integer)
        {
            _integer = integer;
        }

        public NestedIntegerImpl(IList<NestedInteger> list)
        {
            _list = list;
        }

        public bool IsInteger()
        {
            return _list == null;
        }

        public int GetInteger()
        {
            return IsInteger() ? _integer : 0;
        }

        public IList<NestedInteger> GetList()
        {
            return !IsInteger() ? _list : null;
        }
    }
}