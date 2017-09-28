using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soins
{
    public class Intervenant
    {
        private string nom;
        private string prénom;
        private List<Prestation> lesPrestations;

        public Intervenant(string nom, string prénom)
        {
            this.nom = nom;
            this.prénom = prénom;
            lesPrestations = new List<Prestation>();
        }

        public string Nom
        {
            get => nom;
        }
        public string Prénom
        {
            get => prénom;
        }

        public void AjouterPrestation(Prestation unePrestation)
        {
            lesPrestations.Add(unePrestation);
        }

        public override string ToString()
        {
            return " Dr "+nom+" "+prénom+" ";
        }
    }
}
