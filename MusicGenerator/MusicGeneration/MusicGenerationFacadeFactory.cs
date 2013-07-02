using MusicGenerator.MusicGeneration.GeneratorFramework;
using MusicGenerator.MusicFramework;

namespace MusicGenerator.MusicGeneration
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
