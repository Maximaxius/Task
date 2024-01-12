using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_modul_10_part_01
{
    internal class Stacks<T>
    {        
        private List<T> _data;
        private int _size;

        public int size { get { return _size; } }   // ==count ?

        public Stacks()
        {
            _data = new List<T>();           
        }
        public void Push(T item)
        {
            _data.Add(item);
            _size++;
        }

        public T Pop()
        {
            T obj = Peek();                             // до реализации Peek  T obj =_data[size-1];
            _data.Remove(obj);
            _size--;
            return obj;
        }

        public T Peek()
        {
            if (size == 0)
                throw new IndexOutOfRangeException();
            return _data[size-1];
        }

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= _data.Count || _data == null)
                {
                    throw new IndexOutOfRangeException();
                }

                return _data[index]!;

            }
        }


        public override string ToString()
        {
            return $"{_data}";
        }

    }
}
