using System;

namespace e6
{
    class NoktaDegistiEventArgs: EventArgs
    {
        public NoktaDegistiEventArgs() { }
        public NoktaDegistiEventArgs(Nokta n)
        {
            this.OncekiX = this.SonrakiX = n.X;
            this.OncekiY = this.SonrakiY = n.Y;
        }
        public int OncekiX { get; set; }
        public int OncekiY { get; set; }
        public int SonrakiX { get; set; }
        public int SonrakiY { get; set; }
    }
}
