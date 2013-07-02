using Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.MidiIntegration.MidiSignals
{
    public interface MidiSignal
    {
        void Fire(OutputDevice outputDevice, Midi.Channel midiChannel);
    }
}
