using System;

namespace FacadeDesignPattern
{
    public class AudioMixer
    {
        public string AudioMixOperation()
        {
            return "Audio Mixer Operation";
        }
    }

    public class CodecFactory
    {
        public string Extract()
        {
            return "Extract Codec from File";
        }
    }

    public class VideoFile
    {
        public string VideoFileOperation()
        {
            return "Operation on File";
        }
    }

    public class BitrateReader
    {
        public string BitrateReaderOperation()
        {
            return "Bitrate Reader Operation";
        }
    }

    public class MP4CompressionCodec
    {
        public string Compress()
        {
            return "Compress File";
        }
    }

    public class VideoConverterFacade
    {
        protected VideoFile _videoFile;
        protected CodecFactory _codecFactory;
        protected AudioMixer _audioMixer;
        protected BitrateReader _bitrateReader;
        protected MP4CompressionCodec _mp4Compression;

        public VideoConverterFacade()
        {
            _videoFile = new VideoFile();
            _codecFactory = new CodecFactory();
            _mp4Compression = new MP4CompressionCodec();
            _bitrateReader = new BitrateReader();
            _audioMixer = new AudioMixer();
        }

        public void Convert()
        {
            Console.WriteLine(_videoFile.VideoFileOperation());
            Console.WriteLine(_codecFactory.Extract());
            Console.WriteLine(_mp4Compression.Compress());
            Console.WriteLine(_bitrateReader.BitrateReaderOperation());
            Console.WriteLine(_audioMixer.AudioMixOperation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Convert = new VideoConverterFacade();
            Convert.Convert();
        }
    }
}