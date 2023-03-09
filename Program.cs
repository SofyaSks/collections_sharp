using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace collections_sharp
{
    // System.Collection (необобщённые коллекции) - хранятся данные типа object (стек, очередь, словари) 
    // 1) хранят данные любого типа 2) в одной коллекции могут храниться разнотипные данные
    // ArrayList
    // Stack
    // Queue
    // Hashtable
    // SortedList


    // System.Collection.Generic - обобщённые коллекции
    // можем хранить строго типизированные данные 
    // случайное несовпадение типов исключается

    // System.Collection.Specialized - специальные коллекции
    // оперируют данными конкретного типа

    // BitArray - поразрядная коллекция 

    // System.Collection.Concurrent - многопоточный доступ к коллекции (обобщенной)

    class Program
    {
        static void Main(string[] args)
        {
            //1
            //ArrayList arrayList1 = new ArrayList();
            //WriteLine($"Вместимость по умолчанию:{ arrayList1.Capacity}");
            //2
            //ArrayList arrayList2 = new ArrayList(5);
            //WriteLine($"Вместимость :{ arrayList2.Capacity}");
            //3
            //ArrayList arrayList1 = new ArrayList();
            //WriteLine($"Вместимость по умолчанию: { arrayList1.Capacity}");
            //arrayList1.Add("word");
            //WriteLine($"Вместимость после добавления одного элемента: { arrayList1.Capacity}");
            //4
            //for (int i = 0; i < 4; i++)
            //{
            //    arrayList1.Add("letter");
            //    WriteLine($"Вместимость после добавления одного элемента: { arrayList1.Capacity}");
            //}
            //arrayList1.Add("letter");
            //WriteLine($"Вместимость после добавления одного элемента: { arrayList1.Capacity}");
            //5
            //ArrayList arrayList1 = new ArrayList();
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.Capacity = 17;
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //6
            //ArrayList arrayList1 = new ArrayList(2);
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.AddRange(new int[] { 1, 2, 3 });
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //7
            //ArrayList arrayList1 = new ArrayList(7);
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.AddRange(new int[] { 1, 2, 3 });
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.TrimToSize();
            //WriteLine($"Вместимость уменьшена до реального количества элементов: { arrayList1.Capacity}");
            //8
            //ArrayList arrayList1 = new ArrayList(new int[] { 1, 2, 3 });
            //WriteLine($"Элемент с индексом 2: { arrayList1[2]} ");
            //9
            //ArrayList arrayList1 = new ArrayList(new string[] { "one", "two", "three", null }); // null тоже считатет как зарезервированную ячейку под объект 
            //WriteLine($"Фактическое количество элементов: { arrayList1.Count}  ");
            //10
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add("one");
            //arrayList1.Add(10);
            //arrayList1.Add(true);
            //WriteLine("Все элементы коллекции:");
            //*10.1
            //foreach (object item in arrayList1)
            //{
            //    WriteLine($"\t{item}");
            //}
            //*10.2
            //foreach (object o in arrayList1)
            //    WriteLine(o.ToString()); // привод к ToString прямо в массиве
            //int i = (int)arrayList1[1];
            //WriteLine($"\t{i}");

            //11
            //ArrayList days = new ArrayList(new string[] { "Tuesday", "Sunday", "Monday", "Tuesday", "Wednesday ", "Thursday ", "Friday", "Saturday", "Sunday" });
            //WriteLine(($"индекс первого элемента {days.IndexOf("Sunday")}"));
            //WriteLine(($"индекс последнего элемента {days.LastIndexOf("Tuesday")}"));

            //ArrayList only = new ArrayList(days.GetRange(0, 3)); // копирование определенных данных из одной коллекции в другую 
            //foreach (string s in only)
            //    WriteLine(s);

            //12
            //ArrayList numbers = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //numbers.Insert(2, 22);
            //foreach (int i in numbers)
            //    WriteLine(i);

            //13
            //ArrayList numbers = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //numbers.RemoveAt(2);
            //foreach (int i in numbers)
            //    WriteLine(i);
            //14
            //ArrayList numbers = new ArrayList(new int[] { 1, 9, 3, 4, 5 });
            //numbers.Sort();
            //foreach (int i in numbers)
            //    WriteLine(i);

            // IndexOf(obj) - первое вхождение объекта в коллекцию
            // LastIndexOf(object) - последнее вхождение объекта в коллекцию



            // STACK

            //1.1
            // Stack stack = new Stack();
            //1.2
            //Stack stack = new Stack(5);
            //3
            //Write("Метод Push(): \n");
            //stack.Push("one");
            //stack.Push("two");
            //stack.Push(1);
            //stack.Push("three");
            //foreach (object str in stack)
            //{
            //    WriteLine(str);
            //}
            //4

            //WriteLine($"*****************************");
            //Write("\n\nМетод Pop(): \n");
            //stack.Pop();
            //foreach (string str in stack)
            //{
            //    WriteLine(str);
            //}

            //5
            //WriteLine($"*****************************");
            //string var = (string)stack.Peek();
            //WriteLine(var);
            //WriteLine($"*****************************");
            //foreach (string str in stack)
            //{
            //    WriteLine(str);
            //}

            //6
            //Stack s = new Stack();
            //s.Push("one");
            //s.Push("two");
            //s.Push("three");
            //WriteLine(s.Contains("ten"));
            //WriteLine(s.Contains("one"));

            //7
            //Stack s = new Stack();
            //s.Push("one");
            //s.Push("two");
            //s.Push("three");
            //WriteLine(s.Count);
            //s.Clear();
            //WriteLine(s.Count);

            //8
            //Write("\nМетод CopyTo():\n");
            //string[] str1 = new string[stack.Count];
            //stack.CopyTo(str1, 0);
            //foreach (string item in str1)
            //{
            //    WriteLine(item);
            //}



            // QUEUE

            ////1
            //Queue queue1 = new Queue();
            //Queue queue2 = new Queue(3);
            //Queue queue3 = new Queue(new ArrayList { "one", 8.4 }); // конструктор копирования 
            //Queue queue4 = new Queue(7,3.0f); // коэффициент роста размера очереди в случае переполнения 1.0 - 10.0, по умолчанию 2.0
            //2
            //Write("Метод Enqueue(): ");
            //Queue q = new Queue();
            //for (int i = 1; i < 4; i++)
            //{
            //    q.Enqueue(i);
            //    WriteLine();
            //    WriteLine(q.Dequeue());
            //}
            //WriteLine();

            //3

            Write("Метод Peek(): ");
            Queue q = new Queue();
            for (int i = 1; i < 3; i++)
            {
                q.Enqueue(i);

            }
            WriteLine();
            WriteLine("***************************");
            WriteLine(q.Peek()); // возвращает object 

            foreach (int i in q)
            {
                WriteLine(i);

            }

        }
    } 
} 
