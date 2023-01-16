using System;

namespace OOAP_4_factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            CafeLiveMusic milanoLiveMusic = new MilanoCafeLiveMusic();
            milanoLiveMusic.OrderSong(SongNames.HappyNewYear);

            CafeLiveMusic rockDevilLiveMusic = new RockDevilBarLiveMusic();
            rockDevilLiveMusic.OrderSong(SongNames.HappyNewYear);

            milanoLiveMusic.OrderSong(SongNames.HeyJude);

            rockDevilLiveMusic.OrderSong(SongNames.HeyJude);
        }
    }
}
