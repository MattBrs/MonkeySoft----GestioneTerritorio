using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace _017_ClassiAstratte_RelazioniTraClassi2 {
    public class Territorio {
        private string _nomeComune;
        private List<Abitazione> _abitazioni;

        public Territorio(string nomeComune) {
            _nomeComune = nomeComune;
            _abitazioni = new List<Abitazione>();
        }
        
        public bool AggiungiAbitazione(string codiceIdentificativo, string indirizzo, int mq, int nVani, string classeEnergetica, int estensioneTerreni) {
            if (_abitazioni.All(x => x.CodiceIdentificativo != codiceIdentificativo)) {
                Abitazione abitazione = new AbitazioneLusso(codiceIdentificativo,indirizzo,mq,nVani,classeEnergetica,estensioneTerreni);
                _abitazioni.Add(abitazione);
                return true;
            }
            return false;
        }
        public bool AggiungiAbitazione(string codiceIdentificativo, string indirizzo, int mq, int nVani, int reddito) {
            if (_abitazioni.All(x => x.CodiceIdentificativo != codiceIdentificativo)) {
                Abitazione abitazione = new AbitazionePopolare(codiceIdentificativo,indirizzo,mq,nVani,reddito);
                _abitazioni.Add(abitazione);
                return true;
            }
            return false;
        }

        public double TotImposte() {
            return _abitazioni.Sum(x => x.ValoreImposta());
        }

        public string ContaAbitazioni() {
            return string.Format($"Abitazioni popolari: {_abitazioni.Count(x => x.GetType() == typeof(AbitazionePopolare))}  Abitazioni lusso: {_abitazioni.Count(x => x.GetType() == typeof(AbitazioneLusso))}");
        }

        public void Salva(string nomeFIle) {
            StreamWriter stw = new StreamWriter("./" + nomeFIle);
            _abitazioni.ForEach(x => stw.WriteLine(x));
            stw.Close();
        }
    }
}