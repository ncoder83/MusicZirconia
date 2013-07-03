﻿using MusicZirconia.MusicFramework;

namespace MusicZirconia.MusicGeneration
{
    public class MusicGenerationFacade
    {
        private MusicGenerator musicGenerator;

        public MusicGenerationFacade(MusicGenerator musicGenerator)
        {
            this.musicGenerator = musicGenerator;
        }

        public MusicStream Generate()
        {
            return musicGenerator.Generate();
        }
    }
}