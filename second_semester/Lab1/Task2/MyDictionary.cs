namespace Task2
{
    internal class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue> where TKey : notnull
    {
        private const int DefaultCapacity = 16;
        private int capacity;
        private int elementsCount = 0;
        private Node<TKey, TValue>[] _nodes;


        public MyDictionary()
        {
            capacity = DefaultCapacity;
            _nodes = new Node<TKey, TValue>[capacity];
        }

        public MyDictionary(int capacity)
        {
            this.capacity = capacity;
            _nodes = new Node<TKey, TValue>[capacity];
        }

        private class Node<K, V>
        {
            public int Hash { get; }
            public K Key { get; }
            public V Value { get; }
            public Node<K, V>? Next { get; set; }

            public Node(int hash, K key, V value, Node<K, V>? next = null)
            {
                Key = key;
                Hash = hash;
                Value = value;
                Next = next;
            }
        }

        public TKey Add(TKey key, TValue value)
        {
            var hash = Hash(key);
            var node = _nodes[hash];

            if (capacity <= elementsCount)
            {
                _nodes = resize();
            }


            if (node == null)
            {
                _nodes[hash] = new Node<TKey, TValue>(hash, key, value);
            }
            else if (node.Key.Equals(key))
            {
                node = new Node<TKey, TValue>(hash, key, value);
            }
            else if (node.Next != null)
            {
                while (node.Next != null || (node.Next != null && node.Next!.Key.Equals(key)))
                {
                    node = node.Next;
                }

                node.Next ??= new Node<TKey, TValue>(hash, key, value);
            }
            else
            {
                node.Next ??= new Node<TKey, TValue>(hash, key, value);
            }

            elementsCount++;
            return key;
        }

        public TValue Get(TKey key)
        {
            var hash = Hash(key);
            var node = _nodes[hash];

            if (node.Next == null)
            {
                return node.Value;
            }
            else
            {
                while (node.Next != null && !node.Equals(node.Next))
                {
                    node = node.Next;
                }

                return node.Value;
            }
        }

        private Node<TKey, TValue>[] resize()
        {
            int newCap = capacity > DefaultCapacity
                ? capacity + (capacity / 2)
                : DefaultCapacity + (capacity / 2);
            var newNodes = new Node<TKey, TValue>[newCap];


            for (var i = 0; i < _nodes.Length; i++)
            {
                if (_nodes[i] != null)
                {
                    newNodes[i] = _nodes[i];
                }
            }

            capacity = newCap;
            return newNodes;
        }

        private int Hash(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % capacity;
        }
    }
}