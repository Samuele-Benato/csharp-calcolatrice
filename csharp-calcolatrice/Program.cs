namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Test del metodo SumInt
            int sumIntResult = CalcoliHelper.SumInt(2, 3);
            Console.WriteLine($"Somma intera: {sumIntResult}");

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
            double number2 = -5.5;
            double absValue2 = CalcoliHelper.AbsoluteValueDouble(number2);
            Console.WriteLine($"Il valore assoluto di {number2} è {absValue2}");

            // Test del metodo MinInt
            int numberminInt = CalcoliHelper.MinInt(5, 3);
            Console.WriteLine($"Numero più piccolo: {numberminInt}");

            // Test del metodo MinDouble
            double numberminDouble = CalcoliHelper.MinDouble(5.7, 3.8);
            Console.WriteLine($"Numero più piccolo: {numberminDouble}");

            // Test del metodo MaxInt
            int numbermaxInt = CalcoliHelper.MaxInt(5, 3);
            Console.WriteLine($"Numero più grande: {numbermaxInt}");

            // Test del metodo MinDouble
            double numbermaxDouble = CalcoliHelper.MaxDouble(5.7, 3.8);
            Console.WriteLine($"Numero più grande: {numbermaxDouble}");

            // DRY - Don't Repeat Yourself

            // BONUS 
            // Test del metodo Power
            double result = CalcoliHelper.Power(0,0);
            Console.WriteLine($"Risultato potenza: {result}");
        }
    }
}
