using System;
using System.Collections.Generic;
using System.Text;

namespace MyListFunc
{
    class MyList<T>
    {
        private T[] array;
        private T[] tempArray;
        public MyList()
        {
            array = new T[0]; 
        }

        public void Add(T value)
        {
            tempArray = array;
            array = new T[array.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = value;
        }

        public int Count
        {
            get { return array.Length; }
        }

        public T[] GetValue
        {
            get { return array; }
        }
    }
}
