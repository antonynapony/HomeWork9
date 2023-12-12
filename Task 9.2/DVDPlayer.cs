namespace Task_9._2
{
    public class DVDPlayer : IMultimediaDevice
    {
        public DVDPlayer() { }
        public void Play()
        {
            Console.WriteLine("Вы воспроизвели видео");
        }
        public void Stop()
        {
            Console.WriteLine("Вы остановили воспроизведение видео");
        }
        public void Pause()
        {
            Console.WriteLine("Вы поставили видео на паузу");
        }
        public void Next()
        {
            Console.WriteLine("Вы перешли к следующему видео");
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
