using MusicGenerator.MusicGeneration.GeneratorFramework;
using MusicGenerator.MusicFramework;


namespace MusicGenerator.MusicGeneration
{
    public class MusicGenerator
    {
        private MusicStreamFactory musicStreamFactory;
        private IMusicCreator musicCreator;

        public MusicGenerator(MusicStreamFactory musicStreamFactory, IMusicCreator musicCreator)
        {
            this.musicStreamFactory = musicStreamFactory;
            this.musicCreator = musicCreator;
        }

        public MusicStream Generate()
        {
            MusicStream stream = musicStreamFactory.GetMusicStream();
            musicCreator.CreateMusic(stream);
            stream.Reset();
            return stream;
        }
    }
}
