using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T, Y>
    {
        T[] _array1;
        Y[] _array2;
        T[] _tempArray1;
        Y[] _tempArray2;
        public MyDictionary()
        {
            _array1 = new T[0];
            _array2 = new Y[0];
        }

        public void Add(T item1, Y item2)
        {
            _tempArray1 = _array1;
            _tempArray2 = _array2;
            _array1 = new T[_tempArray1.Length + 1];
            _array2 = new Y[_tempArray2.Length + 1];

            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
            }

            _array1[_array1.Length - 1] = item1;


            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _array2[i] = _tempArray2[i];
            }

            _array2[_array1.Length - 1] = item2;
        }

        public int Count
        {
            get { return _array1.Length; }
        }

        public T[] DictionaryKey
        {
            get { return _array1; }
        }

        public Y[] DictionaryValue
        {
            get { return _array2; }
        }


    }
}
