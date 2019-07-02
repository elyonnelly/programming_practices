using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Library;
using System.IO;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("../../../zooAnimal.ser", FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<Animal>), new Type[] { typeof(Animal), typeof(Bird), typeof(Mammal)});
                Zoo zoo = new Zoo((List<Animal>)xml.Deserialize(fs));
                var birds = from e in zoo where e is Bird select e;
                foreach (var item in birds)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("==============================");
                var mammal = from e in zoo.animals where (e is Mammal && e.IsTakenCare==false) select e;
                foreach (var item in mammal)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
            Console.Read();


        }
    }
}
