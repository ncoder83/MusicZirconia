using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.MidiIntegration
{
    public class MidiIntegrationFacadeFactory
    {
        public MidiIntegrationFacade getMidiIntegrationFacade()
        {
            Midi.OutputDevice outputDevice = Midi.OutputDevice.InstalledDevices[0];
            outputDevice.Open();
            return new MidiIntegrationFacade(outputDevice);
        }
    }
}
