using MusicGenerator.GenerationFramework;
using MusicZirconia.MusicGeneration;
using MusicZirconia.MusicPlaying;

namespace MusicGenerator.UIAbstraction
{
    public class UIAbstractionFacadeFactory
    {
        public UIAbstractionFacade getUIAbstractionFacade()
        {
            DefaultPianoCreator pianoCreator = new DefaultPianoCreator();
            StreamGenerator musicGenerator = new StreamGeneratorFactory().GetStreamGenerator(pianoCreator);
            MusicPlayingFacade musicPlayingFacade = new MusicPlayingFacadeFactory(musicGenerator).getMusicPlayingFacade();
            return new UIAbstractionFacade(musicGenerator, musicPlayingFacade);
        }
    }
}
