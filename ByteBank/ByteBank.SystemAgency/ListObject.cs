using System;

namespace ByteBank.SystemAgency
{
    public class ListObject
    {
        private object[] _items;
        private int _nextPosition;
        public int Size { get { return _nextPosition; } }

        public ListObject(int capacityInitial = 8)
        {
            _items = new object[capacityInitial];
            _nextPosition = 0;
        }

        public void Add(object account)
        {
            VerifyCapacity(_nextPosition + 1);

            Console.WriteLine($"Adicionando item na posição {_nextPosition}");

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

            object[] newArray = new object[newSize];

            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }

        public void Remove(object account)
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

            _items[_nextPosition] = null;
        }

        public object GetCurrentInIndex(int index)
        {
            if (index < 0 || index >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return _items[index];
        }

        public object this[int item]
        {
            get
            {
                return GetCurrentInIndex(item);
            }
        }

        public void AddSeveral(params object[] items)
        {
            foreach (object account in items)
            {
                Add(account);
            }
        }
    }
}
