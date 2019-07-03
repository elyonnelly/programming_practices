/*
 * В wav файле с 24 по 27 байт находится поле, отвечающее
 * за частоту дискретизации. Необходимо считать audio.wav файл,
 * "вытащить" частоту дискретизации и вывести её в консоль.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream fs = new FileStream("../../../audio.wav", FileMode.Open))
                {
                    byte[] info = new byte[4];
                    fs.Seek(24, SeekOrigin.Begin); // Передвигаемся на 24-й байт файла
                    fs.Read(info, 0, 4); // Берём 4 байта с текущей позиции
                    int SampleRate = BitConverter.ToInt32(info, 0);
                    Console.WriteLine(SampleRate);
                }
                Console.ReadKey();
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при чтении файла!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
