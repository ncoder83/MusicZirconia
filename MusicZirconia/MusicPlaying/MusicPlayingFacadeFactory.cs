using MusicZirconia.MidiIntegration;
using MusicZirconia.MusicGeneration;

namespace MusicZirconia.MusicPlaying
{
    public class MusicPlayingFacadeFactory
    {
        private MusicGenerationFacade musicGenerationFacade;

        public MusicPlayingFacadeFactory(MusicGenerationFacade musicGenerationFacade)
        {
            this.musicGenerationFacade = musicGenerationFacade;
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
