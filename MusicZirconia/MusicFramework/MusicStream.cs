using MusicZirconia.Common;
using MusicZirconia.MidiIntegration.MidiSignals;
using MusicZirconia.MusicFramework.MusicStructures;
using System;
using System.Collections.Generic;

namespace MusicZirconia.MusicFramework
{

    public class MusicStream
    {
        private int tick;
        private MusicUnitMap musicUnitMap;
        private MusicUnitFactory musicUnitFactory;

        public MusicStream(MusicUnitMap musicUnitMap, MusicUnitFactory musicUnitFactory)
        {
            this.musicUnitMap = musicUnitMap;
            this.musicUnitFactory = musicUnitFactory;
            tick = 4;
        }

        public bool IsEmpty { get { return musicUnitMap.IsEmpty; } }

        public void PlayNotes(params Note[] notes)
        {
            MusicUnit noteOn = musicUnitFactory.GetMusicUnit(tick);
            foreach(Note note in notes)
            {
                musicUnitMap.Add(musicUnitFactory.GetMusicUnit(tick, new NoteOnSignal(note)));
                musicUnitMap.Add(musicUnitFactory.GetMusicUnit(tick + note.Duration - 1, new NoteOffSignal(note)));
            }
        }

        public void SendSignal(MidiSignal signal)
        {
            musicUnitMap.Add(musicUnitFactory.GetMusicUnit(tick, signal));
        }

        public void SendDelayedSignal(MidiSignal signal, Duration duration)
        {
            SendDelayedSignal(signal, (int)duration);
        }

        public void SendDelayedSignal(MidiSignal signal, int duration)
        {
            musicUnitMap.Add(musicUnitFactory.GetMusicUnit(tick + duration - 1, signal));
        }

        public void Sustain()
        {
            musicUnitMap.Add(musicUnitFactory.GetMusicUnit(tick, new SustainSignal(1)));
        }

        public void ReleaseSustain()
        {
            musicUnitMap.Add(musicUnitFactory.GetMusicUnit(tick, new SustainSignal(0)));
        }

        public void IncrementTick(Duration duration)
        {
            IncrementTick((int)duration);
        }

        public void IncrementTick(int duration)
        {
            tick += duration;
        }

        public void DecrementTick(Duration duration)
        {
            DecrementTick((int)duration);
        }

        public void DecrementTick(int duration)
        {
            tick -= duration;
            tick = Math.Max(tick, 0);
        }

        public void Reset()
        {
            tick = 4;
        }

        public MusicUnit GetMusicUnit()
        {
            return musicUnitMap.Get(tick);
        }
    }
}
