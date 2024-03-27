using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classe_Rideau;

namespace Gestion_des_clients
{
    public partial class FrFenetre : Form
    {
        int IdNumClient = 0;
        int IdNumFenetre = 0;
        ClasseClient DBClient = new ClasseClient();
        ClasseFenetre DBFenetre = new ClasseFenetre();

        public FrFenetre()
        {
            InitializeComponent();
        }

        private void FrFenetre_Load(object sender, EventArgs e)
        {
            CB_Client.DataSource = DBClient.SQLClients();
            CB_Client.DisplayMember = "NomPrenom";
            CB_Client.ValueMember = "NUMCLIENT";
            CB_Client.SelectedIndex = 0;

            CB_Client.DataSource = DBClient.SQLClients();
            CB_Client.DisplayMember = "NomPrenom";
            CB_Client.ValueMember = "NUMCLIENT";
            CB_Client.SelectedIndex = 0;

        }

        private void CB_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(CB_Client.SelectedValue.ToString(), out IdNumClient);
            if (IdNumClient > 0)
            {
                LB_Fenetre.DataSource = DBFenetre.SQLFenetreClient(IdNumClient);
                LB_Fenetre.DisplayMember = "NUMFENETRE";
                LB_Fenetre.ValueMember = "NUMFENETRE";
                LB_Fenetre.SelectedIndex = 0;
            }
        }

        private void CB_Fenetre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LB_Fenetre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(LB_Fenetre.SelectedValue.ToString(), out IdNumFenetre);
            if (IdNumFenetre > 0)
            {
                DataTable table;
                table = DBFenetre.SQLSelectFenetre(IdNumFenetre);

                // Afficher détail du client sélectionné dans la liste
                NUP_Hauteur.Value = (decimal)DBFenetre.hauteurFenetre;
                NUP_Largeur.Value = (decimal)DBFenetre.largeurFenetre;
            }
        }
    }
}
