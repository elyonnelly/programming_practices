using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornithary;
using System.IO;
using System.Xml.Serialization;

namespace FirstProject
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Animal> lstbirds = GetRandomBirds();
            Ornitharym ornithary = new Ornitharym(lstbirds);
            FileStream fs = new FileStream("../../../Ornithary.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Ornitharym));
            xml.Serialize(fs, ornithary);
            fs.Close();
        }
        private static List<Animal> GetRandomBirds()
        {
            List<Animal> lst = new List<Animal>();
            int rand = rnd.Next(10, 15);
            for (int i = 0; i < rand; i++)
            {
                lst.Add(new Bird(rnd.Next(5, 149) + rnd.NextDouble()));
            }
            return lst;
        }
    }
}
