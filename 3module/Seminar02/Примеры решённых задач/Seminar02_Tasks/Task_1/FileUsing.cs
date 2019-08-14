using System;
using System.IO;
using System.Diagnostics;

namespace MyLib
{
    // делегат
    public delegate void GetInfo(string message);
    public class FileUsing
    {
        // путь
        string path;

        // пустой конструктор
        public FileUsing()
        {
            path = @"..\..\..\Default.txt";
        }
        // конструктор с параметром
        public FileUsing(string customPath)
        {
            path = customPath;
        }
        // метод для записи
        public void WriteFile(bool @override, int strMin, int strMax)
        {
            // меняем min и max местами, если необходимо, чтобы не выбросило исключение 
            // generator.Next(strMin, strMax);
            if (strMin > strMax)
            {
                int temp = strMin;
                strMin = strMax;
                strMax = temp;
            }
            FileStream fs;
            if (File.Exists(path) && !@override) // применяем параметр @override
                fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            else fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

            using (StreamWriter sr = new StreamWriter(fs))
            {
                long endPoint = fs.Length;
                // ставим поток в конец файла
                fs.Seek(endPoint, SeekOrigin.Begin);
                int StringQuantity = generator.Next(strMin, strMax);
                for (int i = 0; i < StringQuantity; i++)
                {
                    sr.WriteLine(StringGenerator());
                }
            }
        }

        string StringGenerator()
        {
            string str = string.Empty;
            int len = generator.Next(60, 101);
            for (int i = 0; i < len; i++)
            {
                char tmp = (char)generator.Next('a', 'z');
                // так легче всего сделать случайный латинский символ (строчной или заглавный)
                if (generator.Next(0, 2) == 1)
                    str += tmp.ToString().ToUpper();
                else str += tmp;
            }
            return str;
        }
        // закрытое поле - экземпляр типа делегата GetInfo
        private GetInfo getInfo;

        public void SetMethod(GetInfo setter)
        {
            getInfo = setter;
        }
        // чтение файла
        public void ReadFile()
        {
            // посчитаем ещё время чтения файла
            Stopwatch stopwatch = new Stopwatch();
            string line;
            if (getInfo == null)
                throw new Exception("null");
            int len = File.ReadAllLines(path).Length;
            if (len == 0)
                throw new Exception("Пустой файл");
            stopwatch.Start();
            using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                string mem = string.Empty;
                for (int i = 0; i < len; i++)
                {
                    line = sr.ReadLine();
                    int cur = (i + 1) * 100 / len;
                    if (cur.ToString() != mem)
                        getInfo($"{line} \t {cur} %");
                    mem = cur.ToString();
                }
            }
            stopwatch.Stop();
            getInfo($"Прошло времени {(double)stopwatch.ElapsedMilliseconds / 100} секунд");
        }
        Random generator = new Random();
    }
}
