using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_4_factory_method
{
    public abstract class Song
    {
        public String name { get; set; }
        public WindInstrument windInstrument;
        public StringInstrument stringInstrument;
        public KeyboardInstrument keyboardInstrument;
        public Percussion percussion;

        public void PlayVerse(int number)
        {
            Console.WriteLine($"PLaying the verse number {number}...\n");
        }
        public void PlayChorus()
        {
            Console.WriteLine("PLaying the chorus...\n");
        }
        public void BowToTheAudience()
        {
            Console.WriteLine($"{windInstrument} {stringInstrument} {percussion} and {keyboardInstrument} players are bowing to the audience...\n");
        }
        public abstract void FormBand();
    }

    public class HappyNewYear : Song
    {
        SongInstrumentFactory instrumentFactory;
        public HappyNewYear(SongInstrumentFactory instFactory)
        {
            instrumentFactory = instFactory;
        }
        public override void FormBand()
        {
            Console.WriteLine($"Forming a band for {name}\n");
            windInstrument = instrumentFactory.CreateWindInstrument();
            stringInstrument = instrumentFactory.CreateStringInstrument();
            keyboardInstrument = instrumentFactory.CreateKeyBoardInstrument();
            percussion = instrumentFactory.CreatePercussion();
        }
    }

    public class HeyJude : Song
    {
        SongInstrumentFactory instrumentFactory;
        public HeyJude (SongInstrumentFactory instFactory)
        {
            instrumentFactory = instFactory;
        }
        public override void FormBand()
        {
            Console.WriteLine($"Forming a band for {name}\n");
            windInstrument = instrumentFactory.CreateWindInstrument();
            stringInstrument = instrumentFactory.CreateStringInstrument();
            keyboardInstrument = instrumentFactory.CreateKeyBoardInstrument();
            percussion = instrumentFactory.CreateNullPercussion();
        }
    }
}

