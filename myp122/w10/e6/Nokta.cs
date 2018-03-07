using System;

namespace e6
{
    class Nokta
    {
        // nokta koordinat degistikten sonra
        public event EventHandler<NoktaDegistiEventArgs> NoktaDegisti;

        protected int _X, _Y;
        public int X
        {
            get { return this._X; }
            set
            {
                NoktaDegistiEventArgs e = new NoktaDegistiEventArgs(this);
                this._X = value;
                e.SonrakiX = this._X;
                this.NoktaDegisti?.Invoke(this, e);
            }
        }
        public int Y
        {
            get { return this._Y; }
            set
            {
                NoktaDegistiEventArgs e = new NoktaDegistiEventArgs()
                {
                    OncekiX = this._X,
                    OncekiY = this._Y,
                    SonrakiX = this._X,
                    SonrakiY = this._Y
                };
                this._Y = value;
                e.SonrakiY = this._Y;
                this.NoktaDegisti?.Invoke(this, e);
            }
        }

        public override string ToString()
        {
            return $"Nokta(X={X},Y={Y})";
        }
    }
}
