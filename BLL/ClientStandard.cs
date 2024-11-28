using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientStandard : Client
    {
        public int Quantite { get; set; }
        public DateTime DateAffectation { get; set; }

        public ClientStandard()
        {

        }
        public ClientStandard(int idClient, decimal ca, DateTime dateCreation, int quantite, DateTime dateAffectation)
            : base(idClient, ca, dateCreation)
        {
            Quantite = quantite;
            DateAffectation = dateAffectation;
        }


        public override string ToString()
        {
            return "ClientStandard [ID: " + IdClient +
                   ", CA: " + CA +
                   ", DateCreation: " + DateCreation.ToString("yyyy-MM-dd") +
                   ", Quantite: " + Quantite +
                   ", DateAffectation: " + DateAffectation.ToString("yyyy-MM-dd") + "]";
        }
    }
}
