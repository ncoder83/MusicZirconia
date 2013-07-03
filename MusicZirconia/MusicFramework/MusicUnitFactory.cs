using MusicZirconia.MidiIntegration.MidiSignals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MusicFramework
{
    public class MusicUnitFactory
    {
        public MusicUnit GetMusicUnit(int tick, params MidiSignal[] signals)
        {
            return new MusicUnit(tick, new List<MidiSignal>(signals));
        }
    }
}
