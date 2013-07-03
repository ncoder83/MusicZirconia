using MusicZirconia.MidiIntegration;
using MusicZirconia.MusicFramework;
using MusicZirconia.MusicFramework.MusicStructures;
using System.Timers;
using System;
using MusicZirconia.MidiIntegration.MidiSignals;

namespace MusicZirconia.MusicPlaying
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

            foreach(MidiSignal signal in musicUnit.Signals)
            {
                midiIntegrationFacade.FireSignal(signal);
            }
        }

        public void stop()
        {
            timer.Stop();
        }
    }
}
