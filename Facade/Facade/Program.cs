using System;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.getAll();
            facade.getGun();
        }
    }

    public class Mp4SubSystem
    {
        public void getMP4()
        {
            Console.WriteLine(".mp4");
        }
    }


    public class Mp3SubSystem
    {
        public void getMP3()
        {
            Console.WriteLine(".mp3");
        }
    }


    public class Mp5SubSystem
    {
        public void getMP5()
        {
            Console.WriteLine("🔫");
        }
    }


    public class Facade
    {
        Mp4SubSystem mp4;
        Mp3SubSystem mp3;
        Mp5SubSystem mp5;

        public Facade()
        {
            mp3 = new Mp3SubSystem();
            mp4 = new Mp4SubSystem();
            mp5 = new Mp5SubSystem();
        }

        public void getAll()
        {
            mp3.getMP3();
            mp4.getMP4();
            mp5.getMP5();
        }

        public void getGun()
        {
            mp5.getMP5();
        }
    }
}
