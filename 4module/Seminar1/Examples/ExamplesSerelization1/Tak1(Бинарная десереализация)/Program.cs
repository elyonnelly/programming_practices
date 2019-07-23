using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Library;


namespace Tak1_Бинарная_десереализация_
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("../../../Yandex.bin", FileMode.Open);
            BinaryFormatter bin = new BinaryFormatter();
            Enterprise Yandex =(Enterprise) bin.Deserialize(fs);
            Console.WriteLine(Yandex.ToString());
            Console.Read();
        }
    }
}
