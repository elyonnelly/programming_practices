/*
Случайный повтор слов — это распространенная ошибка при написании текстов. 
Регулярное выражение можно использовать для определения повторяющихся слов,
как показано в следующем примере.

Метод Regex.Matches вызывается с параметрами регулярного выражения RegexOptions.IgnoreCase.
Поэтому операция сопоставления учитывает регистр, а пример указывает,
что подстрока "This this" является повтором.

Обратите внимание, что входная строка содержит подстроку "this? This". 
Но из-за знака пунктуации она не считается повторением.
*/
using System;
using System.Text.RegularExpressions;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                                  match.Value, match.Groups[1].Value, match.Index);
            Console.ReadKey(true);
        }
    }
}
