using System.Collections.Generic;

namespace AlgoSolving.Task0341_Flatten_Nested_List_Iterator
{
    /// <summary>
    /// This is the interface that allows for creating nested lists.
    /// You should not implement it, or speculate about its implementation
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public interface NestedInteger
    {
        /// <summary>
        /// @return true if this NestedInteger holds a single integer, rather than a nested list.
        /// </summary>
        /// <returns></returns>
        bool IsInteger();

        /// <summary>
        /// @return the single integer that this NestedInteger holds, if it holds a single integer
        /// Return null if this NestedInteger holds a nested list 
        /// </summary>
        /// <returns></returns>
        int GetInteger();

        /// <summary>
        /// @return the nested list that this NestedInteger holds, if it holds a nested list
        /// Return null if this NestedInteger holds a single integer
        /// </summary>
        /// <returns></returns>
        IList<NestedInteger> GetList();
    }
}