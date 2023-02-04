namespace _5_reqemli_eded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            int tam = (int)number;
            decimal kesr = number - tam;
            kesr *= 1000000;
            kesr += tam;
            kesr /= 1000;
            Console.WriteLine(kesr);
        }
    }
}