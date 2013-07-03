using MusicZirconia.MusicGeneration.GeneratorFramework;
using MusicZirconia.MusicFramework;


namespace MusicZirconia.MusicGeneration
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
