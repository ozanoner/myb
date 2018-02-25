using System;

namespace e5
{
    class Nokta
    {
        // nokta koordinat degismeden hemen once
        public event EventHandler<EventArgs> NoktaDegismekUzere;
        // nokta koordinat degistikten sonra
        public event EventHandler<EventArgs> NoktaDegisti;

        protected int _X, _Y;
        public int X
        {
            get { return this._X; }
            set
            {
                this.NoktaDegismekUzere?.Invoke(this, new EventArgs());
                this._X = value;
                this.NoktaDegisti?.Invoke(this, new EventArgs());
            }
        }
        public int Y
        {
            get { return this._Y; }
            set
            {
                this.NoktaDegismekUzere?.Invoke(this, new EventArgs());
                this._Y = value;
                this.NoktaDegisti?.Invoke(this, new EventArgs());
            }
        }

        public override string ToString()
        {
            return $"Nokta(X={X},Y={Y})";
        }
    }
}
