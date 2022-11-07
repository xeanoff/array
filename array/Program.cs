using System.Collections;

namespace array
{
    class MyArray<T> : IEnumerable
    {
        private T[]? array = null;

        public MyArray() => array = new T[0];

        public MyArray(T[]? array) => this.array = array;

        public void Add(T item)
        {
            T[]? temp = array;
            array = new T[array!.Length + 1];
            int _index = 0;
            foreach (T obj in temp!)
            {
                array[_index] = obj;
                _index++;
            }
            array[array.Length - 1] = item;
        }
        public void Remove(T item)
        {
            T[]? temp = array;
            temp = array;
            int _count = 0;
            foreach (T obj in temp!)
            {
                if (item!.Equals(obj))
                    _count++;
            }
            if (_count > 0)
            {
                array = new T[array!.Length - _count];
                int _index = 0;
                foreach (T obj in temp!)
                {
                    if (!item!.Equals(obj))
                    {
                        array[_index] = obj;
                        _index++;
                    }
                }
            }
        }

        public int FindElement(T element)
        {
            int _index = 0;
            foreach(T item in array!)
            {
                if (item!.Equals(element))
                    return _index;
                _index++;
            }
            return -1;
        }

        public void ClearArray() => array = new T[0];

        public void Sort() => Array.Sort(array!);
        
        public IEnumerator GetEnumerator() => array!.GetEnumerator();

        public T this[int index]
        {
            get => array![index];
            set => array![index] = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5 };
            MyArray<int> intt = new(arr);
            //Console.WriteLine();
            intt.Add(1);
            intt.Add(6);
            intt.Add(3);
            intt.Sort();
            //intt.Remove(1);
            //intt.PrintArray();
            Console.WriteLine(intt.FindElement(2));
            foreach (var item in intt)
            {
                Console.Write($"{item} ");
            }
        }
    }
}