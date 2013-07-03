using MusicZirconia.MusicGeneration.GeneratorFramework.PianoCreator;

namespace MusicZirconia.MusicGeneration.GeneratorFramework
{
    public class MusicCreatorFactory
    {
        public IMusicCreator GetDefaultPianoCreator()
        {
            return new DefaultPianoCreator();
        }
    }
}
