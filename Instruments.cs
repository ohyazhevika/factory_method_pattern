using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_4_factory_method
{
    public abstract class StringInstrument
    {

    }
    public class BassGuitar : StringInstrument
    {
        public override string ToString()
        {
            return "bass-guitar";
        }
    }
    public class Violin : StringInstrument
    {
        public override string ToString()
        {
            return "violin";
        }
    }
    public abstract class KeyboardInstrument
    {

    }

    public class Synthesizer : KeyboardInstrument
    {
        public override string ToString()
        {
            return "synthesizer";
        }
    }
    public class Piano : KeyboardInstrument
    {
        public override string ToString()
        {
            return "piano";
        }
    }
    public abstract class WindInstrument
    {

    }
    public class Harmonica : WindInstrument
    {
        public override string ToString()
        {
            return "harmonica";
        }
    }
    public class Flute : WindInstrument
    {
        public override string ToString()
        {
            return "flute";
        }
    }
    public abstract class Percussion
    {

    }
    public class Drums : Percussion
    {
        public override string ToString()
        {
            return "drums";

        }
    }
    public class Tambourine : Percussion
    {
        public override string ToString()
        {
            return "tambourine";

        }
    }
    public class NullPercussion : Percussion
    {
        public override string ToString()
        {
            return "";
        }
    }
}
