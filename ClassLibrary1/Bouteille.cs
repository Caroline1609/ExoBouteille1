namespace ClassLibrary1
{
    public class Bouteille
    {
        private bool estOuvert;
        private decimal contenuEnLitre;

        //constructeur par defaut
        public Bouteille() : this(false, 1)
        {
            //estOuvert = false;
        }




        // constructeur classique
        public Bouteille(bool _estOuvert, decimal contenuEnLitre)
        {

            if (contenuEnLitre <= 0)
            {
                throw new ArgumentException("Le contenuEnLitre d'une bouteille ne peut être que positif", nameof(contenuEnLitre));
            }

            this.estOuvert = _estOuvert;
            this.contenuEnLitre = contenuEnLitre;








        }

        //constructeur par clonage
        public Bouteille(Bouteille _bouteilleACopier) : this(_bouteilleACopier.estOuvert, _bouteilleACopier.contenuEnLitre)
        {
            //this.estOuvert = _bouteilleACopier.estOuvert;
        }
    }
}
