using System;
using System.IO;
using System.Xml.Serialization;


namespace LibraryOfZoo
{
    [XmlInclude(typeof(Bird))]//попробуйте убрать это псомотреть какая ошибка выпдает при серилизации
    [XmlInclude(typeof(Insect))]
    public abstract class Animal
    {
        protected Animal(string name)
        {
            Kind = name;
        }

        protected Animal()
        {
        }

        public event EventHandler<SouneEventArgs> GetVoice;//стандартный шаблон событий
        public string Kind { get; set; }

        public void DoSound(string voice)
        {
            GetVoice(this, new SouneEventArgs(voice));
        }
    }
}
