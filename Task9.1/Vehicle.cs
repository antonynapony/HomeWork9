namespace Task9._1
{
    public class Vehicle
    {
        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private int _maxspeed;
        public int MaxSpeed
        {
            get { return _maxspeed; }
            set
            {
                if (value > 0)
                {
                    _maxspeed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public Vehicle(int _weight, int _maxspeed)
        {
            Weight = _weight;
            MaxSpeed = _maxspeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Вес транспортного средства: {Weight} кг\n" +
                              $"Максимальная скорость: {MaxSpeed} км/ч");
        }
    }
}
