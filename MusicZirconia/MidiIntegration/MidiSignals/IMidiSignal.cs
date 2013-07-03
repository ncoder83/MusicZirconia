using Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MidiIntegration.MidiSignals
{
    public interface IMidiSignal
    {
        void Fire(OutputDevice outputDevice, Midi.Channel midiChannel);
    }
}
