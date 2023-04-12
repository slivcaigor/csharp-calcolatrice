using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*
Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).
BONUS:
Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente. Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
(caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)
*/


namespace csharp_calcolatrice
{
    //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
    // POLIMORFISMO

    public class CalcoliHelper
    {
        // Somma di due numeri interi
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        // Somma di due numeri double
        public static double Somma(double a, double b)
        {
            return a + b;

        }

        // Differenza tra due numeri interi
        public static int Differenza(int a, int b)
        {
            return a - b;
        }

        // Differenza tra due numeri double
        public static double Differenza(double a, double b)
        {
            return a - b;
        }

        // Moltiplicazione di due numeri interi
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        // Moltiplicazione di due numeri double
        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        // Valore assoluto di un numero intero
        public static int ValoreAssoluto(int a)
        {
            return Math.Abs(a);
        }

        // Valore assoluto di un numero double
        public static double ValoreAssoluto(double a)
        {
            return Math.Abs(a);
        }

        // Minimo tra due numeri interi
        public static int Minimo(int a, int b)
        {
            return Math.Min(a, b);
        }

        // Minimo tra due numeri double
        public static double Minimo(double a, double b)
        {
            return Math.Min(a, b);
        }

        // Massimo tra due numeri interi
        public static int Massimo(int a, int b)
        {
            return Math.Max(a, b);
        }

        // Massimo tra due numeri double
        public static double Massimo(double a, double b)
        {
            return Math.Max(a, b);
        }
    }
}
