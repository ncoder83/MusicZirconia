using MusicZirconia.MusicFramework.TheoryFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MidiIntegration.MidiSignals
{
    public class NoteOffSignal : MidiSignal
    {
        private readonly Midi.Pitch pitch;
        private readonly int velocity;

        public NoteOffSignal(Note note)
        {
            this.pitch = MidiHelper.Instance.GetMidiPitch(note);
            this.velocity = MidiHelper.Instance.GetMidiVelocity(note);
        }

        public void Fire(Midi.OutputDevice outputDevice, Midi.Channel midiChannel)
        {
            outputDevice.SendNoteOff(midiChannel, pitch, velocity);
        }
    }
}
