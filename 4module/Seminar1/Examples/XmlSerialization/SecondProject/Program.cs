using System;
using LibraryOfZoo;
using System.IO;
using System.Xml.Serialization;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("../../../Zoo.xml", FileMode.Open);//тут выпадают исключения поймайте их все
            //их можно посмотреть, если навести курсов на FileStream
            XmlSerializer xml = new XmlSerializer(typeof(Zoo));
            Zoo zoo = xml.Deserialize(fs) as Zoo;//безопастное приведение типов, при возмодности всегда используйте его
            Console.WriteLine(zoo);// посомтрите как устроен ToString в zoo и возьмите на вооружение
            Console.Read();
        }
    }
}
