using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AjouterClientStandard : Form
    {
        public ClientStandard cl;
        public AjouterClientStandard(ClientStandard c)
        {
            InitializeComponent();
            this.cl = c;
        }

        private void label4_Click(object sender, EventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl.IdClient = int.Parse(textId.Text);
            cl.CA = decimal.Parse(textCA.Text);
            cl.DateCreation = DateTime.Parse(textDateCreation.Text);
            cl.Quantite = int.Parse(textQa.Text);
            cl.DateAffectation = DateTime.Parse(textDateAffec.Text);
            this.Close();
        }

        private void AjouterClientStandard_Load(object sender, EventArgs e)
        {

        }
    }
}
