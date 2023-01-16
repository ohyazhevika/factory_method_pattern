using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_4_factory_method
{
    public interface SongInstrumentFactory
    {
        WindInstrument CreateWindInstrument();
        StringInstrument CreateStringInstrument();
        KeyboardInstrument CreateKeyBoardInstrument();
        Percussion CreatePercussion();
        public Percussion CreateNullPercussion()
        {
            return new NullPercussion();
        }
    }

    public class RockSongInstrumentFactory: SongInstrumentFactory
    {
        public WindInstrument CreateWindInstrument()
        {
            return new Harmonica();
        }
        public StringInstrument CreateStringInstrument()
        {
            return new BassGuitar();
        }
        public KeyboardInstrument CreateKeyBoardInstrument()
        {
            return new Synthesizer();
        }
        public Percussion CreatePercussion()
        {
            return new Drums();
        }
        
    }
    public class ClassicSongInstrumentFactory : SongInstrumentFactory
    {
        public WindInstrument CreateWindInstrument()
        {
            return new Flute();
        }
        public StringInstrument CreateStringInstrument()
        {
            return new Violin();
        }
        public KeyboardInstrument CreateKeyBoardInstrument()
        {
            return new Piano();
        }
        public Percussion CreatePercussion()
        {
            return new Tambourine();
        }
    }
}
