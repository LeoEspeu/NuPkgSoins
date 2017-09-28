using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soins
{
    public class Prestation
    {
        private string libelle;
        private DateTime dateSoin;
        private DateTime heureSoin;
        private Intervenant i_intervenant;

        public Prestation(string plibelle, DateTime pdateSoin, DateTime pheureSoin, Intervenant iUnIntervenant)
        {
            libelle = plibelle;
            dateSoin = pdateSoin;
            heureSoin = pheureSoin;
            i_intervenant = iUnIntervenant;
            i_intervenant.AjouterPrestation(this);
        }

        public DateTime DateSoin { get => dateSoin; }
        public DateTime HeureSoin { get => heureSoin; }
        internal Intervenant I_intervenant { get => i_intervenant; }

        public int CompareTo (Prestation unePrestation)
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
        public override string ToString()
        {
            return "libelle "+libelle+" - "+dateSoin.Day+"/"+dateSoin.Month+"/"+dateSoin.Year+" - "+heureSoin.Hour+":"+heureSoin.Minute+":"+heureSoin.Second+" - Intervenant: "+i_intervenant;
        }
    }
}
