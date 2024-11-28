using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Client
    {
        public int IdClient { get; set; }
        public decimal CA { get; set; }
        public DateTime DateCreation { get; set; }

        public Client()
        {

        }
        public Client(int idClient, decimal ca, DateTime dateCreation)
        {
            IdClient = idClient;
            CA = ca;
            DateCreation = dateCreation;
        }
    }
}
