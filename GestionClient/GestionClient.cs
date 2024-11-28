using BLL;
using GUI;
using System.Data;

namespace GestionClient
{
    public partial class GestionClient : Form
    {

        public GestionClients gestion = new GestionClients();
        List<Client> clients = new List<Client>();

        public GestionClient()
        {
            InitializeComponent();
        }

        private void remplirListe()
        {
            listBox1.Items.Clear();
            foreach (Client a in clients)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioClientStand.Checked)
            {
                ClientStandard standars = new ClientStandard();
                AjouterClientStandard nv =
                    new AjouterClientStandard(standars);
                if (nv.ShowDialog() == DialogResult.Cancel)
                {
                    gestion.AjouterClient(standars);
                }
                clients = gestion.
                    ListerClients();
                remplirListe();

            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
