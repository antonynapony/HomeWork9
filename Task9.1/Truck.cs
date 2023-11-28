namespace Task9._1
{
    public class Truck : Vehicle
    {
        private int _loadcapacity;
        public int LoadCapacity
        {
            get { return _loadcapacity; }
            set
            {
                if (value > 0)
                {
                    _loadcapacity = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Truck(int _weight, int _maxspeed, int _loadcapacity) : base(_weight, _maxspeed)
        {
            LoadCapacity = _loadcapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Вес транспортного средства: {Weight} кг\n" +
                              $"Максимальная скорость: {MaxSpeed} км/ч\n" +
                              $"Грузоподъемность: {LoadCapacity} кг");
        }
    }
}
