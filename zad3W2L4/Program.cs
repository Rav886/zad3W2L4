namespace zad3
{
    internal class Program
    {
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("Podaj szerokość prostokąta");

            a = double.Parse(Console.ReadLine());                  

            Console.WriteLine("Podaj wysokość prostokąta");

            b = double.Parse(Console.ReadLine());
            
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"Przekątna tego prostokąta wynosi {c}");

            
        }
    }
}
