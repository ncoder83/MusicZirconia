using MusicGenerator.Common;
using MusicGenerator.MusicFramework.TheoryFramework;
using System.Collections.Generic;

namespace MusicGenerator.MusicFramework
{
    public class MusicStreamFactory
    {
        public MusicStream GetMusicStream()
        {
            ChordFactory chordFactory = new ChordFactory();
            return new MusicStream(new PriorityQueue<MusicUnit>(new MusicUnitTickComparer()), chordFactory);
        }
    }
}
