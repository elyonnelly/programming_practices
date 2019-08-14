using System;
using System.Runtime.Serialization.Json;
using System.IO;
using Elections;

namespace Task1
{
    /* Заходим в ссылки сборки       
     * добавляем System.Runtime.Serelization
     * Самый легкий способ запонить пишете runtime
     * он выдает нужную нам
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            PollingStation elections = new PollingStation(Randomize.CreateNewCandidates());
            StartElections(ref elections);
            Console.WriteLine($"Winner: {elections.FinishElections()}");
            Console.WriteLine($"All Candidates:\n{elections}");
            FileStream fs = new FileStream("../../../result.json", FileMode.Create);
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(PollingStation));
            //enum сериализуется как число(это логично с какойто стороны с другой нет)
            //другими словами никогда не юзайте enum дал чтобы просто вспомнили есть некторые неочевидные моменты с работой с ними
            json.WriteObject(fs, elections);
            //кстати json очень читаемый, поэтому достаточно открыть файлик с помощью блокнотика и все проверить))
            fs.Close();
            Console.Read();
        }

        /// <summary>
        /// голосуем))
        /// </summary>
        /// <param name="elections"></param>
        private static void StartElections(ref PollingStation elections)
        {
            int rand = Randomize.rnd.Next(100, 1000);
            for (int i = 0; i < rand; i++)
            {
                elections.GetVote(elections.Candidates[Randomize.rnd.Next(0,elections.Candidates.Count)]);
            }
        }
    }
}
