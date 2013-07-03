using MusicZirconia.MusicFramework.TheoryFramework;
using MusicZirconia.Common; 
using System;

namespace MusicZirconia.MidiIntegration
{
    public class MidiHelper
    {
        public static MidiHelper Instance { get { return LazyHolder.MidiHelper; } }

        public Midi.Pitch GetMidiPitch(Note note)
        {
            return (Midi.Pitch)note.Pitch;
        }

        public int GetMidiVelocity(Note note)
        {
            return (int)(note.Velocity.Clamp(0, 1) * 127);
        }

        public int GetMidiSustain(double sustain)
        {
            return (int)(sustain.Clamp(0, 1) * 127);
        }

        private static class LazyHolder
        {
            private static MidiHelper midiHelper = new MidiHelper();
            public static MidiHelper MidiHelper { get { return midiHelper; } }
        }
    }
}
