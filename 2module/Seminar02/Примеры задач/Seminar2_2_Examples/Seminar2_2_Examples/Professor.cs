namespace Seminar2_2_Examples
{
    class Professor
    {
        public string Surname { get; set; }
        public string Subject { get; set; }

        //Полиморфизм методов в чистом виде -- это перегрузка методов.
        //мы можем применять один и тот же функционал
        //к объектов разных типов

        /// <summary>
        /// Заклинание, которое может применить профессор -- изменить фамилию человека,
        /// притом не имеет значения, кто человек -- профессор или студент
        /// </summary>
        /// <param name="person">человек, к которому применяется заклинание</param>
        public void CastSpell(Professor person)
        {
            person.Surname = person.Surname.ToUpper().Insert(2, "owlow");
        }

        public void CastSpell(Student person)
        {
            person.Surname = person.Surname.ToUpper().Insert(3, "asdfghj");

        }

    }
}