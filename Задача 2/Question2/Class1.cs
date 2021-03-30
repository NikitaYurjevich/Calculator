/*
 * Пояснение:
 *   Данный класс предназначен для создания списков различных типов. Класс содержит свойства и методы интерфейса IList<T>.
 *   
 *   Управление списком осуществляется с помощью полей:
 *      1) Count - возвращает количество элементов в списке.
 *      2) this[index] - возвращает элемент списка по указанному индексу.
 *      
 *   И методов:
 *      1) Add(T newItem) - добавляет элемент в конец списка.
 *      2) Clear() - полностью очищает список.
 *      3) Contains(T element) - возвращает true, если элемент содержится в списке, в противном случае false.
 *      4) RemoveAt(int index) - удаляет элемент по указанному индексу. 
 *      5) Insert(int index, T item) - добавляет элемент в список по указанному индексу.
 *      6) IndexOf(T element) - возвращает индекс указанного элемента. 
 */

using System;

namespace ConsoleApplication1
{
    public class MyList<T>
    {

        T[] array;
        public int Count { get { return array.Length; } set { value = array.Length; } }
        public T this[int index] { get { return array[index]; } set { array[index] = value; } }

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T newItem)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = newItem;
        }

        public void Clear()
        {
            Array.Resize(ref array, 0);
        }

        public bool Contains(T element)
        {
            foreach (T item in array)
                if (item.Equals(element)) return true;

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                for (int i = index; i < array.Length - 1; i++)
                    array[i] = array[i + 1];

                Array.Resize(ref array, array.Length - 1);
            }
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index <= array.Length)
            {
                Array.Resize(ref array, array.Length + 1);

                for (int i = array.Length - 1; i > index; i--)
                    array[i] = array[i - 1];

                array[index] = item;
            }
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i].Equals(element)) return i;

            return -1;

        }

    }
}
