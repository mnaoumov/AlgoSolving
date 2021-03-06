﻿namespace AlgoSolving.Task0208_Implement_Trie_Prefix_Tree
{
    public class Trie
    {
        private readonly Node _root;

        /// <summary>
        /// Initialize your data structure here.
        /// </summary>
        public Trie()
        {
            _root = new Node();
        }

        /// <summary>
        /// Inserts a word into the trie.
        /// </summary>
        public void Insert(string word)
        {
            var wordNode = GetWordNode(word, createIfMissing: true);
            wordNode.Inserted = true;
        }

        /// <summary>
        /// Returns if the word is in the trie.
        /// </summary>
        public bool Search(string word)
        {
            var wordNode = GetWordNode(word, createIfMissing: false);
            return wordNode != null && wordNode.Inserted;
        }

        /// <summary>
        /// Returns if there is any word in the trie that starts with the given prefix.
        /// </summary>
        public bool StartsWith(string prefix)
        {
            return GetWordNode(prefix, createIfMissing: false) != null;
        }

        private Node GetWordNode(string word, bool createIfMissing)
        {
            var node = _root;
            foreach (var letter in word)
            {
                const char firstLetter = 'a';
                var letterIndex = letter - firstLetter;
                var letterNode = node.LetterNodes[letterIndex];

                if (letterNode == null)
                {
                    if (createIfMissing)
                    {
                        node.LetterNodes[letterIndex] = letterNode = new Node();
                    }
                    else
                    {
                        return null;
                    }
                }

                node = letterNode;
            }

            return node;
        }

        private class Node
        {
            private const int LettersInAlphabet = 26;
            public Node[] LetterNodes { get; } = new Node[LettersInAlphabet];
            public bool Inserted { get; set; }
        }
    }
}