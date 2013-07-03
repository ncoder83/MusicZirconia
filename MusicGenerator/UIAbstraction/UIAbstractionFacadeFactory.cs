using MusicZirconia.MusicGeneration;
using MusicZirconia.MusicPlaying;

namespace MusicGenerator.UIAbstraction
{
    public class UIAbstractionFacadeFactory
    {
        public UIAbstractionFacade getUIAbstractionFacade()
        {
            MusicGenerationFacade  musicGenerationFacade = new MusicGenerationFacadeFactory().getMusicGenerationFacade();
            MusicPlayingFacade musicPlayingFacade = new MusicPlayingFacadeFactory(musicGenerationFacade).getMusicPlayingFacade();
            return new UIAbstractionFacade(musicGenerationFacade, musicPlayingFacade);
        }
    }
}
