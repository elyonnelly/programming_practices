using System.Collections.Generic;

namespace SampleTaskLib
{
    /// <summary>
    /// Класс, представляющий цепочку символов
    /// </summary>
    public abstract class SymbolChain
    {
        /// <summary>
        /// Список символов
        /// </summary>
        protected List<char> chain = new List<char>();

        /// <summary>
        /// Свойство для получения длины цепочки символов
        /// </summary>
        public abstract int GetChainLength { get; }

        /// <summary>
        /// Метод для добавления символа в цепочку
        /// </summary>
        /// <param name="newSymb">Символ, который добавляется в цепочку</param>
        public abstract void AddToChain(char newSymb);
    }
}
