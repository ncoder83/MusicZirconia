using MusicZirconia.Common;
using MusicZirconia.MusicFramework.TheoryFramework;
using System.Collections.Generic;

namespace MusicZirconia.MusicFramework
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
