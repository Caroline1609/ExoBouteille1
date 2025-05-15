using ClassLibraryBouteille;

namespace POOBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille b1 = new Bouteille(true, 2.0m, 2.0m);
            Bouteille b2 = new Bouteille(false, 0.5m, 1.0m);
            Bouteille b3 = new Bouteille(true, 0.1m, 1.0m);


            b1.Remplir(0.5m);





            //Console.WriteLine("Methode contenu en litre : " + b1.EstOuvert);
            //Console.WriteLine("Methode contenu en litre : " + b1.GetContenuEnLitre());
            //Console.WriteLine("Methode contenance en litre : " + b1.GetContenanceEnLitre());
            //Console.WriteLine("Methode contenu en ML : " + b1.GetContenanceEnMLitre());
            //Console.WriteLine("remplir : " + b1.Remplir());
            //Console.WriteLine("Methode ToString : " + b1.ToString());

            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine(b3.ToString());

            b1.Ouvrir();
            b1.Fermer();
            b1.Fermer();
            b1.Ouvrir();



            b1.Remplir();                        
            b1.Remplir();                        

            b2.Remplir(0.3m);
            
            b3.Remplir(0.1m);                   
            b3.Remplir(0.5m);                  
            b3.Vider(0.5m);                     
            b3.Vider(0.10m);                     
            b3.Vider();                         

            b3.Vider();

        }
    }
}
