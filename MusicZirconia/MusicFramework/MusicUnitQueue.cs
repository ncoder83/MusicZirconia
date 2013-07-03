using MusicZirconia.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MusicFramework
{
    public class MusicUnitMap
    {
        public Dictionary<int, MusicUnit> map;

        public MusicUnitMap(Dictionary<int, MusicUnit> map)
        {
            this.map = map;
        }

        public int Count { get { return map.Count; } }

        public bool IsEmpty { get { return map.Count == 0; } }

        public void Add(MusicUnit musicUnit)
        {
            if (map.ContainsKey(musicUnit.Tick))
            {
                MusicUnit musicUnit2 = null;
                map.TryGetValue(musicUnit.Tick, out musicUnit2);
                musicUnit2.Union(musicUnit);
            }
            else
                map.Add(musicUnit.Tick, musicUnit);
        }

        public MusicUnit Get(int tick)
        {
            if (!map.ContainsKey(tick))
                return null;
            MusicUnit musicUnit;
            map.TryGetValue(tick, out musicUnit);
            return musicUnit;
        }
    }
}
