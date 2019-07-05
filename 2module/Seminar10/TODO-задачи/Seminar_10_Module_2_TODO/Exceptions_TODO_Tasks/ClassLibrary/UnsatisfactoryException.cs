using System;

namespace ClassLibrary
{
    /// <summary>
    /// Класс исключения, возникающего при получении неудволетворительной оценки
    /// </summary>
    public class UnsatisfactoryException : Exception
    {
        public UnsatisfactoryException()
        {
        }

        public UnsatisfactoryException(string message) : base(message)
        {
        }

        public UnsatisfactoryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
