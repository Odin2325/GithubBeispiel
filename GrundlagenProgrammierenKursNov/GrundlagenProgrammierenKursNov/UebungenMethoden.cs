using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenProgrammierenKursNov
{
    public class UebungenMethoden
    {
        public static double Durchschnitt(int[] arr)
        {
            return arr.Average();
        }
        public static double Durchschnitt(double[] arr)
        {
            return arr.Average();
        }
        public static decimal Durchschnitt(decimal[] arr)
        {
            return arr.Average();
        }
        public static double Durchschnitt(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }
        public static double Durchschnitt(string wort)
        {
            char[] zeichen = wort.ToCharArray();
            double summe = 0;

            for(int i = 0; i < zeichen.Length; i++)
            {
                summe += (int)zeichen[i];
            }

            return summe/wort.Length;
        }

        public static string GeneriereZufallsWort(int arrayLaenge=20)
        {
            // Möglichkeit 1. Array fest in der Methode Definieren
            char[] buchstabenArray = new char[arrayLaenge];

            //Möglichkeit 2. Array größe über den Parameter bestimmten
            //char[] chars = new char[laenge];

            // Zufallsgenerator initialisieren
            Random random = new Random();

            for (int i = 0; i < arrayLaenge; i++)
            {
                //Wollen wir Groß oder Kleinbuchstaben?
                int zahl = random.Next(0, 2);
                //ist es Groß
                //........
                if (zahl == 0)
                {
                    // Großbuchstabe (ASCII-Werte von 65 bis 90)
                    buchstabenArray[i] = Convert.ToChar(random.Next(65, 91));
                }
                // oder klein
                //......
                else
                {
                    // Kleinbuchstabe (ASCII-Werte von 97 bis 122)
                    buchstabenArray[i] = Convert.ToChar(random.Next(97, 123));
                }
            }
            return new string(buchstabenArray);
        }














































        //Methode Schreiben wo wir den produkt von 3 zahlen berechnen.
        //zahl1*zahl2*zahl3.
        //Das soll als double zurueckgegeben werden.
        public static int Summe(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        //Parameter->Definition variablen in Methoden Definition
        //Argumente->Echte werte die wir an die Methode geben.
        public static double Produkt(double zahl1, double zahl2, double zahl3)
        {
            return zahl1 * zahl2 * zahl3;
        }

        /* Fuer Zahlen: 
     * Schreibe eine Methode die 3 int variablen als parameter nimmt.
     * Dannach den average zurueck am hauptprogramm geben.
     * Average = (var1+var2+var3)/Anzahl an werte die aufsummiert wurden
     * Challenge:
     * Schreiben sie dann eine zweite methode die einen array von ints nimmt
     * und den average der werte berechnet und zurueck gibt.
     */

        public static void Begruessung()
        {
            Console.WriteLine("Wilkommen!");
            return;
        }

        /// <summary>
        /// Erste Variante
        /// Join Methode wird verwendet um teilnehmer aus 
        /// unseren array mit einen ", " zu verknuepfen.
        /// </summary>
        /// <param name="teilnehmer">string array</param>
        /// <returns>No return value, but prints to console.</returns>
        public static void ArrayFormattierung(string[] teilnehmer)
        {
            string ganzerArray = "{" + string.Join(", ", teilnehmer) + "}";
            Console.WriteLine(ganzerArray);
        }


        public static void PrintArray(string[] teilnehmer)
        {
            Console.Write("{");
            int totalNumber = teilnehmer.Length;
            for (int i = 0; i < totalNumber; i++)
            {
                if (i == totalNumber - 1)
                {
                    Console.WriteLine(teilnehmer[i] + "}");
                }
                else
                {
                    Console.Write(teilnehmer[i] + ", ");
                }
            }
        }



        /*
         * Erstelle eine Methode die als parameter einen String array nimmt.
         * Die Methode soll alle werte ausgeben.
         * In diese form:
         * teilnehmer = {Li Su, Tanja Schaefer, Paria Taheri Bandari, Amir Montazerin, Frank Mayser, Goekhan Oezcan, Nicolas Arevalo Hoelscher}
         * Alles in eine Zeile.
         * Faengt mit { an
         * Ende mit }.
         * Alle werte mit Komma getrennt und einen leerzeichen.
         * Keine Anfuehrungszeichen noetig.
         * Schritte: 
         * 1. Array mit Werte in Methode definieren.
         * 2. Laenge von array herausfinden fuer for schleife.
         * 3. string.Join auf teilnehmer array ausfuehren mit ", " als separator.
         * 4. 
         */

    }
}
