using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_clients
{
    public partial class GestionFenetre : Form
    {

        int IdNumClient = 0;
        // instancier la classe d'accès aux données
        ClasseClient DBClient = new ClasseClient();

        public GestionFenetre()
        {
            InitializeComponent();
        }

        private void GestionFenetre_Load(object sender, EventArgs e)
        {
            CB_Client.DataSource = DBClient.SQLClients();
            CB_Client.DisplayMember = "NomPrenom";
            CB_Client.ValueMember = "NUMCLIENT";
            CB_Client.SelectedIndex = 0;
        }
    }
}
