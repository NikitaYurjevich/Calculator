/*
 * В методе Main демонстрируется работа класса MyList<T>.
 */

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> int_list = new MyList<int>();
            Console.WriteLine("Создание нового списка типа int с помощью класса MyList:");
            Console.WriteLine();
            int_list.Add(8);
            int_list.Add(4);
            int_list.Add(80);

             Console.Write("Список после добавления трех элементов: ");
            for(int i = 0; i<int_list.Count; i++)
                Console.Write(int_list[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Проверка, есть ли в списке число 70: " + int_list.Contains(70));
            Console.WriteLine("Проверка, есть ли в списке число 80: " + int_list.Contains(80));

            Console.WriteLine("Количество элементов в массиве: " + int_list.Count);

            Console.WriteLine("Элемент с индексом [1] до удаления элемента: "  + int_list[1]);
            int_list.RemoveAt(1);
            Console.WriteLine("Элемент с индексом [1] после удаления элемента:" + int_list[1]);
            Console.WriteLine("Количество элементов в массиве: " + int_list.Count);

            int_list.Insert(1, 45);
            Console.WriteLine("Элемент с индексом [1] после добавления элемента: " + int_list[1]);

            Console.WriteLine("Индекс элемента в списке со значением 8: [{0}]" ,int_list.IndexOf(8));

            Console.Write("Список после проведенных операций: ");
            for (int i = 0; i < int_list.Count; i++)
                Console.Write(int_list[i] + " ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            MyList<string> str_list = new MyList<string>();
            Console.WriteLine("Создание нового списка типа string с помощью класса MyList:");
            Console.WriteLine();
            str_list.Add("How");
            str_list.Add("are");
            str_list.Add("you");
            str_list.Add("?");

            Console.Write("Список после добавления четырех элементов: ");
            for (int i = 0; i < str_list.Count; i++)
                Console.Write(str_list[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Проверка, есть ли в списке строка Where: " + str_list.Contains("Where"));
            Console.WriteLine("Проверка, есть ли в списке строка How: " + str_list.Contains("How"));

            Console.WriteLine("Количество элементов в массиве: " + str_list.Count);

            Console.WriteLine("Элемент с индексом [0] до удаления элемента: " + str_list[0]);
            str_list.RemoveAt(0);
            Console.WriteLine("Элемент с индексом [0] после удаления элемента:" + str_list[0]);
            Console.WriteLine("Количество элементов в списке: " + str_list.Count);

            str_list.Insert(0, "Where");
            Console.WriteLine("Элемент с индексом [0] после добавления элемента: " + str_list[0]);

            Console.WriteLine("Индекс строки you: [{0}]", str_list.IndexOf("you"));

            Console.Write("Список после проведенных операций: ");
            for (int i = 0; i < str_list.Count; i++)
                Console.Write(str_list[i] + " ");
            Console.WriteLine();        
        }
    }
}
