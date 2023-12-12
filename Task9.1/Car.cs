namespace Task9._1
{
    public class Car : Vehicle
    {
        private int _doorsnumber;
        public int DoorsNumber
        {
            get { return _doorsnumber; }
            set
            {
                if (value > 0)
                {
                    _doorsnumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private string _fueltype;
        public string FuelType
        {
            get { return _fueltype; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _fueltype = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Car(int weight, int maxspeed, int doorsnumber, string fueltype) : base(weight, maxspeed)
        {
            DoorsNumber = doorsnumber;
            FuelType = fueltype;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Вес транспортного средства: {Weight} кг\n" +
                              $"Максимальная скорость: {MaxSpeed} км/ч\n"  +
                              $"Количество дверей: {DoorsNumber}\n"        +
                              $"Тип используемого топлива: {FuelType}");
        }
    }
}
