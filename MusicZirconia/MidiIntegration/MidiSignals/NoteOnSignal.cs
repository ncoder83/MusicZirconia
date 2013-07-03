using MusicZirconia.MusicFramework.MusicStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MidiIntegration.MidiSignals
{
    public class NoteOnSignal : IMidiSignal
    {
        private readonly Midi.Pitch pitch;
        private readonly int velocity;

        public NoteOnSignal(Note note)
        {
            this.pitch = MidiHelper.Instance.GetMidiPitch(note);
            this.velocity = MidiHelper.Instance.GetMidiVelocity(note);
        }

        public void Fire(Midi.OutputDevice outputDevice, Midi.Channel midiChannel)
        {
            outputDevice.SendNoteOn(midiChannel, pitch, velocity);
        }
    }
}
