using MusicGenerator.MusicGeneration;
using MusicGenerator.MusicFramework;
using MusicGenerator.MusicPlaying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.UIAbstraction
{
    public class UIAbstractionFacade
    {
        private MusicGenerationFacade musicGenerationFacade;
        private MusicPlayingFacade musicPlayingFacade;
        private MusicStream musicStream;

        public UIAbstractionFacade(MusicGenerationFacade musicGenerationFacade, MusicPlayingFacade musicPlayingFacade){
            this.musicGenerationFacade = musicGenerationFacade;
            this.musicPlayingFacade = musicPlayingFacade;
            this.musicStream = null;
        }

        public void play()
        {
            if (musicStream == null || musicStream.IsEmpty)
                musicStream = musicGenerationFacade.Generate();

            musicPlayingFacade.play(musicStream);
        }

        public void pause()
        {
            musicPlayingFacade.pause();
        }
    }
}
