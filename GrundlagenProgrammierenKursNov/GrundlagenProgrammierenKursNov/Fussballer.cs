using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenProgrammierenKursNov
{
    internal class Fussballer
    {
        int anzahlBeine = 2;
        string name;
        string team;
        int nummer;
        double groesse;
        int dribblingKompetenz;
        int geschwindigkeitLauf;

        public Fussballer(string name, string team, int nummer, double groesse, int dribblingKompetenz, int geschwindigkeitLauf)
        {
            this.name = name;
            this.team = team;
            this.nummer = nummer;
            this.groesse = groesse;
            this.dribblingKompetenz = dribblingKompetenz;
            this.geschwindigkeitLauf = geschwindigkeitLauf;
        }

        internal void Laufen()
        {
            Console.WriteLine("Dieser Spieler laueft mit geschwindigkeit {0}",geschwindigkeitLauf);
        }

        internal void WasTunWirJetzt()
        {
            Laufen();
        }


    }
}
