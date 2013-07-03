using MusicZirconia.MidiIntegration;
using MusicZirconia.MusicFramework;
using System.Timers;

namespace MusicZirconia.MusicPlaying
{
    public class MusicDispatcherFactory
    {
        MidiIntegrationFacade midiIntegrationFacade;

        public MusicDispatcherFactory(MidiIntegrationFacade midiIntegrationFacade)
        {
            this.midiIntegrationFacade = midiIntegrationFacade;
        }

        public MusicDispatcher GetMusicDispatcher(MusicStream musicStream, int beatsPerMinute)
        {
            return new MusicDispatcher(midiIntegrationFacade, musicStream, new Timer(), beatsPerMinute);
        }
    }
}
