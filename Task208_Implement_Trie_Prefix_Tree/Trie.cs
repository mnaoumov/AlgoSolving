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
            var node = root;
            foreach (var letter in word)
            {
                var letterIndex = letter - 'a';
                var letterNode = node.LetterNodes[letterIndex];

                if (letterNode == null)
                {
                    node.LetterNodes[letterIndex] = letterNode = new Node();
                }

                node = letterNode;
            }

            node.Inserted = true;
        }

        /// <summary>
        /// Returns if the word is in the trie.
        /// </summary>
        public bool Search(string word)
        {
            var node = root;
            foreach (var letter in word)
            {
                var letterIndex = letter - 'a';
                var letterNode = node.LetterNodes[letterIndex];

                if (letterNode == null)
                {
                    return false;
                }

                node = letterNode;
            }

            return node.Inserted;
        }

        /// <summary>
        /// Returns if there is any word in the trie that starts with the given prefix.
        /// </summary>
        public bool StartsWith(string prefix)
        {
            var node = root;
            foreach (var letter in prefix)
            {
                var letterIndex = letter - 'a';
                var letterNode = node.LetterNodes[letterIndex];

                if (letterNode == null)
                {
                    return false;
                }

                node = letterNode;
            }

            return true;

        }

        private class Node
        {
            public readonly Node[] LetterNodes = new Node[26];
            public bool Inserted { get; set; }
        }
    }
}