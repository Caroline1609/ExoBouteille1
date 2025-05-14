using System.Security.Cryptography.X509Certificates;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private bool estOuvert;
        private decimal contenuEnLitre;
        private decimal contenanceEnLitre;

        public bool EstOuvert { get => estOuvert; /*set => estOuvert = value;*/ }

        public Bouteille(bool _estOuvert, decimal contenuEnLitre, decimal contenanceEnLitre)
        {

            if (contenuEnLitre <= 0)
            {
                throw new ArgumentException("Le contenuEnLitre d'une bouteille ne peut être que positif", nameof(contenuEnLitre));
            }

            

            this.estOuvert = _estOuvert;
            this.contenuEnLitre = contenuEnLitre;
            this.contenanceEnLitre = contenanceEnLitre;
        }

        public decimal GetContenuEnLitre()
        {
            return contenuEnLitre;
        }

        public decimal GetContenanceEnLitre()
        {
            return contenanceEnLitre;
        }

        public override string ToString()
        {
            return $"La bouteile est {this.estOuvert}, et elle contient {this.contenanceEnLitre} Litre(s) et elle est remplir à {this.contenuEnLitre} litres";
        }

        public decimal GetContenanceEnMLitre()
        {
            decimal resultat = contenuEnLitre * 1000;
            return resultat;
        }

        //public bool Remplir()
        //{
            
        //}


    }
}