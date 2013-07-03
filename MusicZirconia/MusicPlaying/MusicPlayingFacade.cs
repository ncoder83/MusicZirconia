using MusicZirconia.MusicFramework;

namespace MusicZirconia.MusicPlaying
{
    public class MusicPlayingFacade
    {
        private MusicPlayer musicPlayer;
        public MusicPlayingFacade(MusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }

        public void play(MusicStream musicStream)
        {
            musicPlayer.play(musicStream);
        }

        public void pause()
        {
            musicPlayer.pause();
        }
    }
}
