using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите полижительное целочисленное число N:");
            int N = Reading();
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < N; i++)
            {
                CreateNewObject(rnd, ref animals);
                if(animals[i] is Bird)
                    animals[i].OnSound += () => Console.WriteLine("я птичка, пип-пип-пип");
                else
                    animals[i].OnSound += () => Console.WriteLine("я млекопитающие, би-би-би");

            }
            Zoo zoo = new Zoo(animals);
            foreach (var item in zoo)
            {
                Console.WriteLine(item);
                item.DoSound();
            }
            FileStream fs = new FileStream("../../../zooAnimal.bin",FileMode.Create);
            //XmlSerializer xml = new XmlSerializer(typeof(Zoo), new Type[] { typeof(Animal), typeof(Bird), typeof(Mammal),typeof(Zoo) });
            //xml.Serialize(fs, zoo);
            //DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Zoo), new Type[] { typeof(Animal), typeof(Bird), typeof(Mammal), typeof(Zoo) });
            //json.WriteObject(fs, zoo);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fs,zoo);
            fs.Close();
            Console.Read();


        }

        /// <summary>
        /// создание новго животного
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="animals"></param>
        private static void CreateNewObject(Random rnd, ref List<Animal> animals)
        {
            try
            {
                if (rnd.Next(0, 2) == 1) animals.Add(new Mammal(CreateName(rnd), rnd.Next(1, 11) <= 4, rnd.Next(-10, 100)));
                else
                    animals.Add(new Bird(CreateName(rnd), rnd.Next(1, 11) <= 4, rnd.Next(-10, 100)));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                CreateNewObject(rnd, ref animals);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CreateNewObject(rnd, ref animals);
            }
            
        }

        private static string CreateName(Random rnd)
        {
            string name = "";
            name += (char)rnd.Next('A', 'Z');
            for (int i = 0; i < rnd.Next(3,10); i++)
            {
                name += (char)rnd.Next('a', 'z');
            }
            return name;
        }

        private static int Reading()
        {
            int k = 0;
            try
            {
                k = int.Parse(Console.ReadLine());
                if (k <= 0) throw new ArgumentException();
            }
            catch(Exception ex)
            {
                k = Reading();
                Console.WriteLine("Ошибка попробуте еще раз:");
            }
            return k;
        }
    }
}
