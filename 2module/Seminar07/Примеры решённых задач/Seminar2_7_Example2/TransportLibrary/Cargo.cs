namespace TransportLibrary
{
    public class Cargo
    {
        public double Weight { get; private set; }

        public Cargo(double weight)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"weight: {Weight}";
        }
    }
}