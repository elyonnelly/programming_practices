using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 256 + 5;
                using (FileStream fs = new FileStream("../../../number.bin", FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(x);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при записи в файл!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                using (FileStream fs = new FileStream("../../../number.bin", FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    Console.WriteLine(br.ReadInt32());

                    fs.Seek(0, SeekOrigin.Begin);

                    for (int i = 0; i < 4; ++i)
                        Console.WriteLine(br.ReadByte());
                    // Заметим, что числа записываются по байтам задом наперёд
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ошибка при чтении файла!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
