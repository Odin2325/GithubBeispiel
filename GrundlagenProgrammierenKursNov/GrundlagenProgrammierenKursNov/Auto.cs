using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenProgrammierenKursNov
{
    internal class Auto
    {
        internal string marke = "Tesla";
        internal int vMax;
        internal string farbe;
        internal int kofferraum;
        internal string owner;
        internal decimal autoPreis;
        internal int benzinTank = 0;
        internal bool wirFahren = false;

        //Constructor - Konstruktor
        internal Auto(int geschwindigkeit, string gewuenschteFarbe, int gewuenschtesKofferraum, string werEsBekommenSoll, decimal endGueltigerAutoPreis)
        {
            vMax = geschwindigkeit;
            farbe = gewuenschteFarbe;
            kofferraum = gewuenschtesKofferraum;
            owner = werEsBekommenSoll;
            autoPreis = endGueltigerAutoPreis;
        }

        internal void Fahren()
        {
            if (wirFahren) 
            {
                Console.WriteLine("Wir fahren doch schon!");
                return;
            }
            if (benzinTank > 0)
            {
                Console.WriteLine("Wir fahren! Brum Brum...");
                wirFahren=true;
            }
            else
            {
                Console.WriteLine("Kein Treibstoff. Bitte Tanken!");
            }
        }

        internal void Auftanken()
        {
            benzinTank = 100;
            Console.WriteLine("Aufgetankt!");
        }

        internal void Bremsen()
        {
            if (wirFahren)
            {
                Console.WriteLine("Wir bremsen!");
                wirFahren = false;
            }
            else
            {
                Console.WriteLine("Wir sind schon geparkt...");
            }
        }

        internal void AutoDetails()
        {
            Console.WriteLine($"vMax = {vMax}\nOwner = {owner}\nAktuel am fahren? = {wirFahren}\nBenzin Tank % = {benzinTank}");
        }
    }
}
