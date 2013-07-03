using MusicZirconia.MusicFramework;
using MusicZirconia.MusicGeneration;
using MusicZirconia.MusicPlaying;

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
