using System;

namespace jamik.csharp.types
{
    public class Cow3
    {
        int mooCount;
        Udder udder;
        public Cow3()
        {
            udder = new Udder();
        }
    }

    class Udder
    {
        int numTeets;
        Double ouncesOfMilk;
    }
}
