using System;
using System.Collections.Generic;
using LibraryOfZoo;
using System.IO;
using System.Xml.Serialization;

namespace FirstProjects
{
    class Program
    {
        public static Random rnd = new Random();//тут можно обойтись без класса обложки на рандом тк его используем не так много
        static void Main(string[] args)
        {
            List<Animal> lstanimal = FillZoo();
            Zoo zoo = new Zoo(lstanimal);
            WalkToZoo(zoo);
            FileStream fs = new FileStream("../../../Zoo.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Zoo));
            //есть еще такой способ для серилизации обьектов неопрделенносго типа, если уберете  xmlinclude в классе Animal
            //то замете что эта серилизация тажке работает, но все таки лучше использовать предложенный вариант
            //XmlSerializer xml = new XmlSerializer(typeof(Zoo), new Type[] { typeof(Zoo),typeof(Bird), typeof(Insect)});

            xml.Serialize(fs, zoo);
            fs.Close();
            Console.Read();
        }

        /// <summary>
        /// идем по всем животным приписываем событие и вызываем метод голоса(можно выделить в два разных метода)
        /// </summary>
        /// <param name="zoo"></param>
        private static void WalkToZoo(Zoo zoo)
        {
            for (int i = 0; i < zoo.AllAnimals.Count; i++)
            {
                zoo.AllAnimals[i].GetVoice += GetVoice;//подписываем на событие метод. Почему  мы не можем вызвать событие?
                if (zoo.AllAnimals[i] is Bird)
                    zoo.AllAnimals[i].DoSound("__Chi-Chy__");
                else
                {
                    if (zoo.AllAnimals[i] is Insect)
                        zoo.AllAnimals[i].DoSound("__Bzzzzzzz__");

                }
            }
        }

        /// <summary>
        /// создаем список животный в зоопарке, потом скинем ссылку
        /// </summary>
        /// <returns></returns>
        private static List<Animal> FillZoo()
        {
            List<Animal> lst = new List<Animal>();
            int rand = rnd.Next(10, 15);
            for (int i = 0; i < rand; i++)
            {
                if(rnd.Next(0,2)==1)
                    lst.Add(new Bird(rnd.Next(5, 149) + rnd.NextDouble()));//если бы были неправильные значения пришлось бы ловить ошибки помните об этом
                else
                    lst.Add(new Insect(rnd.Next(4, 13)));
            }
            return lst;
        }

        /// <summary>
        /// метод подписываемый на событие, созданное с помощью стандартного шаблона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void GetVoice(object sender, SouneEventArgs e)
        {
            Console.WriteLine($"I am {((Animal)sender).Kind},\n {e.sound}");//разберитесь как работает sender может быть не очевидно
            // с первого вгляда почему так работает
            // Вспомните работу с WF
        }
    }
}
