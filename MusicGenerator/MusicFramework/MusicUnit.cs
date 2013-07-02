using MusicGenerator.MidiIntegration.MidiSignals;
using MusicGenerator.MusicFramework.TheoryFramework;
using System;
using System.Collections.Generic;

namespace MusicGenerator.MusicFramework
{
    public class MusicUnit : IComparable<MusicUnit>
    {
        public readonly int Tick;
        private List<MidiSignal> midiSignals;

        public IEnumerable<MidiSignal> Signals { get { return midiSignals; } }

        public MusicUnit(int tick, List<MidiSignal> midiSignals)
        {
            this.Tick = tick;
            this.midiSignals = midiSignals;
        }

        public void AddSignal(MidiSignal signal)
        {
            this.midiSignals.Add(signal);
        }

        public void Union(MusicUnit other)
        {
            midiSignals.AddRange(other.Signals);
        }

        public int CompareTo(MusicUnit other)
        {
            return Tick - other.Tick;
        }
    }
}
