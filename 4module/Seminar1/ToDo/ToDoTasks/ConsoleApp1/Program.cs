using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static Random rnd = new Random();
        public static int iteratoridforsongs=0, iteratoridforowners=0;
        static void Main(string[] args)
        {
            PlayList user = new PlayList(RandomSongs(), iteratoridforowners++);
            FileStream fs1 = new FileStream("../../../PlayList.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(PlayList));
            xml.Serialize(fs1,user);
            FileStream fs2 = new FileStream("../../../PlayList.xml", FileMode.Open);//TODO поймайте все исключения
            PlayList someone = (PlayList)xml.Deserialize(fs2);
            fs2.Close();
            Console.WriteLine(someone);
            Console.Read();

        }


        public static string RandomLine()
        {
            string line = "";
            int rand = rnd.Next(10, 20);
            for (int i = 0; i < rand; i++)
            {
                line += (char)rnd.Next('a','z');
            }
            return line;
        }
        public static List<Song> RandomSongs()
        {
            List<Song> songs = new List<Song>();
            int rand = rnd.Next(10, 200);
            for (int i = 0; i < rand; i++)
            {
                songs.Add(new Song(iteratoridforsongs++, RandomLine(), rnd.Next(1, 5) + rnd.NextDouble()));
            }
            return songs;
        }
    }
    class PlayList//TODO перепишите автосвойства чтобы работала серелизация
    {
        List<Song> Playlist = new List<Song>();

        private PlayList()
        {
        }

        public PlayList(List<Song> playlist, int ownerId)
        {
            Playlist = playlist;
            OwnerId = ownerId;
        }

        public int OwnerId { get; private set; }
        public int CountOfSongs
        {
            get => Playlist.Count;
        }

        public override string ToString()
        {
            return GetListSings();
        }

        private string GetListSings()
        {
            string line = "";
            for (int i = 0; i < Playlist.Count; i++)
            {
                line += $"OwnerId: {OwnerId}, Him PLayList:\n{Playlist[i]}\n";
            }
            return line;
        }
    }
    class Song//TODO перепишите автосвойства чтобы работала серелизация
    {
        public Song(int id, string name, double duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Duration { get; private set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}, Duration: {Duration:f3}";
    }

}
