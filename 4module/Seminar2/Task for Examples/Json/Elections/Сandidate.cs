using System;
using System.Runtime.Serialization;


namespace Elections
{
    [DataContract]
    public class Candidate:IComparable//поправтье меня, если это сильно плохо не переопределять GetHashCode()!?
    {
        [DataMember]
        int Id;//очевидно что у всех разный подразумевается, что передастся уникальный иначе нужна была бы довольно затратная проверка
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public Party HimParty { get; private set; }
        [DataMember]
        public int Votes { get; internal set; }
        double percentageofvotes;

        public Candidate(int id,string name, Party himParty)
        {
            Id = id;
            Name = name;
            HimParty = himParty;
        }

        [DataMember]
        public double PercentageOfVotes
        {
            get => percentageofvotes;
            internal set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Someone cheated, elections will be held again");
                percentageofvotes = value;
            }
        }
        public override string ToString() => $"Candidate Name :{Name}, Him Party: {HimParty}, Percentage Of Votes {PercentageOfVotes:f3}%";

        public int CompareTo(object obj)//то же самое как с equals только немного поправить нужно 
        {
            return Votes.CompareTo((obj as Candidate).Votes);
        }

        public override bool Equals(object obj)//рефакторинг правая на название класса и переопределить equals по id(все проще чем кажется))
        {
            return obj is Candidate сandidate &&
                   Id == сandidate.Id;
        }
    }
}
