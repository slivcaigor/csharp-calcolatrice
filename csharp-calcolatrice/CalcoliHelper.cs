using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

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
            if (a < 0)
            {
                return -a;
            }
            else
            {
                return a;
            }
        }

        // Valore assoluto di un numero double
        public static double ValoreAssoluto(double a)
        {
            if (a < 0)
            {
                return -a;
            }
            else
            {
                return a;
            }
        }

        // Minimo tra due numeri interi
        public static int Minimo(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // Minimo tra due numeri double
        public static double Minimo(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // Massimo tra due numeri interi
        public static int Massimo(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // Massimo tra due numeri double
        public static double Massimo(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        // Bonus (non mi convince)
        public static int Potenza(int b, int e)
        {
            if (e == 0 && b == 0)
            {
                return 1;
            }
            else if (b == 0)
            {
                return 0;
            }
            else if (e == 0)
            {
                return 1;
            }
            else if (e < 0)
            {
                return -1;
            }
            else
            {
                int result = 1;
                for (int i = 0; i < e; i++)
                {
                    result *= b;
                }
                return result;
            }
        }

    }
}
