namespace Task_9._2
{
    public interface IMultimediaDevice
    {
        void Play();
        void Stop();
        void Pause();
        void Next();
        void IncreaseVolume(int value);
        void DecreaseVolume(int value);
    }
}
