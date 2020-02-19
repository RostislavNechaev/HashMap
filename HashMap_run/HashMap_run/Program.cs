using System;
using HashMap;

namespace HashMap_run
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание таблицы
            var map = new HashMap<int, string>();
            map.Add(1, "Yellow");
            map.Add(2, "Green");
            map.Add(new Item<int, string>(3, "Blue"));
            map.Add(4, "Brown");
            ShowMap(map, "Создание коллекции");

            //изменение значения в таблице
            map.Update(1, "Black");
            map.Update(2, "White");
            ShowMap(map, "ОБновление 1 и 2 элемента");

            //Удаление элемента
            map.Remove(4);
            ShowMap(map, "Удаление 4 элемента");

            Console.ReadLine();
        }

        //Вывод данных Ключ-Значение
        private static void ShowMap(HashMap<int, string> map, string title)
        {
            Console.WriteLine($"{title}: ");
            foreach (var key in map.Keys)
            {
                var value = map.Get(key);
                Console.WriteLine($"{key} - {value}");
            }
            Console.WriteLine();
        }
    }
}
