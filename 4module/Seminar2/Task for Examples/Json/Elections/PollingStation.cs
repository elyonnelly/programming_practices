using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Elections
{
    [DataContract]
    public class PollingStation
    {
        List<Candidate> candidates;

        public PollingStation(List<Candidate> сandidates)
        {
            Candidates = сandidates;
            CountOfVotes = 0;
        }
        [DataMember]
        public List<Candidate> Candidates
        {
            get => candidates;
            private set
            {
                if (value == null) throw new NullReferenceException("Кандидатов нет выборы не пройдут!?");
                candidates = value;
            }
        }
        [DataMember]
        public int CountOfVotes { get; private set; }

        /// <summary>
        /// находим необходимого кандидата и добавляем ему голос
        /// </summary>
        /// <param name="candidate"></param>
        public void GetVote(Candidate candidate)
        {
            for (int i = 0; i <Candidates.Count; i++)
            {
                if(candidate.Equals(Candidates[i]))//сравнием объекты некоторого класса переопределив equals
                {
                    Candidates[i].Votes++;
                    CountOfVotes++;
                    break;
                }
            }
        }
        /// <summary>
        /// закончиваем прием голосов и находим победителя
        /// </summary>
        /// <returns></returns>
        public Candidate FinishElections()
        {
            for (int i = 0; i < Candidates.Count; i++)
            {
                //такс тут был косяк не забывайте 2 семинар приводиты инты к даблам при делении =)
                Candidates[i].PercentageOfVotes = (double)Candidates[i].Votes / CountOfVotes * 100;
            }
            Candidates.Sort();//по автомату сортирует по убываю, а мы хотим по возрастанию(да мы переопределите компаратор ради этого)
            Candidates.Reverse();
            return Candidates[0];
        }
        public override string ToString() => $"{PrintAllCandidates()}";
        private string PrintAllCandidates()
        {
            string line = "";
            for (int i = 0; i < Candidates.Count; i++)
            {
                line += $"{Candidates[i]}\n";
            }
            return line;
        }

    }
}
