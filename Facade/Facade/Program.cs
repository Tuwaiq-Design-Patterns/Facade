using System;

namespace Facade
{
    public class VideoConverter
    {
        protected VideoFile _videoFile;

        protected AudioMixer _audioMixer;

        public VideoConverter(VideoFile videoFile, AudioMixer audioMixer)
        {
            this._videoFile = videoFile;
            this._audioMixer = audioMixer;
        }
       public string Operation()
        {
            string result = "VideoConverter initializes subsystems:\n";
            result += this._videoFile.operation1();
            result += this._audioMixer.operation1();
            result += "VideoConverter orders subsystems to perform the action:\n";
            result += this._videoFile.operationN();
            result += this._audioMixer.operationZ();
            return result;
        }
    }
    public class VideoFile
    {
        public string operation1()
        {
            return "VideoFile: Ready!\n";
        }

        public string operationN()
        {
            return "VideoFile: Go!\n";
        }
    }
    public class AudioMixer
    {
        public string operation1()
        {
            return "AudioMixer: Get ready!\n";
        }

        public string operationZ()
        {
            return "AudioMixer: Fire!\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            VideoFile videoFile = new VideoFile();
            AudioMixer audioMixer = new AudioMixer();
            VideoConverter facade = new VideoConverter(videoFile, audioMixer);

            Console.WriteLine(facade.Operation());
        }
    }
}