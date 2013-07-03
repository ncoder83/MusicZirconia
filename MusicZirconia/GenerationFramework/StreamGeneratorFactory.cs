using MusicZirconia.GenerationFramework;
using MusicZirconia.MusicFramework;

namespace MusicZirconia.MusicGeneration
{
    public class StreamGeneratorFactory
    {
        public StreamGenerator GetStreamGenerator()
        {
            MusicStreamFactory musicStreamFactory = new MusicStreamFactory();
            MusicCreatorFactory musicCreatorFactory = new MusicCreatorFactory();
            return new StreamGenerator(musicStreamFactory, musicCreatorFactory.GetDefaultPianoCreator());
        }
    }
}
