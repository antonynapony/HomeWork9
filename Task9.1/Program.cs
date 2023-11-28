using Task9._1;

Vehicle vehicle = new Vehicle(2400, 180);
Truck truck = new Truck(5400, 180, 17654);
Car car = new Car (2000, 240, 4, "Дизель");
ElectricCar electricCar = new ElectricCar(1800, 320, 2, "Электричество", 540, 1000);

Vehicle newVehicle = car;
newVehicle.DisplayInfo();
Console.WriteLine(string.Empty);
car.DisplayInfo();
Console.WriteLine(new string('-', 30));
Vehicle newVehicle2 = truck;
newVehicle2.DisplayInfo();
Console.WriteLine(string.Empty);
truck.DisplayInfo();
Console.WriteLine(new string('-', 30));
Vehicle newVehicle3 = electricCar;
newVehicle3.DisplayInfo();
Console.WriteLine(string.Empty);
electricCar.DisplayInfo();

