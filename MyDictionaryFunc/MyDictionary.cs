using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryFunc
{
    class MyDictionary<K, V>
    {
        private K[] keyArray;
        private V[] valueArray;
        public MyDictionary()
        {
            keyArray = new K[0];
            valueArray = new V[0];
        }

        public void Add(K keys, V values)
        {
            K[] tempKeyArray = keyArray;
            V[] tempValueArray = valueArray;

            KeyAdd(keys, tempKeyArray);
            EqualKey(keys, tempKeyArray);

            ValueAdd(values, tempValueArray);
        }

        private void KeyAdd(K keys, K[] tempKeyArray)
        {
            keyArray = new K[keyArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i]; 
            }

            keyArray[keyArray.Length - 1] = keys;
        }

        private void ValueAdd(V values, V[] tempValueArray)
        {
            valueArray = new V[valueArray.Length + 1];

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }
            valueArray[valueArray.Length - 1] = values;
        }

        private void EqualKey(K keys, K[] tempKeyArray)
        {
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                if (tempKeyArray[i].Equals(keys))
                {
                    throw new Exception("Aynı Key Değerleri Girilemez!");
                }
            }
        }

        public int GetValueCount
        {
            get { return valueArray.Length; }
        }

        public int GetKeyCount
        {
            get { return keyArray.Length; }
        }

        public K[] GetKey
        {
            get { return keyArray; }
        }

        public V[] GetValue
        {
            get { return valueArray; }
        }
    }
}
