using System.Threading.Channels;

namespace GrundlagenProgrammierenKursNov
{
    internal class Bankkonto
    {
        private string kontoinhaber;
        private string pin;
        private decimal kontostand;
        internal string kontonummer;
        internal List<string> historie;

        internal Bankkonto(string kontoinhaber, string pin, string kontonummer)
        {
            this.kontoinhaber = kontoinhaber;
            this.pin = pin;
            kontostand = 0m;
            this.kontonummer = kontonummer;
            historie = new List<string>();
        }

        internal void GeldEinzahlen(decimal betrag)
        {
            if (betrag > 0)
            {
                kontostand += betrag;
                Console.WriteLine($"Sie haben {betrag} Euro eingezahlt.");
                historie.Add($"Einzahlung: {betrag}");
                return;
            }
            Console.WriteLine("Kein gueltiger Betrag. Nur zahlen groesser 0 eingeben.");
        }

        internal void GeldAuszahlen(decimal betrag)
        {
            if(betrag>kontostand || betrag < 0)
            {
                Console.WriteLine("Ungueltige eingabe.");
                return;
            }
            kontostand += betrag;
            Console.WriteLine($"Sie haben {betrag} Euro eingezahlt.");
            historie.Add($"Auszahlung: {betrag}");
        }

        internal void KontoDetails()
        {
            Console.WriteLine($"Konto Details:\nInhaber: {kontoinhaber}\nKontostand: {kontostand}");
            Console.WriteLine("Komplette Historie:");
            foreach(string eintrag in historie)
            {
                Console.WriteLine(eintrag);
            }
        }


    }
}
