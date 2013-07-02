using MusicGenerator.MusicFramework.TheoryFramework;
using System;
using System.Collections.Generic;

namespace MusicGenerator.MusicFramework
{
    public class MusicHelper
    {
        public static MusicHelper Instance { get { return LazyHolder.ChordHelper; } }

        public MusicUnit Union(MusicUnit mu1, MusicUnit mu2)
        {
            if (!Unionable(mu1, mu2))
                throw new InvalidOperationException("Cannot union two music units with different ticks");

            List<Note> noteOnList = new List<Note>();
            List<Note> noteOffList = new List<Note>();

            foreach(Note note in mu1.ChordOn.Notes)
                noteOnList.Add(note);
            foreach(Note note in mu2.ChordOn.Notes)
                noteOnList.Add(note);
            foreach(Note note in mu1.ChordOff.Notes)
                noteOffList.Add(note);
            foreach(Note note in mu2.ChordOff.Notes)
                noteOffList.Add(note);

            Chord chordOn = new Chord(noteOnList);
            Chord chordOff = new Chord(noteOffList);

            double sustainLevel = Math.Max(mu1.Sustainlevel, mu2.Sustainlevel);

            return new MusicUnit(mu1.Tick, chordOn, chordOff, sustainLevel);
        }

        public bool Unionable(MusicUnit mu1, MusicUnit mu2)
        {
            return mu1.Tick == mu2.Tick;
        }

        public Note Union(Note note1, Note note2)
        {
            if (!Unionable(note1, note2))
                throw new InvalidOperationException("Cannot union two notes with different keys/octaves");

            double velocity = Math.Max(note1.Velocity, note2.Velocity);
            int duration = Math.Max(note1.Duration, note2.Duration);
            return new Note(note1.Pitch, velocity, duration);
        }

        public bool Unionable(Note note1, Note note2)
        {
            return note1.Pitch == note2.Pitch;
        }

        private static class LazyHolder
        {
            private static MusicHelper chordHelper = new MusicHelper();
            public static MusicHelper ChordHelper { get { return chordHelper; } }
        }
    }
}
