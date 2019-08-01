using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Library;


namespace Tak1_Бинарная_десереализация_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream("../../../Yandex.bin", FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();
                Enterprise Yandex = (Enterprise)bin.Deserialize(fs);
                Console.WriteLine(Yandex.ToString());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (IOException)
            //можете навести курсов на FileStream и посмотреть список всех ошибок, которые пораждаются потоком открытия файла
            {
                Console.WriteLine("something went wrong");
            }
            catch (Exception)
            {
                Console.WriteLine("something went wrong");
            }
            Console.Read();
        }
    }
}
