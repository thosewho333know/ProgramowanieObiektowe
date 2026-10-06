namespace ProgObiektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           KontoBankowe pusteKonto = new KontoBankowe();

            pusteKonto.WyswietlInformacje();

            //Tworzenie obiektu klasy KontoBankowe 
            KontoBankowe kontoJana = new KontoBankowe("Jan Kowalski", 1500.59m);
            kontoJana.Wplac(500);
            kontoJana.WyswietlInformacje();

            // rzeczy z komentarzy: nrKonta, gettery settery, walidacje
            // metoda Wyplac

            // Zabezpieczenie operacji pinem. Każde konto powinno mieć ustawiony przez usera kod PIN
            // PIN ma 4 cyfry i nadaje się go przy zakładaniu konta.
            // Wpłata oraz wypłata wymaga od teraz wpisania poprawnego PINu.
            // Przykład: mojeKonto.Wyplac(100, "1234" -> "NIEPOPRAWNY PIN", albo "Wypłacam 100 PLN".

            
            

        }
    }
}
