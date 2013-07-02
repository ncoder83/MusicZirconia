using MusicGenerator.MusicFramework;

namespace MusicGenerator.MusicPlaying
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
