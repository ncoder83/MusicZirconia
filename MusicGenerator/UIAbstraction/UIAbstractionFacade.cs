using MusicZirconia.MusicFramework;
using MusicZirconia.MusicGeneration;
using MusicZirconia.MusicPlaying;

namespace MusicGenerator.UIAbstraction
{
    public class UIAbstractionFacade
    {
        private StreamGenerator musicGenerator;
        private MusicPlayingFacade musicPlayingFacade;
        private MusicStream musicStream;

        public UIAbstractionFacade(StreamGenerator musicGenerator, MusicPlayingFacade musicPlayingFacade)
        {
            this.musicGenerator = musicGenerator;
            this.musicPlayingFacade = musicPlayingFacade;
            this.musicStream = null;
        }

        public void play()
        {
            if (musicStream == null || musicStream.IsEmpty)
                musicStream = musicGenerator.Generate();

            musicPlayingFacade.play(musicStream);
        }

        public void pause()
        {
            musicPlayingFacade.pause();
        }
    }
}
