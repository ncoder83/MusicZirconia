using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.MusicFramework.TheoryFramework
{
    public class ChordFactory
    {
        private Chord emtpyChord = new Chord(new List<Note>());

        public Chord GetEmptyChord()
        {
            return emtpyChord;
        }

        public Chord GetChord(params Note[] notes)
        {
            return new Chord(new List<Note>(notes));
        }
    }
}
