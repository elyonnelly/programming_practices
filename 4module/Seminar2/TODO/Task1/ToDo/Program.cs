using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    //для начала пропишите нужные юзинги и продлючите ссылку
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Pair[] array = new Pair[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Pair(rnd.Next(0,11),rnd.Next(0,11));
            }
            array.Sort();
            FileStream fs = new FileStream("../../../Pairs.json",FileMode.Create);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Pair[]));
            jsonFormatter.WriteObject(fs,array);//так элементы будут записыны по возрастанию, ну если они отсортированы 
            fs.Close();
        }
    }

    class Pair:IComparable
    {
        int first;
        int second;

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        //переопределите компаратор
        //пары сравниваются сначала по первому числу, если они равны то по второму, если и они равны, то пары считаются равными
    }

}
