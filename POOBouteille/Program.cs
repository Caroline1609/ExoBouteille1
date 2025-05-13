using ClassLibraryBouteille;

namespace POOBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille b1 = new Bouteille(false, 1 , 1);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.GetEstOuvert());
        }
    }
}
