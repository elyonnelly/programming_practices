
namespace Mathematics
{
    // делегат для методов-выражений
    public delegate double ExpDel(double x);
    // событийный делегат
    public delegate void ExpChanged();

    public class Expression
    {
        public event ExpChanged OnExpChanged; // событие типа ExpChanged
        ExpDel ex; // Поле для ссылки на метод-выражение

        public Expression(ExpDel e)
        { // Конструктор
            ex = e;
        }
        public double ExVal(double x)
        {
            return ex(x);
        }
        
        public ExpDel Ex
        {
            set
            {
                ex = value;

                // При обновлении выражения в аксессорe инициируем событие
                if (OnExpChanged != null)
                    OnExpChanged();
            }
        }
    }
}
