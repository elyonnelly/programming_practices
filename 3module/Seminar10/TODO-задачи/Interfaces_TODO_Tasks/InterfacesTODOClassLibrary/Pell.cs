namespace InterfacesTODOClassLibrary
{
    public class Pell : ISeries
    {
        /// <summary>
        /// k-1 - ый член ряда
        /// </summary>
        int kMinusOne;
        /// <summary>
        /// k-2 - ый член ряда
        /// </summary>
        int kMinusTwo;
        /// <summary>
        /// Конструктор для создания экземпляра класса ряда Пелла
        /// </summary>
        public Pell()
        {
            SetBegin();
        }
        /// <summary>
        /// Метод для возвращения k-ого члена ряда
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int this[int k]
        {
            get
            {
                int current = 0;
                SetBegin();
                if (k <= 0) return -1;
                for (int i = 0; i < k; i++)
                    current = GetNext;
                return current;
            }
        }
        /// <summary>
        /// Свойство для возвращения следующего за k-1 члена ряда Пелла
        /// </summary>
        public int GetNext
        {
            get
            {
                int current = kMinusTwo + 2 * kMinusOne;
                kMinusTwo = kMinusOne;
                kMinusOne = current;
                return current;
            }
        }
        /// <summary>
        /// Метод для задания начального состояния
        /// </summary>
        public void SetBegin()
        {
            kMinusOne = 0;
            kMinusTwo = 1;
        }
    }
}