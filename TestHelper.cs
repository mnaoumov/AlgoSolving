using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace AlgoSolving
{
    internal static class TestHelper
    {
        public static CollectionItemsEqualConstraint IsEquivalentTo<T>(IList<IList<T>> listOfLists)
        {
            return Is.EquivalentTo(listOfLists).Using<IList<T>>((list1, list2) => list1.Count == list2.Count && !list1.Except(list2).Any());
        }
    }
}