using System;
using System.IO;

namespace Example2
{
    class DataBase
    {
        private string path;

        public DataBase(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Синхронный метод для подсчета чисел в БД, равных N
        /// </summary>
        /// <param name="N">Число, с которым идет сравнение</param>
        /// <returns>Количество чисел, равных &lt;param name="N"&gt;</returns>
        public int NumberOfEqual(int N)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                //Производим линейный поиск по всем строкам БД
                string str = String.Empty;

                while ((str = reader.ReadLine()) != null)
                {
                    //Обработка исключений в асинхронных методах -- сложная тема, которую мы рассмотрим позднее.
                    if (int.TryParse(str, out int number) && number == N)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Синхронный метод для подсчета суммы чисел на отрезке [L; R]
        /// </summary>
        /// <param name="L">Левая граница отрезка</param>
        /// <param name="R">Правая граница отрезка</param>
        /// <returns>Сумма чисел на отрезке [L;R] </returns>
        public int SumOnSegment(int L, int R)
        {
            int index = 0;
            int sum = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string str = String.Empty;

                while (index <= R && (str = reader.ReadLine()) != null)
                {
                    index++;
                    if (L <= index && index <= R)
                    {
                        if (int.TryParse(str, out int number))
                        {
                            sum += number;
                        }
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Изменение значений в БД на delta в интервале [L;R]
        /// </summary>
        /// <param name="delta">Дельта, на которую изменятся значения</param>
        /// <param name="L">Левая граница интервала</param>
        /// <param name="R">Правая граница интервала</param>
        public void ChangeValue(int delta, int L, int R)
        {
            int index = 0;
            int sum = 0;

            string file = String.Empty;
            using (StreamReader reader = new StreamReader(path))
            {
                string str = String.Empty;

                while (index <= R && (str = reader.ReadLine()) != null)
                {
                    index++;
                    file += str + "\n";
                    if (L <= index && index <= R)
                    {
                        if (int.TryParse(str, out int number))
                        {
                            file += (number + delta) + "\n";
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(path);
            }
        }

        /// <summary>
        /// Запоминание значений из БД на интервале [L;R]
        /// </summary>
        /// <param name="L">Левая граница интервала</param>
        /// <param name="R">Правая граница интервала</param>
        /// <returns></returns>
        public int[] ReadOnSegment(int L, int R)
        {
            if (R - L + 1 >= 1e5) //допустимый размер массива, чтобы точно хватило памяти,
                                  //а также чтобы вывод элементов занимал не слишком много времени
            {
                R = L + (int)1e5;
            }

            int index = 0;
            int i = 0;
            int[] values = new int[R - L + 1];

            using (StreamReader reader = new StreamReader(path))
            {
                string str = String.Empty;

                while (index <= R &&(str = reader.ReadLine()) != null)
                {
                    index++;
                    if (L <= index && index <= R)
                    {
                        if (int.TryParse(str, out int number))
                        {
                            values[i] = number;
                            i++;
                        }
                    }
                }
            }

            return values;
        }

    }
}