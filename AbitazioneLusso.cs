namespace _017_ClassiAstratte_RelazioniTraClassi2 {
    public class AbitazioneLusso : Abitazione {
        private string _classeEnergetica;
        private int _estensioneTerreni;
        
        public AbitazioneLusso(string codiceIdentificativo, string indirizzo, int mq, int nVani, string classeEnergetica, int estensioneTerreni) : base(
            codiceIdentificativo, indirizzo, mq, nVani) {
            _classeEnergetica = classeEnergetica;
            _estensioneTerreni = estensioneTerreni;
            
        }

        public override double ValoreImposta() {
            return this.Mq * 2.5f + _estensioneTerreni * 1.25f;
        }

        public string ClasseEnergetica {
            get => _classeEnergetica;
            set => _classeEnergetica = value;
        }

        public int EstensioneTerreni {
            get => _estensioneTerreni;
            set => _estensioneTerreni = value;
        }

        public override string ToString() {
            return base.ToString() + string.Format($"|{_classeEnergetica}|{_estensioneTerreni}");
        }
    }
}