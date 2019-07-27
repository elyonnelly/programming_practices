using System;
using System.Linq;

namespace SampleTaskLib
{
    /// <summary>
    /// Класс цепочки символов, для которых диапазон кодов символов ограничен
    /// </summary>
    public class LimitedSymbolChain : SymbolChain
    {
        /// <summary>
        /// Код левой границы допустимых символов
        /// </summary>
        char StartCode;
        /// <summary>
        /// Код правой границы допустимых символов
        /// </summary>
        char EndCode;

        /// <summary>
        /// Конструктор для создания экземпляра цепочки символов
        /// </summary>
        /// <param name="startCode">Левая граница кодов допустимых символов</param>
        /// <param name="endCode">Правая граница кодов допустимых символов</param>
        public LimitedSymbolChain(char startCode, char endCode)
        {
            StartCode = startCode;
            EndCode = endCode;
        }

        /// <summary>
        /// Свойство для получения длины цепочки символов
        /// </summary>
        public override int GetChainLength { get => chain.Count(); }

        /// <summary>
        /// Метод для добавления символа в цепочку
        /// </summary>
        /// <param name="newSymb">Символ, который добавляется в цепочку</param>
        public override void AddToChain(char newSymb)
        {
            if (newSymb < StartCode || newSymb > EndCode)
                throw new ArgumentOutOfRangeException();
            else chain.Add(newSymb);
        }

        /// <summary>
        /// Метод для вывода информации о цепочке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = string.Empty;
            foreach (var symbol in chain)
                s += symbol + " ";
            return s;
        }
    }
}
