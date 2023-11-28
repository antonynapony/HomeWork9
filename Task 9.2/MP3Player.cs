namespace Task_9._2
{
    public class MP3Player : IMultimediaDevice
    {
        public MP3Player() { }
        public void Play()
        {
            Console.WriteLine("Вы воспроизвели песню");
        }
        public void Stop()
        {
            Console.WriteLine("Вы остановили воспроизведение");
        }
        public void Pause()
        {
            Console.WriteLine("Вы поставили песню на паузу");
        }
        public void Next()
        {
            Console.WriteLine("Вы перешли к следующей песне");
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
                              "Введите 1 для того, чтобы воспроизвести песню\n" +
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
                        Console.WriteLine("Плеер выключен!");
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
