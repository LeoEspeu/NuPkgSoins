using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins
{
    /// <summary>
    /// Classe intervenant
    /// </summary>
    public class Intervenant
    {
        /// <summary>
        /// Nom de l'intervenant
        /// </summary>
        private string nom;

        /// <summary>
        /// prénom de l'intervenant
        /// </summary>
        private string prénom;

        /// <summary>
        /// Liste de prestation
        /// </summary>
        private List<Prestation> lesPrestations;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Intervenant"/>
        /// </summary>
        /// <param name="nom">Nom de l'intervenant</param>
        /// <param name="prénom">Prénom de l'intervenant</param>
        public Intervenant(string nom, string prénom)
        {
            this.nom = nom;
            this.prénom = prénom;
            this.lesPrestations = new List<Prestation>();
        }

        /// <summary>
        /// Obtient Nom
        /// </summary>
        public string Nom
        {
            get => this.nom;
        }

        /// <summary>
        /// Obtient prénom
        /// </summary>
        public string Prénom
        {
            get => this.prénom;
        }

        /// <summary>
        /// Ajoute une prestation à la liste lesPrestations
        /// </summary>
        /// <param name="unePrestation">Une prestation</param>
        public void AjouterPrestation(Prestation unePrestation)
        {
            this.lesPrestations.Add(unePrestation);
        }

        /// <summary>
        /// Retourne un intervenant sous la forme d'un string
        /// </summary>
        /// <returns>Affiche les propriétés de l'intervenant</returns>
        public override string ToString()
        {
            return " Dr " + this.nom + " " + this.prénom + " ";
        }
    }
}
