using MusicZirconia.MidiIntegration.MidiSignals;
using MusicZirconia.MusicFramework.TheoryFramework;

namespace MusicZirconia.MidiIntegration
{
    public class MidiIntegrationFacade
    {
        private const Midi.Channel midiChannel = Midi.Channel.Channel1;
        private Midi.OutputDevice outputDevice;

        public MidiIntegrationFacade(Midi.OutputDevice outputDevice)
        {
            this.outputDevice = outputDevice;
        }

        public void FireSignal(MidiSignal signal)
        {
            signal.Fire(outputDevice, midiChannel);
        }
    }
}
