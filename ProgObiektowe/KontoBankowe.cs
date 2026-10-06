using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProgObiektowe
{
    // PascalCase [!!!]
    // snake_case
    // camelCase
    // kebab-case
    internal class KontoBankowe
    {
        //Pola
        //Właściwości
        //Cechy
        //Atrybuty
        private decimal _saldo;
        private string _nrKonta;
        private string _wlasciciel;

        // gettery settery
        public decimal Saldo 
        {
            get { return _saldo; }
        }

        public string Wlasciciel
        {
            get { return _wlasciciel; }
            set
            {
                // walidacja
                if (string.IsNullOrWhiteSpace(value))
                {
                    _wlasciciel = value;
                }
                else
                {
                    Console.WriteLine("Błąd: Nazwa właściciela nie może być pusta.");
                }
               
            }
        }
        // konstruktory
        public KontoBankowe()
        {
            _wlasciciel = "Nieznany";
            _saldo = 0;

            Console.WriteLine("Utworzono puste konto.");
        }

        // stwórz konstruktor, który zna tylko właściciela i resztę ustawia sam

        public KontoBankowe(string NowyWlasciciel)
        {
            _wlasciciel = NowyWlasciciel;
            _saldo = 0;
            Console.WriteLine($"Utworzono konto dla własciciela: {_wlasciciel}");
        }


        public KontoBankowe(string nowyWlasciciel, decimal startoweSaldo)
        {
            _wlasciciel = nowyWlasciciel; 
            _saldo = startoweSaldo; // walidacja salda (nie powinno być ujemne)
            
            if ( startoweSaldo <= 0 )
            {
                Console.WriteLine("Nieprawidłowe saldo początkowe. Ustawiono na 0 PLN.");
                _saldo = 0;
            }

            //generowanie numeru konta

            _nrKonta = Guid.NewGuid().ToString().Substring(0, 8);

            Console.WriteLine($"Utworzono nowe konto dla {_wlasciciel} z saldem: {_saldo} PLN.");
        }

        //metody
        //funkcje obiektów

        //wpłacanie
        public void Wplac(decimal kwota) 
        {
            //walidacja kwoty
            if (kwota <= 0)
            {
                Console.WriteLine("Nieprawidłowa kwota. Wpłata musi być dodatnia.");
                return;
            }

            _saldo += kwota;
            Console.WriteLine($"Wpłacono {kwota} PLN. Aktualny stan konta: {_saldo} PLN.");
        }

        //wypłacanie
        public void Wyplac(decimal kwota)
        {
            //walidacja kwoty
            if (kwota >= 0)
            {
                Console.WriteLine("Nieprawidłowa kwota. Wypłata musi być ujemna.");
                return;
            }

            _saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota} PLN. Aktualny stan konta: {_saldo} PLN.");
        }

        //informacje o koncie
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Właściciel: {_wlasciciel}");
            Console.WriteLine($"Saldo: {_saldo} PLN");
            //nr konta
            Console.WriteLine($"Numer konta: {_nrKonta}");
        }
    }
}
