using System.Collections.Generic;
using NUnit.Framework;

namespace AlgoSolving.Task0341_Flatten_Nested_List_Iterator
{
    public class Tests
    {
        [Test]
        public void AcceptanceTest1()
        {
            Assert.That(FlattenList(new NestedInteger[]
            {
                new NestedIntegerImpl(new NestedInteger[] { new NestedIntegerImpl(1), new NestedIntegerImpl(1) }),
                new NestedIntegerImpl(2),
                new NestedIntegerImpl(new NestedInteger[] { new NestedIntegerImpl(1), new NestedIntegerImpl(1) })
            }), Is.EqualTo(new[] { 1, 1, 2, 1, 1 }));
        }

        [Test]
        public void AcceptanceTest2()
        {
            Assert.That(FlattenList(new NestedInteger[]
            {
                new NestedIntegerImpl(new NestedInteger[]
                {
                    new NestedIntegerImpl(1),
                    new NestedIntegerImpl(new NestedInteger[]
                    {
                        new NestedIntegerImpl(4),
                        new NestedIntegerImpl(new NestedInteger[]
                        {
                            new NestedIntegerImpl(6)
                        })
                    })
                })
            }), Is.EqualTo(new[] { 1, 4, 6 }));
        }

        [Test]
        public void Empty_list()
        {
            Assert.That(FlattenList(new NestedInteger[]
            {
                new NestedIntegerImpl(new NestedInteger[] { }),
            }), Is.EqualTo(new int[] { }));
        }

        private static List<int> FlattenList(NestedInteger[] nestedIntegers)
        {
            var iterator = new NestedIterator(nestedIntegers);

            var flatList = new List<int>();
            while (iterator.HasNext())
            {
                flatList.Add(iterator.Next());
            }

            return flatList;
        }
    }
}