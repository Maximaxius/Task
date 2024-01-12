using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_modul_10_part_01
{
    internal class Queue<T>
    {
        private List<T> _data;
        private int _size;

        public int size { get { return _size; } }   // ==count ?

        public Queue()
        {
            _data = new List<T>();
        }
        public void Enqueue(T item)
        {
            _data.Add(item);
            _size++;
        }

        public T Dequeue()
        {
            T obj = Peek();                             
            _data.Remove(obj);
            _size--;
            return obj;
        }

        public T Peek()
        {            
            return _data[0];
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
