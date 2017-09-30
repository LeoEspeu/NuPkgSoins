using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins
{
    /// <summary>
    /// classe prestation
    /// </summary>
    public class Prestation
    {
        /// <summary>
        /// Libelle de la prestation
        /// </summary>
        private string libelle;

        /// <summary>
        /// Date de la prestation
        /// </summary>
        private DateTime dateSoin;

        /// <summary>
        /// Heure de la prestation
        /// </summary>
        private DateTime heureSoin;

        /// <summary>
        /// Intervenant de la prestation
        /// </summary>
        private Intervenant monIntervenant;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Prestation"/>
        /// </summary>
        /// <param name="plibelle">Libelle de la prestation</param>
        /// <param name="pdateSoin">Date de la prestation</param>
        /// <param name="pheureSoin">Heure de la prestation</param>
        /// <param name="unIntervenant">Intervenant de la prestation</param>
        public Prestation(string plibelle, DateTime pdateSoin, DateTime pheureSoin, Intervenant unIntervenant)
        {
            this.libelle = plibelle;
            this.dateSoin = pdateSoin;
            this.heureSoin = pheureSoin;
            this.monIntervenant = unIntervenant;
            this.monIntervenant.AjouterPrestation(this);
        }

        /// <summary>
        /// Obtient dateSoin
        /// </summary>
        public DateTime DateSoin
        {
            get => this.dateSoin;
        }

        /// <summary>
        /// Obtient heureSoin
        /// </summary>
        public DateTime HeureSoin
        {
            get => this.heureSoin;
        }

        /// <summary>
        /// Obtient monIntervenant
        /// </summary>
        internal Intervenant I_intervenant
        {
            get => this.monIntervenant;
        }

        /// <summary>
        /// Comparare la date de 2 prestations
        /// </summary>
        /// <param name="unePrestation">Prestation avec la date à comparer </param>
        /// <returns>Retourne 0 si les dates sont identiques ,1 si ladate courante est supérieure ,-1 si elle est inférieure</returns>
        public int CompareTo(Prestation unePrestation)
        {
            if (this.dateSoin.Equals(unePrestation.DateSoin))
            {
                return 0;
            }
            else
            {
                if (this.dateSoin > unePrestation.DateSoin)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Retourne une prestation sous la forme d'un string
        /// </summary>
        /// <returns>Affiche les propriétés de la prestation</returns>
        public override string ToString()
        {
            return "libelle " + this.libelle + " - " + this.dateSoin.Day + "/" + this.dateSoin.Month + "/" + this.dateSoin.Year + " - " + this.heureSoin.Hour + ":" + this.heureSoin.Minute + ":" + this.heureSoin.Second + " - Intervenant: " + this.monIntervenant;
        }
    }
}
