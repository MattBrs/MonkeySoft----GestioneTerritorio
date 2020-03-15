using System;

namespace _017_ClassiAstratte_RelazioniTraClassi2 {
    public class AbitazionePopolare : Abitazione {
        private int _reddito;

        public AbitazionePopolare(string codiceIdentificativo, string indirizzo, int mq, int nVani, int reddito) : base(codiceIdentificativo, indirizzo, mq, nVani) {
            _reddito = reddito;
        }

        public override double ValoreImposta() {
            return this.Mq * 2;
        }

        public int Reddito {
            get => _reddito;
            set => _reddito = value;
        }

        public override string ToString() {
            return base.ToString() + String.Format($"|{_reddito}");
        }
    }
}