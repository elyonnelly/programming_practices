using System;

namespace SampleTaskLib
{
    /// <summary>
    /// Класс пользовательского исключения.
    /// </summary>
    public class NoPassageException : Exception
    {
        public NoPassageException()
        {
            Console.WriteLine("Ты не пройдешь!");
        }

        public NoPassageException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public NoPassageException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message + " " + innerException.Message);
        }
    }
}
