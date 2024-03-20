using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_clients
{
    public partial class FrClient : Form
    {

        int IdNumClient = 0;
        // instancier la classe d'accès aux données
        ClasseClient DBRideau = new ClasseClient();

        public FrClient()
        {
            InitializeComponent();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            DBRideau.SQLDeleteClient((int)NUP_NumeroClient.Value);

            // Mettre à jour la listBox
            LB_Client.DataSource = DBRideau.SQLClients();
            LB_Client.DisplayMember = "NomPrenom";
            LB_Client.ValueMember = "NUMCLIENT";
            LB_Client.SelectedIndex = 0;
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                DBRideau.SQLInsertClient((int)NUP_NumeroClient.Value, TB_NomClient.Text, TB_PrenomClient.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LB_Client.DataSource = DBRideau.SQLClients();
            LB_Client.DisplayMember = "NomPrenom";
            LB_Client.ValueMember = "NUMCLIENT";
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            // Vérification des données

            // Modifier les données dans la table client
            int.TryParse(LB_Client.SelectedValue.ToString(), out IdNumClient);
            DBRideau.SQLUpdateClient((int)NUP_NumeroClient.Value, TB_NomClient.Text, TB_PrenomClient.Text);

            // Mettre à jour la listBox
            LB_Client.DataSource = DBRideau.SQLClients();
            LB_Client.DisplayMember = "NomPrenom";
            LB_Client.ValueMember = "NUMCLIENT";
            LB_Client.SelectedIndex = 0;
        }

        private void Btn_Nouveau_Click(object sender, EventArgs e)
        {
            TB_NomClient.Text = "";
            TB_PrenomClient.Text = "";
            IdNumClient = DBRideau.SQLMaxNumClient() + 1;
            NUP_NumeroClient.Text = IdNumClient.ToString();
        }

        private void FrClient_Load_1(object sender, EventArgs e)
        {
            LB_Client.DataSource = DBRideau.SQLClients();
            LB_Client.DisplayMember = "NomPrenom";
            LB_Client.ValueMember = "NUMCLIENT";
            LB_Client.SelectedIndex = 0;

            NUP_NumeroClient.Value = Convert.ToDecimal(LB_Client.SelectedValue);
            int.TryParse(LB_Client.SelectedValue.ToString(), out IdNumClient);
            if (IdNumClient > 0)
            {
                DataTable table;
                table = DBRideau.SQLSelectClient(IdNumClient);
                TB_NomClient.Text = table.Rows[0][1].ToString();
                TB_PrenomClient.Text = table.Rows[0][2].ToString();
            }
        }

        private void LB_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(LB_Client.SelectedValue.ToString(), out IdNumClient);
            if (IdNumClient > 0)
            {
                DataTable table;
                table = DBRideau.SQLSelectClient(IdNumClient);

                // Afficher détail du client sélectionné dans la liste
                NUP_NumeroClient.Value = (int)DBRideau.numClient;
                // TbNumClient.Text = table.Rows[0][0].ToString();
                TB_NomClient.Text = DBRideau.nomClient;
                // TbNomClient.Text = table.Rows[0][1].ToString();
                TB_PrenomClient.Text = DBRideau.prenomClient;
                // TbPrenomClient.Text = table.Rows[0][2].ToString();                
            }
        }
    }

}
