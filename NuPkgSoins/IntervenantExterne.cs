using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins
{
    /// <summary>
    /// Classe intervenant externe
    /// </summary>
    public class IntervenantExterne : Intervenant
    {
        /// <summary>
        /// Nom de la spécialité de l'intervenant
        /// </summary>
        private string spécialité;

        /// <summary>
        /// Adresse de l'intervenant
        /// </summary>
        private string adresse;

        /// <summary>
        /// N° de l'intervenant
        /// </summary>
        private string tel;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="IntervenantExterne"/>
        /// </summary>
        /// <param name="nom">Nom de l'intervenant</param>
        /// <param name="prénom">Prénom de l'intervenant</param>
        /// <param name="uneSpécialité">Spécialité de l'intervenant</param>
        /// <param name="uneAdresse">Adresse de l'intervenant</param>
        /// <param name="unTel">N° de l'intervenant</param>
        public IntervenantExterne(string nom, string prénom, string uneSpécialité, string uneAdresse, string unTel) : base(nom, prénom)
        {
            this.spécialité = uneSpécialité;
            this.adresse = uneAdresse;
            this.tel = unTel;
            Intervenant unIntervenant = new Intervenant(nom, prénom);
        }

        /// <summary>
        /// Obtient Spécialité
        /// </summary>
        public string Spécialité
        {
            get => this.spécialité;
        }

        /// <summary>
        /// Obtient adresse
        /// </summary>
        public string Adresse
        {
            get => this.adresse;
        }

        /// <summary>
        /// Obtient tel
        /// </summary>
        public string Tel
        {
            get => this.tel;
        }

        /// <summary>
        /// Retourne un intervenant externe sous la forme d'un string
        /// </summary>
        /// <returns>Affiche les propriétés de l'intervenant externe</returns>
        public override string ToString()
        {
            return base.ToString() + "Spécialité: " + this.spécialité + " - adresse: " + this.adresse + " - Tel: " + this.tel;
        }
    }
}
