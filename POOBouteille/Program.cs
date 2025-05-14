using ClassLibraryBouteille;

namespace POOBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille b1 = new Bouteille(false, 1, 1);
            Console.WriteLine("Methode contenu en litre : " + b1.EstOuvert);
            Console.WriteLine("Methode contenu en litre : " + b1.GetContenuEnLitre());
            Console.WriteLine("Methode contenance en litre : " + b1.GetContenanceEnLitre());
            Console.WriteLine("Methode contenu en ML : " + b1.GetContenanceEnMLitre());
            Console.WriteLine("Methode ToString : " + b1.ToString());

        }
    }
}
