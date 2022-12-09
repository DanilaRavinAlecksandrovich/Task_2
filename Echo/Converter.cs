using System;
using System.Collections.Generic;
using System.Text;

namespace Danila_2.Echo
{
    class Converter
    {
        private double _rub;

        public double RUB
        {
            get { return _rub; }
            set { _rub = value; }
        }

        private double _btc;

        public double BTC
        {
            get { return _btc; }
            set { _btc = value; }
        }

        private double _eth;

        public double ETH
        {
            get { return _eth; }
            set { _eth = value; }
        }

        private double _bhb;

        public double BHB
        {
            get { return _bhb; }
            set { _bhb = value; }
        }


        public Converter(double btc, double eth, double bhb)
        {
            this._btc = btc;
            this._eth = eth;
            this._bhb = bhb;
        }


    }
}
