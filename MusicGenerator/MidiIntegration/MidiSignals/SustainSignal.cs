using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.MidiIntegration.MidiSignals
{
    class SustainSignal : MidiSignal
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
