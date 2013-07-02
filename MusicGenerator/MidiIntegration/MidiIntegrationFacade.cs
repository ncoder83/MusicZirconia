using MusicGenerator.MusicFramework.TheoryFramework;

namespace MusicGenerator.MidiIntegration
{
    public class MidiIntegrationFacade
    {
        private const Midi.Channel midiChannel = Midi.Channel.Channel1;
        private Midi.OutputDevice outputDevice;

        public MidiIntegrationFacade(Midi.OutputDevice outputDevice)
        {
            this.outputDevice = outputDevice;
        }

        public void NoteOn(Note note)
        {
            outputDevice.SendNoteOn(midiChannel, MidiHelper.Instance.GetMidiPitch(note), MidiHelper.Instance.GetMidiVelocity(note));
        }

        public void NoteOff(Note note)
        {
            outputDevice.SendNoteOff(midiChannel, MidiHelper.Instance.GetMidiPitch(note), MidiHelper.Instance.GetMidiVelocity(note));
        }

        public void SetSustain(double value)
        {
            outputDevice.SendControlChange(Midi.Channel.Channel1, Midi.Control.SustainPedal, MidiHelper.Instance.GetMidiSustain(value));
        }
    }
}
