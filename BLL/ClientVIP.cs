using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientVIP : Client
    {
        public decimal Ristourne { get; set; }
        public int QuantiteRistourne { get; set; }

        public ClientVIP()
        {
                
        }
        public ClientVIP(int idClient, decimal ca, DateTime dateCreation, decimal ristourne, int quantiteRistourne)
            : base(idClient, ca, dateCreation)
        {
            Ristourne = ristourne;
            QuantiteRistourne = quantiteRistourne;
        }
    }
}
