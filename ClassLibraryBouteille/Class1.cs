using System.Security.Cryptography.X509Certificates;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        private bool estOuvert;
        private decimal contenuEnLitre;
        private decimal contenanceEnLitre;

        public bool EstOuvert { get => estOuvert; }
        public decimal ContenuEnLitre { get => contenuEnLitre; }
        public decimal ContenanceEnLitre { get => contenanceEnLitre; }

        //Constructeur par défaut 
        public Bouteille() : this(false, 0, 0) // utilisation de l'INTERDEPENDANCE pour éviter de faire du code redondant (on se base plutot sur le contructeur classique)

        {

        }

        //Constructeur Par Clonage
        public Bouteille(Bouteille bouteilleACloner) : this(bouteilleACloner.estOuvert, bouteilleACloner.contenanceEnLitre, bouteilleACloner.contenuEnLitre)

        {

        }

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
        
        public bool Ouvrir()
        {
            if (estOuvert == false)
            {
                estOuvert = true;
                return true;                         
            }
            return false;

        }

        public bool Fermer()
        {
            if (estOuvert == true)
            {
                estOuvert = false;
                return true;
            }
            else
            {
                return false;
            }
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
            return $"La bouteile est {(this.estOuvert ? "ouvertes" : "fermée")}. Elle a une contenance de {this.contenanceEnLitre} Litre(s) et elle est rempli de {this.contenuEnLitre} litres";
        }

        public decimal GetContenanceEnMLitre()
        {
            decimal resultat = contenuEnLitre * 1000;
            return resultat;
        }

        public bool Remplir()
        {
            return Remplir(contenanceEnLitre - contenuEnLitre);
        }

        public bool Remplir(decimal quantiteEnLitre)
        {
            if (EstOuvert == true && (contenuEnLitre + quantiteEnLitre) <= contenanceEnLitre)
            {
                contenuEnLitre += quantiteEnLitre;
                return true;
            }
            else
            {
                return false;
            }            
        }

        public bool Vider()
        {
            return Vider(contenuEnLitre);
        }

        public bool Vider(decimal quantiteEnLitre)
        {
            if (this.estOuvert == true && quantiteEnLitre <= this.contenuEnLitre && contenuEnLitre != 0)
            {
                contenuEnLitre = contenuEnLitre - quantiteEnLitre;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}