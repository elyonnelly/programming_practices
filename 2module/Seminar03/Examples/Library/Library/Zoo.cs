using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Library
{
    [DataContract][Serializable]
    public class Zoo:IEnumerable<Animal>
    {
        public Zoo()
        {
        }

        public Zoo(List<Animal> animals)
        {
            this.animals = animals;
        }
        [DataMember]
        public List<Animal> animals { get; set; }
        
        public IEnumerator<Animal> GetEnumerator()
        {
            var res = from e in animals orderby e.Name.Length select e;
            foreach (var item in res)
            {
                yield return item;
            }
        }
        public void Add(Animal item)
        {
            if(animals!=null && item !=null)
                animals.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
