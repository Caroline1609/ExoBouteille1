using ClassLibraryBouteille;

namespace POOBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille b1 = new Bouteille(true, 1.0m, 2.0m);

            Console.WriteLine(b1.ToString());

            b1.Ouvrir();
            b1.Fermer();
            b1.Remplir(0.25m);


            Console.WriteLine(b1.Ouvrir() ? "b1 est ouvert" : "b1 est fermer");
            Console.WriteLine(b1.Remplir() ? "b1 a été remplie avec succès." : "Échec du remplissage de b1.");


        }
    }
}
