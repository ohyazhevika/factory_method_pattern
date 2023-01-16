using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_4_factory_method
{
    public abstract class CafeLiveMusic
    {
        public Song OrderSong(SongNames name)
        {
            Console.WriteLine("******************************");
            Song song = GetNewSong(name);
            song.FormBand();
            song.PlayVerse(1);
            song.PlayChorus();
            song.PlayVerse(2);
            song.BowToTheAudience();

            return song;
        }
        protected abstract Song GetNewSong(SongNames name);
    }

    public class MilanoCafeLiveMusic: CafeLiveMusic
    {
        protected override Song GetNewSong(SongNames name)
        {
            Song song = null;
            SongInstrumentFactory instrumentFactory = new ClassicSongInstrumentFactory();
            if(name==SongNames.HappyNewYear)
            {
                song = new HappyNewYear(instrumentFactory);
                song.name = "Happy New Year, Milano Cafe classical instrumentation";
            }
            else if (name == SongNames.HeyJude)
            {
                song = new HeyJude(instrumentFactory);
                song.name = "Hey Jude, Milano Cafe classical instrumentation";
            }
            return song;
        }
    }
    public class RockDevilBarLiveMusic : CafeLiveMusic
    {
        protected override Song GetNewSong(SongNames name)
        {
            Song song = null;
            SongInstrumentFactory instrumentFactory = new RockSongInstrumentFactory();
            if (name == SongNames.HappyNewYear)
            {
                song = new HappyNewYear(instrumentFactory);
                song.name = "Happy New Year, RockDevil Bar rock instrumentation";
            }
            else if (name == SongNames.HeyJude)
            {
                song = new HeyJude(instrumentFactory);
                song.name = "Hey Jude, RockDevil Bar rock instrumentation";
            }
            return song;
        }
    }

}
