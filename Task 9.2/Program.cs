using Task_9._2;

Console.WriteLine("Выберите устройство для управления:\n" +
                  "Нажмите 1 для управления MP3-плеером\n" +
                  "Нажмите 2 для управления DVD-проигрывателем\n" +
                  "Нажмите 3 для управления радио\n" +
                  "Нажмите 4 для выхода из меню");
while (true)
{
    bool IsSuccessChoice = int.TryParse(Console.ReadLine(), out int choice);
    if (IsSuccessChoice)
    {
        if (choice == 1)
        {
            MP3Player mp3player = new MP3Player();
            mp3player.IMultimediaDevice();
            continue;
        }
        else if (choice == 2)
        {
            DVDPlayer dvdplayer = new DVDPlayer();
            dvdplayer.IMultimediaDevice();
            continue;
        }
        else if (choice == 3)
        {
            Radio radio = new Radio();
            radio.IMultimediaDevice();
            continue;
        }
        else if (choice == 4)
        {
            Console.WriteLine("Вы вышли из меню управления!");
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