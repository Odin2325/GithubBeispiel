using System;
using System.IO;

namespace GrundlagenProgrammierenKursNov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 0;

            try
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                num = int.Parse(Console.ReadLine());
                if (num == 0) 
                { 
                    throw new DivideByZeroException();
                }
                Console.WriteLine($"Der Quadrat von {num} ist {num / num}");
            }
            catch (FormatException e)
            {
                num = -1;
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Wir machen weiter mit default wert -1");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Wir machen mit die Berechnung");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                throw new Exception("Catch block fertig.");
            }
            finally
            {
                
            }
            Console.WriteLine("Text auf die Konsole nach der Exception.");
        }
    }

    public abstract class Flieger
    {
        public abstract void Sound();
        public void WingsAmount()
        {
            Console.WriteLine("We all have 2 wings");
        }
    }

    public class Bird : Flieger
    {
        public override void Sound()
        {
            Console.WriteLine("Tweet, Tweet");
        }
    }
    public class Airplane : Flieger
    {
        public override void Sound()
        {
            Console.WriteLine("NNNEEAOOWWW");
        }
    }




    public class LandTier
    {
        internal bool kannAtmen = true;
        internal int anzahlBeine;
        internal string geschlecht;

        public LandTier(int anzahlBeine, string geschlecht)
        {
            this.anzahlBeine = anzahlBeine;
            this.geschlecht = geschlecht;
        }

        public void TierDetails()
        {
            Console.WriteLine($"Dieser {this.GetType()} hat {anzahlBeine} beine.\nDieser {this.GetType()} ist: {geschlecht}");
        }
    }

    

    public class Katze : LandTier
    {
        public Katze(string geschlecht) : base(4,geschlecht)
        {

        }

        public void Geraeusch()
        {
            Console.WriteLine("Meow...");
        }
    }



}