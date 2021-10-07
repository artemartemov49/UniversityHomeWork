namespace Task3.Cars
{
    internal abstract class Car
    {
        public string Mark { get; }
        public Color Color { get; }
        public int Cost { get; }


        protected Car(string mark, Color color, int cost)
        {
            Mark = mark;
            Color = color;
            Cost = cost;
        }
    }
}
