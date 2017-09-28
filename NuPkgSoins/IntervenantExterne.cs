using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soins
{
    public class IntervenantExterne : Intervenant
    {
        private string spécialité;
        private string adresse;
        private string tel;
        public IntervenantExterne(string nom, string prénom ,string uneSpécialité,string uneAdresse,string unTel) : base(nom, prénom)
        {
            spécialité = uneSpécialité;
            adresse = uneAdresse;
            tel = unTel;
            Intervenant unIntervenant = new Intervenant(nom, prénom);
        }

        public string Spécialité
        {
            get => spécialité;
        }
        public string Adresse
        {
            get => adresse;
        }
        public string Tel
        {
            get => tel;
        }

        public override string ToString()
        {
            return base.ToString() +"Spécialité: "+this.spécialité+" - adresse: "+this.adresse+" - Tel: "+this.tel;
        }
    }
}
