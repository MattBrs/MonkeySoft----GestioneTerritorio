using System;

namespace _017_ClassiAstratte_RelazioniTraClassi2 {
    public abstract class Abitazione {
        protected string _codiceIdentificativo;
        protected string _indirizzo;
        protected int _mq;
        protected int _nVani;

        protected Abitazione(string codiceIdentificativo, string indirizzo, int mq, int nVani) {
            this._codiceIdentificativo = codiceIdentificativo;
            this._indirizzo = indirizzo;
            this._mq = mq;
            this._nVani = nVani;
        }

        public abstract double ValoreImposta();
        
        public string CodiceIdentificativo => _codiceIdentificativo;

        public string Indirizzo => _indirizzo;

        public int Mq => _mq;

        public int NVani => _nVani;
        public override string ToString() {
            return String.Format($"{CodiceIdentificativo}|{Indirizzo}|{_mq}|{_nVani}");
        }
    }
}