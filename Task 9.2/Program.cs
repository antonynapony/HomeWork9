using Task_9._2;

IMultimediaDevice device;
Console.WriteLine("Выберите устройство для управления:\n" +
                  "Нажмите 1 для управления MP3-плеером\n" +
                  "Нажмите 2 для управления DVD-проигрывателем\n" +
                  "Нажмите 3 для управления радио");
while (true)
{
    bool IsSuccessChoice = int.TryParse(Console.ReadLine(), out int choice);
    if (IsSuccessChoice)
    {
        if (choice == 1)
        {
            device = new MP3Player();
            DeviceManager manager = new DeviceManager();
            manager.Manage(device);
            break;
        }
        else if (choice == 2)
        {
            device = new DVDPlayer();
            DeviceManager manager = new DeviceManager();
            manager.Manage(device);
            break;
        }
        else if (choice == 3)
        {
            device = new Radio();
            DeviceManager manager = new DeviceManager();
            manager.Manage(device);
            break;
        }
        else
        {
            Console.WriteLine("Неверная команда!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Неверная команда!");
    }
}
