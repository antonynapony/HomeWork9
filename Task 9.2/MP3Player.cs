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
        public void IncreaseVolume(int value)
        {
            Console.WriteLine($"Вы увеличили громкость на {value}");
        }
        public void DecreaseVolume(int value)
        {
            Console.WriteLine($"Вы уменьшили громкость на {value}");
        }
    }
}
