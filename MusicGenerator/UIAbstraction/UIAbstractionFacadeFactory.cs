using MusicZirconia.MusicGeneration;
using MusicZirconia.MusicPlaying;

namespace MusicGenerator.UIAbstraction
{
    public class UIAbstractionFacadeFactory
    {
        public UIAbstractionFacade getUIAbstractionFacade()
        {
            StreamGenerator musicGenerator = new StreamGeneratorFactory().GetStreamGenerator();
            MusicPlayingFacade musicPlayingFacade = new MusicPlayingFacadeFactory(musicGenerator).getMusicPlayingFacade();
            return new UIAbstractionFacade(musicGenerator, musicPlayingFacade);
        }
    }
}
