using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.MusicFramework.TheoryFramework
{
    public class Chord
    {
        private List<Note> notes;
        public IEnumerable<Note> Notes { get { return notes; } }

        public Chord(List<Note> notes)
        {
            this.notes = notes;
        }

        public void Add(Note note)
        {
            notes.Add(note);
        }
    }
}
