using MusicGenerator.Common;
using MusicGenerator.MusicFramework.TheoryFramework;
using System.Collections.Generic;

namespace MusicGenerator.MusicFramework
{
    public class MusicStreamFactory
    {
        public MusicStream GetMusicStream()
        {
            MusicUnitFactory musicUnitFactory = new MusicUnitFactory();
            return new MusicStream(new MusicUnitMap(new Dictionary<int, MusicUnit>()), musicUnitFactory);
        }
    }
}
