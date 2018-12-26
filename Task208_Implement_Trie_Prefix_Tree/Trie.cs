namespace AlgoSolving.Task208_Implement_Trie_Prefix_Tree
{
    public class Trie
    {
        private readonly Node root = new Node();

        /// <summary>
        /// Initialize your data structure here.
        /// </summary>
        public Trie()
        {

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
            var node = root;
            foreach (var letter in word)
            {
                var letterIndex = letter - 'a';
                var letterNode = node.LetterNodes[letterIndex];

                if (letterNode == null && createIfMissing)
                {
                    node.LetterNodes[letterIndex] = letterNode = new Node();
                }

                node = letterNode;
            }

            return node;
        }

        private class Node
        {
            public readonly Node[] LetterNodes = new Node[26];
            public bool Inserted { get; set; }
        }
    }
}