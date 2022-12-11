using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablendeklaration
            int menge = 1700, deponieren, zurückziehen;
            int wahl, pin, x, pin2, y;

            // Geben Sie eine beliebige PIN ein
            Console.WriteLine("Geben Sie Ihre 4-stellige PIN ein ");
            // pin durch sprechenden Variablennamen ersetzen
            pin = int.Parse(Console.ReadLine());
            
            // solange es "true" ist..
            while (true)
            {
                // mach....
                Console.WriteLine(" ---------------------------");
                Console.WriteLine("| CIFTCI ATM                 |");
                Console.WriteLine("|                            |");
                Console.WriteLine("| 1. AKTUELLER KONTOSTAND    |");
                Console.WriteLine("| 2. AUSZAHLEN               |");
                Console.WriteLine("| 3. EINZAHLEN               |");
                Console.WriteLine("| 4. PIN ÄNDERN              |");
                Console.WriteLine("| 5. VERLASSEN               |");
                Console.WriteLine("|                            |");
                Console.WriteLine(" ---------------------------");
                Console.WriteLine("GEBEN SIE IHRE WAHL EIN : ");
                wahl = int.Parse(Console.ReadLine());

                // typ wahl
                switch (wahl)
                {
                    // mach in case 1......
                    case 1:
                        Console.WriteLine("\n IHR AKTUELLER KONTOSTAND IST : " + menge);
                        break;
                    case 2:
                        Console.WriteLine("\n GEBEN SIE DEN AUSZAHLUNGSBETRAG EIN : ");
                        zurückziehen = int.Parse(Console.ReadLine());

                        // wenn zurückziehen % 100 != 0 ist....                *(% 100 Modul Gibt den Restbetrag der Division zurück)&&(!=...nicht gleich)
                        if (zurückziehen % 100 != 0)
                        {
                            // mach....
                            Console.WriteLine("\n BITTE GEBEN SIE DEN BETRAG ÜBER 100 EIN");
                        }
                        // wenn nicht..
                        else if (zurückziehen > (menge - 1000))
                        {
                            Console.WriteLine("\n TUT MIR LEID! UNZUREICHENDES GLEICHGEWICHT");
                        }
                        else
                        {
                            menge = menge - zurückziehen;
                            Console.WriteLine("\n\n BITTE HOLEN SIE IHR BARGELD AB");
                            Console.WriteLine("\n AKTUELLER SALDO IST : " + menge);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n GEBEN SIE DEN EINZAHLUNGSBETRAG EIN");
                        deponieren = int.Parse(Console.ReadLine());
                        menge = menge + deponieren;
                        Console.WriteLine("IHR BETRAG WURDE ERFOLGREICH EINGEZAHLT....");
                        Console.WriteLine("IHR GESAMTGUTHABEN BETRÄGT : " + menge);
                        break;
                    case 4:
                        Console.WriteLine("Möchten Sie Ihre PIN ändern?");
                        Console.WriteLine("Geben Sie Ihre vorherige PIN ein");
                        int vorherigespin = int.Parse(Console.ReadLine());

                        if (vorherigespin == pin)
                        {
                            Console.WriteLine("Geben Sie Ihre neue PIN ein");
                            pin2 = int.Parse(Console.ReadLine());
                            pin = pin2;
                            Console.WriteLine("Ihre PIN wurde geändert");
                        }
                        else
                            Console.WriteLine("Geben Sie Ihre richtige PIN ein");
                        break;
                    case 5:
                        Console.WriteLine("\n VIELEN DANK…");
                            break;
                    // bei falsche Eingabe....
                    default:
                        Console.WriteLine("Bitte wählen Sie die richtige Option");
                        break;
                }
            }
        }
    }
}
