namespace Task_9._2
{
    public class Radio : IMultimediaDevice
    {
        public Radio() { }
        public void Play()
        {
            Console.WriteLine("Вы воспроизвели радио");
        }
        public void Stop()
        {
            Console.WriteLine("Вы остановили воспроизведение радио");
        }
        public void Pause()
        {
            Console.WriteLine("Вы поставили радио на паузу");
        }
        public void Next()
        {
            Console.WriteLine("Вы переключились на следующую радиостанцию");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("Вы увеличили громкость");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("Вы уменьшили громкость");
        }
        public void IMultimediaDevice()
        {
            Console.WriteLine("Выберите операцию, которую хотели бы совершить:\n" +
                              "Введите 1 для того, чтобы воспроизвести радио\n" +
                              "Введите 2 для того, чтобы остановить воспроизведение радио\n" +
                              "Введите 3 для того, чтобы поставить радио на паузу\n" +
                              "Введите 4 для того, чтобы перейти у следующей радиостанции\n" +
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
                        Play();
                        continue;
                    }
                    else if (choice == 2)
                    {
                        Stop();
                        continue;
                    }
                    else if (choice == 3)
                    {
                        Pause();
                        continue;
                    }
                    else if (choice == 4)
                    {
                        Next();
                        continue;
                    }
                    else if (choice == 5)
                    {
                        IncreaseVolume();
                        continue;
                    }
                    else if (choice == 6)
                    {
                        DecreaseVolume();
                        continue;
                    }
                    else if (choice == 7)
                    {
                        Console.WriteLine("Радио выключено!");
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
