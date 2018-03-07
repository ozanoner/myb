using System;

namespace e4
{
    class Nokta
    {
        // Olay tanimi.
        // Baska birisi bu olay olustugunda cagrilmak uzere
        // EventHandler<EventArgs> tipinde delegate method ekleyebilir
        public event EventHandler<EventArgs> NoktaDegisti;

        protected int _X, _Y;
        public int X
        {
            get { return this._X; }
            set
            {
                this._X = value;
                // NoktaDegisti'ye method eklenmisse onu calistirir.
                this.NoktaDegisti?.Invoke(this, new EventArgs());
            }
        }
        public int Y
        {
            get { return this._Y; }
            set
            {
                this._Y = value;
                this.NoktaDegisti?.Invoke(this, new EventArgs());
            }
        }
    }
}
