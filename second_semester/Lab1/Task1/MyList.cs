namespace Task1
{
    public class MyList<T> : IMyList<T>
    {
        private T?[] _items;
        public int Size;

        private const int DefaultCapacity = 10;
        private static readonly T[] EmptyElement = new T[0];

        public MyList(int capacity)
        {
            _items = capacity switch
            {
                < 0 => throw new ArgumentOutOfRangeException(),
                0 => EmptyElement,
                _ => new T[capacity]
            };
        }

        public MyList()
        {
            _items = new T[DefaultCapacity];
        }


        public void Add(T item)
        {
            if (_items.Length > Size)
            {
                _items[Size++] = item;
            }
            else
            {
                ExpandArray(2);
                _items[Size++] = item;
            }
        }

        public T Get(int index)
        {
            return _items[index];
        }

        public bool Contains(T o)
        {
            return IndexOf(o) >= 0;
        }


        private int IndexOf(T o)
        {
            for (var i = _items.Length - 1; i >= 0; i--)
            {
                if (_items[i]!.Equals(o))
                {
                    return i;
                }
            }

            return -1;
        }

        private void ExpandArray(int capacity)
        {
            if (capacity > _items.Length)
            {
                var newSize = _items.Length + (_items.Length / 2);
                newSize = newSize > capacity
                    ? newSize
                    : _items.Length + capacity;
                Array.Resize(ref _items, newSize);
            }
        }
    }
}