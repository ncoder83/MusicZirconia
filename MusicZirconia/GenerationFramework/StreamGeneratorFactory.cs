using MusicZirconia.GenerationFramework;
using MusicZirconia.MusicFramework;

namespace MusicZirconia.MusicGeneration
{
    public class StreamGeneratorFactory
    {
        public StreamGenerator GetStreamGenerator(IMusicCreator musicCreator)
        {
            MusicStreamFactory musicStreamFactory = new MusicStreamFactory();
            return new StreamGenerator(musicStreamFactory, musicCreator);
        }
    }
}
