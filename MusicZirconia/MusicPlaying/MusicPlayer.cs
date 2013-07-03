using MusicZirconia.MusicFramework;

namespace MusicZirconia.MusicPlaying
{
    public class MusicPlayer
    {
        private MusicDispatcherFactory musicDispatcherFactory;
        private MusicDispatcher musicDispatcher;

        public MusicPlayer(MusicDispatcherFactory musicDispatcherFactory)
        {
            this.musicDispatcherFactory = musicDispatcherFactory;
        }

        public void play(MusicStream musicStream)
        {
            MusicDispatcher musicDispatcher = musicDispatcherFactory.GetMusicDispatcher(musicStream, 120);
            musicDispatcher.start();
        }

        public void pause()
        {
            if (this.musicDispatcher == null)
                return;
            musicDispatcher.stop();
            musicDispatcher = null;
        }
    }
}
