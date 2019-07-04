/*
 * Студент: Фомин Сергей
 * Группа: БПИ182
 * Дата: 04.07.2019
 * Задача: Сгенерировать файл с людьми, считать его, сделать файл
 *         results.txt, записать туда результаты
 */

using System;

namespace TodoTasks
{
    /// <summary>
    ///     Класс Rand создан для того, чтобы был только один экземпляр
    ///     с рандомом и, соответственно, не генерировал одинаковые числа.
    ///     Возможно, и существует более элегантное решение, но я другого
    ///     не знаю.
    /// </summary>
    public static class Rand
    {
        public static Random rng = new Random();

        public static int Next() => rng.Next();
        public static int Next(int x) => rng.Next(x);
        public static int Next(int left, int right) => rng.Next(left, right);
        public static double NextDouble() => rng.NextDouble();
        public static bool NextBool() => rng.Next(0, 2) == 1 ? true : false;
    }
}
