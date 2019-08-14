namespace InterfacesTODOClassLibrary
{
    /// <summary>
    /// Интерфейс числовых рядов
    /// </summary>
    public interface ISeries
    {
        /// <summary>
        /// Метод для задания начального состояния
        /// </summary>
        void SetBegin();
        /// <summary>
        /// Свойство для возвращения очередного члена ряда
        /// </summary>
        int GetNext { get; }
        /// <summary>
        /// Индексатор для возвращения k-ого члена ряда
        /// </summary>
        /// <param name="k">k-ый номер члена ряда</param>
        /// <returns>k-ый член ряда</returns>
        int this[int k] { get; }
    }
}
