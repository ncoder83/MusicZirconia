using MusicGenerator.MusicGeneration;
using MusicGenerator.MusicPlaying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
