using System;

namespace ByteBank.SystemAgency
{
    public class GenericList<T>
    {
        private T[] _items;
        private int _nextPosition;
        public int Size { get { return _nextPosition; } }

        public GenericList(int capacityInitial = 8)
        {
            _items = new T[capacityInitial];
            _nextPosition = 0;
        }

        public void Add(T account)
        {
            VerifyCapacity(_nextPosition + 1);

            _items[_nextPosition] = account;
            _nextPosition++;
        }

        private void VerifyCapacity(int requiredSize)
        {
            if (_items.Length >= requiredSize)
            {
                return;
            }

            int newSize = _items.Length * 2;

            if (newSize < requiredSize)
            {
                newSize = requiredSize;
            }

            Console.WriteLine($"Aumentando capacidade da lista!");

            T[] newArray = new T[newSize];

            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }

        public void Remove(T account)
        {
            int indexItem = -1;

            for (int i = 0; i < _nextPosition; i++)
            {
                if (_items[i].Equals(account))
                {
                    indexItem = i;
                    break;
                }
            }

            for (int i = indexItem; i < _nextPosition - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _nextPosition--;
        }

        public T GetCurrentInIndex(int index)
        {
            if (index < 0 || index >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _items[index];
        }

        public T this[int item]
        {
            get
            {
                return GetCurrentInIndex(item);
            }
        }

        public void AddSeveral(params T[] items)
        {
            foreach (T account in items)
            {
                Add(account);
            }
        }
    }
}
