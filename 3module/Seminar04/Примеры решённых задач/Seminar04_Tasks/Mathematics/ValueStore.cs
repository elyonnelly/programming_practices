
namespace Mathematics
{
    public class ValueStore
    {
        Expression exp;
        double x0; // точка - абсцисса
        double expCurrValue; // хранимое значение в x0

        public ValueStore(Expression e1, double x0)
        {
            exp = e1;
            this.x0 = x0;
            expCurrValue = exp.ExVal(x0);
        }

        public double CurrVal { get { return expCurrValue; } }

        // Метод, изменяющий значение поля expCurrValue
        // на значение выражения exp в точке x0
        public void OnExpChangedHandler()
        {
            expCurrValue = exp.ExVal(x0);
        }
    }
}
