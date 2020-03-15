using System;

namespace _017_ClassiAstratte_RelazioniTraClassi2 {
    class Program {
        static void Main(string[] args) {

            Territorio territorio = new Territorio("schio");
            territorio.AggiungiAbitazione("978AA", "via dei tigli,10 - Thiene", 200, 8, "A", 300);
            territorio.AggiungiAbitazione("253BB","via G. Leopardi,28 - Marostica",50,3,10000);
            territorio.AggiungiAbitazione("978BB", "via Pascoli,20 - Thinene", 180, 6, "B", 300);
            territorio.AggiungiAbitazione("978BB", "via giacomi,20 - Thinene", 180, 6, "B", 300);
            
            Console.WriteLine(territorio.ContaAbitazioni());
            territorio.Salva("territorio.txt");
            Console.WriteLine(territorio.TotImposte());
        }
    }
}