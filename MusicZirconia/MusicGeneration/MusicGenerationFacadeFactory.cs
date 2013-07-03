using MusicZirconia.MusicGeneration.GeneratorFramework;
using MusicZirconia.MusicFramework;

namespace MusicZirconia.MusicGeneration
{
    public class MusicGenerationFacadeFactory
    {
        public MusicGenerationFacade getMusicGenerationFacade()
        {
            MusicStreamFactory musicStreamFactory = new MusicStreamFactory();
            MusicCreatorFactory musicCreatorFactory = new MusicCreatorFactory();
            MusicGenerator musicGenerator = new MusicGenerator(musicStreamFactory, musicCreatorFactory.GetDefaultPianoCreator());
            return new MusicGenerationFacade(musicGenerator);
        }
    }
}
