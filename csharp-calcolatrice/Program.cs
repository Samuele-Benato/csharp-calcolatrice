﻿namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Test del metodo SumInt
            int sumIntResult = CalcoliHelper.SumInt(2, 3);
            Console.WriteLine($"Somma intera: { sumIntResult}");

            // Test del metodo SumDouble
            double sumDoubleResult = CalcoliHelper.SumDouble(2.5, 3.7);
            Console.WriteLine($"Somma decimali: {sumDoubleResult}");

            // Test del metodo DifferenceInt
            int differenceIntResult = CalcoliHelper.DifferenceInt(4, 13);
            Console.WriteLine($"Differenza intera: {differenceIntResult}");

            // Test del metodo DifferenceDouble
            double differenceDoubleResult = CalcoliHelper.DifferenceDouble(5.5, 3.2);
            Console.WriteLine($"Differenza decimali: {differenceDoubleResult}");

            // Test del metodo MoltiplicationInt
            int moltiplicationIntResult = CalcoliHelper.MoltiplicationInt(5, 3);
            Console.WriteLine($"Moltiplicazione intera: {moltiplicationIntResult}");

            // Test del metodo MoltiplicationInt
            double moltiplicationDoubleResult = CalcoliHelper.MoltiplicationDouble(5.8, 7.4);
            Console.WriteLine($"Moltiplicazione decimali: {moltiplicationDoubleResult}");

            // Test del metodo AbsoluteValueInt
            int number = -5;
            int absValue = CalcoliHelper.AbsoluteValueInt(number);
            Console.WriteLine($"Il valore assoluto di {number} è {absValue}");

            // Test del metodo AbsoluteValueDouble
            double number2 = - 5.5;
            double absValue2 = CalcoliHelper.AbsoluteValueDouble(number2);
            Console.WriteLine($"Il valore assoluto di {number2} è {absValue2}");

            /*
             Creare una classe di helper CalcoliHelper.
                Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
                
           
               
              
                
               
               
                - Valore assoluto di un numero double
                - Minimo tra due numeri interi
                - Minimo tra due numeri double
                - Massimo tra due numeri interi
                - Massimo tra due numeri double
                Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
                Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).
                **BONUS**:
                Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente. Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
                (caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)
                Buon lavoro!
             */
        }
    }
}
