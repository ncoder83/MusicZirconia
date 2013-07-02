using MusicGenerator.MusicGeneration.GeneratorFramework.PianoCreator;

namespace MusicGenerator.MusicGeneration.GeneratorFramework
{
    public class MusicCreatorFactory
    {
        public IMusicCreator GetDefaultPianoCreator()
        {
            return new DefaultPianoCreator();
        }
    }
}
