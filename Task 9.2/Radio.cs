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
