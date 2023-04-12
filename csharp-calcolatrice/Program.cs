namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sommaInteri = CalcoliHelper.Somma(8, 8);
            double sommaDouble = CalcoliHelper.Somma(8.5, 8.2);
            int differenzaInteri = CalcoliHelper.Differenza(8, 3);
            double differenzaDouble = CalcoliHelper.Differenza(8.6, 4.1);
            int moltiplicazioneInteri = CalcoliHelper.Moltiplicazione(4, 8);
            double moltiplicazioneDouble = CalcoliHelper.Moltiplicazione(8.5, 8.2);
            int valoreAssolutoInteri = CalcoliHelper.ValoreAssoluto(-8);
            double valoreAssolutoDouble = CalcoliHelper.ValoreAssoluto(-8.8);
            int minimoInteri = CalcoliHelper.Minimo(4, 8);
            double minimoDouble = CalcoliHelper.Minimo(8.5, 8.2);
            int massimoInteri = CalcoliHelper.Massimo(4, 8);
            double massimoDouble = CalcoliHelper.Massimo(8.5, 8.2);

            Console.WriteLine($"Somma di due numeri interi: {sommaInteri}");
            Console.WriteLine($"Somma di due numeri double: {sommaDouble}");
            Console.WriteLine($"Differenza tra due numeri interi: {differenzaInteri}");
            Console.WriteLine($"Differenza tra due numeri double: {differenzaDouble}");
            Console.WriteLine($"Moltiplicazione di due numeri interi: {moltiplicazioneInteri}");
            Console.WriteLine($"Moltiplicazione di due numeri double: {moltiplicazioneDouble}");
            Console.WriteLine($"Valore assoluto di un numero intero: {valoreAssolutoInteri}");
            Console.WriteLine($"Valore assoluto di un numero double: {valoreAssolutoDouble}");
            Console.WriteLine($"Minimo tra due numeri interi: {minimoInteri}");
            Console.WriteLine($"Minimo tra due numeri double: {minimoDouble}");
            Console.WriteLine($"Massimo tra due numeri interi: {massimoInteri}");
            Console.WriteLine($"Massimo tra due numeri double: {massimoDouble}");

        }
    }
}