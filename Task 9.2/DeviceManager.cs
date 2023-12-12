namespace Task_9._2
{
    public class DeviceManager
    {
        public void Manage(IMultimediaDevice device)
        {
            Console.WriteLine("Выберите операцию, которую хотели бы совершить:\n" +
                              "Введите 1 для того, чтобы воспроизвести\n" +
                              "Введите 2 для того, чтобы остановить воспроизведение\n" +
                              "Введите 3 для того, чтобы поставить на паузу\n" +
                              "Введите 4 для того, чтобы перейти у следующей дорожке\n" +
                              "Введите 5 для того, чтобы увеличить громкость\n" +
                              "Введите 6 для того, чтобы уменьшить громкость\n" +
                              "Введите 7 для того, чтобы выключить устройство");
            while (true)
            {
                bool IsSuccessChoice = int.TryParse(Console.ReadLine(), out int choice);
                if (IsSuccessChoice)
                {
                    if (choice == 1)
                    {
                        device.Play();
                        continue;
                    }
                    else if (choice == 2)
                    {
                        device.Stop();
                        continue;
                    }
                    else if (choice == 3)
                    {
                        device.Pause();
                        continue;
                    }
                    else if (choice == 4)
                    {
                        device.Next();
                        continue;
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Введите на сколько единиц вы хотите увеличить громкость: ");
                        int volume = int.Parse(Console.ReadLine());
                        device.IncreaseVolume(volume);
                        continue;
                    }
                    else if (choice == 6)
                    {
                        Console.WriteLine("Введите на сколько единиц вы хотите уменьшить громкость: ");
                        int volume = int.Parse(Console.ReadLine());
                        device.DecreaseVolume(volume);
                        continue;
                    }
                    else if (choice == 7)
                    {
                        Console.WriteLine("Устройство выключено!");
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
        }
    }
}
