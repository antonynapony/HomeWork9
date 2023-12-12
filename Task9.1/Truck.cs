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

        public Truck(int weight, int maxspeed, int loadcapacity) : base(weight, maxspeed)
        {
            LoadCapacity = loadcapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Вес транспортного средства: {Weight} кг\n" +
                              $"Максимальная скорость: {MaxSpeed} км/ч\n" +
                              $"Грузоподъемность: {LoadCapacity} кг");
        }
    }
}
