using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MidiIntegration.MidiSignals
{
    class SustainSignal : IMidiSignal
    {
        private readonly int sustain;

        public SustainSignal(double sustain)
        {
            this.sustain = MidiHelper.Instance.GetMidiSustain(sustain);
        }

        public void Fire(Midi.OutputDevice outputDevice, Midi.Channel midiChannel)
        {
            outputDevice.SendControlChange(midiChannel, Midi.Control.SustainPedal, sustain);
        }
    }
}
