
namespace Task_2
{
    public class Power
    {
        // поля
        int energy;
        int strength;
        int velocity;
        // ко
        public Power(int energy, int strength, int velocity)
        {
            this.energy = energy;
            this.strength = strength;
            this.velocity = velocity;
        }
        public static implicit operator string(Power p)
        {
            return $"energy = {p.energy}\n" +
                $"strength = {p.strength}\n" +
                $"velocity = {p.velocity}";
        }
        public static Power operator +(Power p1, Power p2)
        {
            return new Power(p1.energy + p2.energy, p1.strength + p2.strength, 
                p2.velocity * p2.velocity);
        } 
    }
}
