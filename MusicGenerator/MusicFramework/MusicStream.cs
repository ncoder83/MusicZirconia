using MusicGenerator.Common;
using MusicGenerator.MusicFramework.TheoryFramework;
using System.Collections.Generic;

namespace MusicGenerator.MusicFramework
{

    public class MusicStream
    {
        private int tick;
        private PriorityQueue<MusicUnit> musicUnitQueue;
        private ChordFactory chordFactory;

        public MusicStream(PriorityQueue<MusicUnit> musicUnitQueue, ChordFactory chordFactory)
        {
            this.musicUnitQueue = musicUnitQueue;
            this.chordFactory = chordFactory;
            tick = 0;
        }

        public bool IsEmpty { get { return musicUnitQueue.IsEmpty; } }

        public void PlayNotes(params Note[] notes)
        {
            Chord chord = chordFactory.GetChord(notes);
            musicUnitQueue.Enqueue(new MusicUnit(tick, chordFactory.GetChord(notes), chordFactory.GetEmptyChord(), -1));
            foreach(Note note in notes)
            {
                musicUnitQueue.Enqueue(new MusicUnit(tick + note.Duration - 1, chordFactory.GetEmptyChord(), chordFactory.GetChord(note), -1));
            }
        }

        public void Sustain()
        {
             musicUnitQueue.Enqueue(new MusicUnit(tick, chordFactory.GetEmptyChord(), chordFactory.GetEmptyChord(), 1));
        }

        public void ReleaseSustain()
        {
            musicUnitQueue.Enqueue(new MusicUnit(tick, chordFactory.GetEmptyChord(), chordFactory.GetEmptyChord(), 0));
        }

        public void IncrementTick(Duration duration)
        {
            IncrementTick((int)duration);
        }

        public void IncrementTick(int duration)
        {
            tick += duration;
        }

        public void Reset()
        {
            tick = 0;
        }

        public MusicUnit GetMusicUnit()
        {
            while (!musicUnitQueue.IsEmpty && musicUnitQueue.Peek().Tick < tick)
                musicUnitQueue.Dequeue();

            if (musicUnitQueue.IsEmpty || tick != musicUnitQueue.Peek().Tick)
                return null;

            List<MusicUnit> musicUnitList = new List<MusicUnit>();
            while (!musicUnitQueue.IsEmpty && musicUnitQueue.Peek().Tick == tick)
                musicUnitList.Add(musicUnitQueue.Dequeue());

            if (musicUnitList.Count == 0)
                return null;
            if (musicUnitList.Count == 1)
                return musicUnitList[0];
            MusicUnit musicUnit = musicUnitList[0];
            for (int i = 1; i < musicUnitList.Count; i++)
                musicUnit = MusicHelper.Instance.Union(musicUnit, musicUnitList[i]);

            return musicUnit;
        }
    }
}
