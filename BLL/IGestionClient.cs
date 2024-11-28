using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public interface IGestionClient
    {
        void AjouterClient(Client client);           
        Client ConsulterClient(int idClient);        
        void SupprimerClient(int idClient);          
        List<Client> ListerClients();                
    }
}
