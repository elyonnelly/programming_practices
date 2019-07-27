using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enterprise Yandex = new Department(Randomize.rnd.Next(10,120),Randomize.RandomLine(),Randomize.RandomName(),null,"Frontend C#");
            int rand = Randomize.rnd.Next(15, 20);
            for (int i = 0; i < rand; i++)
            {
                try
                {
                    Yandex.Recuit(new Employee(Randomize.RandomName(), Randomize.rnd.Next(0, 9) + Randomize.rnd.NextDouble(), Randomize.rnd.Next(16, 70)));
                }
                catch(Ovverrun ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception)
                {
                    Console.WriteLine("something went wrong");
                }
            }
            rand = Randomize.rnd.Next(1, 5);
            for (int i = 0; i < rand; i++)
            {
                Yandex.Dismiss();
            }
            FileStream fs = new FileStream("../../../Yandex.bin", FileMode.Create);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fs, Yandex);
            fs.Close();
            Console.ReadLine();
        }
    }
}
