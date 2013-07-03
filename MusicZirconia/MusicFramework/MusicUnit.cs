using MusicZirconia.MidiIntegration.MidiSignals;
using MusicZirconia.MusicFramework.MusicStructures;
using System;
using System.Collections.Generic;

namespace MusicZirconia.MusicFramework
{
    public class MusicUnit : IComparable<MusicUnit>
    {
        public readonly int Tick;
        private List<IMidiSignal> midiSignals;

        public IEnumerable<IMidiSignal> Signals { get { return midiSignals; } }

        public MusicUnit(int tick, List<IMidiSignal> midiSignals)
        {
            this.Tick = tick;
            this.midiSignals = midiSignals;
        }

        public void AddSignal(IMidiSignal signal)
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
