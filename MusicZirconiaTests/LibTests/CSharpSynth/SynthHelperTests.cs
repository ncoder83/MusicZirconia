using CSharpSynth.Synthesis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGeneratorTests.LibTests.CSharpSynth
{
    [TestClass()]
    public class SynthHelperTests
    {
        [TestMethod()]
        public void SynthHelperTest()
        {
            Assert.AreEqual(13, SynthHelper.StringToNote("C#0"));
            Assert.AreEqual("C#0", SynthHelper.NoteToString(13));
            Assert.AreEqual(1, SynthHelper.StringToNote("C#-1"));
        }
    }
}
