using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MusicFramework.TheoryFramework
{
    public class Note
    {
        public const int TicksPerBeat = 8;

        public readonly Pitch Pitch;
        public readonly int Duration;
        public readonly double Velocity;

        public Note(Key key, int octave, double velocity)
            : this(key.Pitch(octave), velocity)
        {
        }

        public Note(Pitch pitch, double velocity)
            : this(pitch, velocity, 0)
        {
        }

        public Note(Key key, int octave, double velocity, Duration duration)
            : this(key.Pitch(octave), velocity, duration)
        {
        }

        public Note(Pitch pitch, double velocity, Duration duration)
            : this(pitch, velocity, (int) duration)
        {
        }

        public Note(Key key, int octave, double velocity, int duration)
            : this(key.Pitch(octave), velocity, duration)
        {
        }

        public Note(Pitch pitch, double velocity, int duration)
        {
            this.Pitch = pitch;
            this.Duration = duration;
            this.Velocity = velocity;
        }
    }
}
