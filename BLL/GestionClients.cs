
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;

public class GestionClients : IGestionClient
{
    private readonly List<Client> clients;

    public GestionClients()
    {
        clients = new List<Client>();
    }

    public void AjouterClient(Client client)
    {
        try
        {
            clients.Add(client);
            Console.WriteLine("Client ajouté.");
        }
        catch (Exception ex)
        {

            clients.Add(client);
            Console.WriteLine(ex.Message);
        }

        
    }

    public Client ConsulterClient(int idClient)
    {
        return clients.FirstOrDefault(c => c.IdClient == idClient);
    }

    public void SupprimerClient(int idClient)
    {
        var client = ConsulterClient(idClient);
        if (client != null)
        {
            clients.Remove(client);
            Console.WriteLine("Client supprimé.");
        }
        else
        {
            Console.WriteLine("Client introuvable.");
        }
    }

    public List<Client> ListerClients()
    {
        return clients;
    }
}
