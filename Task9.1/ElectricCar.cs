
namespace Task9._1
{
    public class ElectricCar : Car
    {
        private int _rangeononecharge;
        public int RangeOnOneCharge
        {
            get { return _rangeononecharge; }
            set
            {
                if (value > 0)
                {
                    _rangeononecharge = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private int _chargelevel;

        public int ChargeLevel
        {
            get { return _chargelevel; }
            set
            {
                if (value > 0)
                {
                    _chargelevel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public ElectricCar(int weight, int maxspeed, int doorsnumber, string fueltype, int rangeononecharge, int chargelevel) : base(weight, maxspeed, doorsnumber, fueltype)
        {
            ChargeLevel = chargelevel;
            RangeOnOneCharge = rangeononecharge;
        }
        public new void DisplayInfo()
        {
            Console.WriteLine($"Вес транспортного средства: {Weight} кг\n" +
                              $"Максимальная скорость: {MaxSpeed} км/ч\n" +
                              $"Количество дверей: {DoorsNumber}\n" +
                              $"Тип используемого топлива: {FuelType}\n" +
                              $"Дальность хода на одном заряде: {RangeOnOneCharge} км\n" +
                              $"Текущий уровень заряда: {ChargeLevel} ампер-час");
        }
    }
}
