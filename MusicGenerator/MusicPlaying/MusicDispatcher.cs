using MusicGenerator.MidiIntegration;
using MusicGenerator.MusicFramework;
using MusicGenerator.MusicFramework.TheoryFramework;
using System.Timers;
using System;

namespace MusicGenerator.MusicPlaying
{
    public class MusicDispatcher
    {
        private MusicStream musicStream;
        private MidiIntegrationFacade midiIntegrationFacade;
        private Timer timer;

        public MusicDispatcher(MidiIntegrationFacade midiIntegrationFacade, MusicStream musicStream, Timer timer, int beatsPerMinute)
        {
            this.midiIntegrationFacade = midiIntegrationFacade;
            this.musicStream = musicStream;
            this.timer = timer;
            this.timer.Interval = 60000.0 / (Note.TicksPerBeat * beatsPerMinute);
            this.timer.Elapsed += new ElapsedEventHandler(OnTick);
        }

        public void start()
        {
            timer.Start();
        }

        public void OnTick(object sender, EventArgs args)
        {
            if (musicStream.IsEmpty)
            {
                stop();
                return;
            }

            MusicUnit musicUnit = musicStream.GetMusicUnit();
            musicStream.IncrementTick(1);
            if (musicUnit == null)
                return;

            if(musicUnit.Sustainlevel != -1)
                midiIntegrationFacade.SetSustain(musicUnit.Sustainlevel);

            foreach (Note note in musicUnit.ChordOff.Notes)
            {
                midiIntegrationFacade.NoteOff(note);
            }

            foreach(Note note in musicUnit.ChordOn.Notes)
            {
                midiIntegrationFacade.NoteOn(note);
            }
        }

        public void stop()
        {
            timer.Stop();
        }
    }
}
