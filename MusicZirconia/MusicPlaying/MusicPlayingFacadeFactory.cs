using MusicZirconia.MidiIntegration;
using MusicZirconia.MusicGeneration;

namespace MusicZirconia.MusicPlaying
{
    public class MusicPlayingFacadeFactory
    {
        private StreamGenerator musicGenerator;

        public MusicPlayingFacadeFactory(StreamGenerator musicGenerator)
        {
            this.musicGenerator = musicGenerator;
        }

        public MusicPlayingFacade getMusicPlayingFacade()
        {
            MidiIntegrationFacade midiIntegrationFacade = new MidiIntegrationFacadeFactory().getMidiIntegrationFacade();
            MusicDispatcherFactory musicDispatcherFactory = new MusicDispatcherFactory(midiIntegrationFacade);
            MusicPlayer musicPlayer = new MusicPlayer(musicDispatcherFactory);
            return new MusicPlayingFacade(musicPlayer);
        }
    }
}
