using MusicZirconia.MusicFramework;
using MusicZirconia.GenerationFramework;

namespace MusicZirconia.MusicGeneration
{
    public class StreamGenerator
    {
        private MusicStreamFactory musicStreamFactory;
        private IMusicCreator musicCreator;

        public StreamGenerator(MusicStreamFactory musicStreamFactory, IMusicCreator musicCreator)
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
