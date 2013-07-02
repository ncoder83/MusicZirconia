using MusicGenerator.MusicFramework.TheoryFramework;
using System.Collections.Generic;

namespace MusicGenerator.MusicFramework
{
    public class MusicUnit
    {
        public readonly int Tick;
        public readonly Chord ChordOn;
        public readonly Chord ChordOff;
        public readonly double Sustainlevel;

        public MusicUnit(int tick, Chord chordOn, Chord chordOff, double sustainlevel)
        {
            this.Tick = tick;
            this.ChordOn = chordOn;
            this.ChordOff = chordOff;
            this.Sustainlevel = sustainlevel;
        }
    }

    public class MusicUnitTickComparer : IComparer<MusicUnit>
    {
        public int Compare(MusicUnit mu1, MusicUnit mu2)
        {
            return mu1.Tick - mu2.Tick;
        }
    }
}
