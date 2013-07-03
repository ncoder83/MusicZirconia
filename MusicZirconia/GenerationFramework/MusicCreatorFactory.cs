using MusicZirconia.GenerationFramework;

namespace MusicZirconia.GenerationFramework
{
    public class MusicCreatorFactory
    {
        public IMusicCreator GetDefaultPianoCreator()
        {
            return new DefaultPianoCreator();
        }
    }
}
