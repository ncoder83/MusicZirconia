using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicZirconia.MusicFramework.TheoryFramework
{
    public enum Key
    {
        CFlatFlat = -2,
        CFlat = -1,
        C = 0,
        CSharp = 1,
        CSharpSharp = 2,
        DFlatFlat = 0,
        DFlat = 1,
        D = 2,
        DSharp = 3,
        DSharpSharp = 4,
        EFlatFlat = 2,
        EFlat = 3,
        E = 4,
        ESharp = 5,
        ESharpSharp,
        FFlatFlat = 3,
        FFlat = 4,
        F = 5,
        FSharp = 6,
        FSharpSharp = 7,
        GFlatFlat = 5,
        GFlat = 6,
        G = 7,
        GSharp = 8,
        GSharpSharp = 9,
        AFlatFlat = 7,
        AFlat = 8,
        A = 9,
        ASharp = 10,
        ASharpSharp = 11,
        BFlatFlat = 9,
        BFlat = 10,
        B = 11,
        BSharp = 12,
        BSharpSharp = 13
    }
    
    public static class KeyExtensions
    {
        private static readonly KeyExtensionsLogic keyExtensionsLogic = new KeyExtensionsLogic();

        public static Pitch Pitch(this Key key, int octave)
        {
            return keyExtensionsLogic.Pitch(key, octave);
        }

        public class KeyExtensionsLogic
        {
            public Pitch Pitch(Key key, int octave)
            {
                int val = ((octave + 1) * 12 + (int)key);
                if (val < 0 || val > 127)
                    throw new Exception(String.Format("Key: {0}{1} out of range", val, octave));
                return (Pitch)val;
            }
        }   
    }
}
