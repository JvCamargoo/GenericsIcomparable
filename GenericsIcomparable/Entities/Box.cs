using System;

namespace GenericsIcomparable.Entities
{
    class Box<T>
    {
        private List<T> _list = new List<T>();

        public Box(List<T> list)
        {
        }
        public Box()
        {
        }

        public void Add(T item)
        { 
            _list.Add(item);
        }

        public void Sort()
        {
            if (_list.Count == 0)
            {
                throw new ArgumentException("ERROR");
            }
            _list.Sort();
        }

        public void Print()
        {
            foreach(T obj in _list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
